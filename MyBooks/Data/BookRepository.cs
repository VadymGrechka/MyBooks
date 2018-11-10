using MyBooks.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;

namespace MyBooks.Data
{
    class BookRepository
    {
        public IEnumerable<Book> GetAll()
        {
            const string commandText = "SELECT Id, Name, Description, Author, DateCreated FROM Book ORDER BY Id DESC";

            using (var connection = GetOpenConnection())
            {
                var command = new SqlCeCommand(commandText, connection);

                var reader = command.ExecuteReader();
                while (reader.Read())
                    yield return ReadFromReader(reader);
            }
        }

        private SqlCeConnection GetOpenConnection()
        {
            var connection = new SqlCeConnection(Settings.ConnectionString);
            connection.Open();
            return connection;
        }

        private Book ReadFromReader(SqlCeDataReader reader)
        {
            return new Book
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1),
                Description = reader.GetString(2),
                Author = reader.GetString(3),
                DateCreated = reader.GetDateTime(4)
            };
        }
        public void Create(Book entry)
        {
            const string commandText = @"INSERT INTO Book (Name, Author, Description, DateCreated) VALUES 
                                        (@Name, @Author, @Description, @DateCreated)";

            using (var connection = GetOpenConnection())
            {
                var command = new SqlCeCommand(commandText, connection);
                command.Parameters.AddWithValue("@Name", entry.Name);
                command.Parameters.AddWithValue("@Author", entry.Author);
                command.Parameters.AddWithValue("@Description", entry.Description);
                command.Parameters.AddWithValue("@DateCreated", DateTime.UtcNow);
                command.ExecuteNonQuery();
            }
        }
    }
}