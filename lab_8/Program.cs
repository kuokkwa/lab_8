namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConfigurationManager configManager = ConfigurationManager.Instance;

            while (true)
            {
                Console.WriteLine("1 - Set/Change logging mode");
                Console.WriteLine("2 - Set/Change database connection");
                Console.WriteLine("3 - Set/Change username");
                Console.WriteLine("4 - Display configuration");
                Console.WriteLine("5 - Exit");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter logging mode:");
                            string loggingMode = Console.ReadLine();
                            configManager.LoggingMode = loggingMode;
                            break;
                        case 2:
                            Console.WriteLine("Enter database connection:");
                            string databaseConnection = Console.ReadLine();
                            configManager.DatabaseConnection = databaseConnection;
                            break;
                        case 3:
                            Console.WriteLine("Enter username:");
                            string userName = Console.ReadLine();
                            configManager.UserName = userName;
                            break;
                        case 4:
                            configManager.DisplayConfiguration();
                            break;
                        case 5:
                            return;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, enter a number");
                }
            }
        }
    }
}