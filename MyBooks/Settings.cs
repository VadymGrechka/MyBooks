using System.Configuration;

namespace MyBooks
{
    public static class Settings
    {
        public static string ConnectionString { get; private set; }

        static Settings()
        {
            ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
    }
}
