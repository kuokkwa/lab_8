using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class ConfigurationManager
    {
        private static ConfigurationManager instance = null;
        private static readonly object lockObject = new object();

        private string loggingMode;
        private string databaseConnection;
        private string userName;

        private ConfigurationManager()
        {

        }

        public static ConfigurationManager Instance
        {
            get
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new ConfigurationManager();
                    }
                    return instance;
                }
            }
        }

        public string LoggingMode
        {
            get { return loggingMode; }
            set
            {
                loggingMode = value;
                Console.WriteLine($"Logging Mode set to: {value}");
            }
        }

        public string DatabaseConnection
        {
            get { return databaseConnection; }
            set
            {
                databaseConnection = value;
                Console.WriteLine($"Database Connection set to: {value}");
            }
        }

        public string UserName
        {
            get { return userName; }
            set
            {
                userName = value;
                Console.WriteLine($"Username set to: {value}");
            }
        }

        public void DisplayConfiguration()
        {
            Console.WriteLine($"Logging Mode: {LoggingMode}");
            Console.WriteLine($"Database Connection: {DatabaseConnection}");
            Console.WriteLine($"Username: {UserName}");
        }
    }
}
