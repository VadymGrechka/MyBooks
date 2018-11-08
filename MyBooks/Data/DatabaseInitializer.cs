using System.Data.SqlServerCe;
using System.IO;
using System.Reflection;

namespace MyBooks.Data
{
    public static class DatabaseInitializer
    {
        public static void CreateDb()
        {
            var directoryName = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            var dbFileName = Path.Combine(directoryName, "Library.sdf");

            if (File.Exists(dbFileName))
                return;

            var engine = new SqlCeEngine(Settings.ConnectionString);
            engine.CreateDatabase();

            using (var connection = new SqlCeConnection(Settings.ConnectionString))
            {
                connection.Open();
                using (var query = connection.CreateCommand())
                {
                    query.CommandText = @"CREATE TABLE Book (
                                Id INT IDENTITY(1,1) PRIMARY KEY, 
                                Name NVARCHAR(150) NOT NULL,
                                Author NVARCHAR(150) NULL,
                                Description NTEXT NULL,
                                DateCreated DateTime NOT NULL
                            );";
                    query.ExecuteNonQuery();
                }
            }
        }
    }
}