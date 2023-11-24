using Task_2.ChartFactory;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChartClient client = new ChartClient();

            while (true)
            {
                Console.WriteLine("1 - Line graph");
                Console.WriteLine("2 - Bar graph");
                Console.WriteLine("3 - Pie chart");
                Console.WriteLine("4 - Exit");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    if (choice == 4)
                    {
                        break;
                    }

                    GraphFactory factory = null;

                    switch (choice)
                    {
                        case 1:
                            factory = new LineGraphFactory();
                            break;
                        case 2:
                            factory = new BarGraphFactory();
                            break;
                        case 3:
                            factory = new PieChartFactory();
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            continue;
                    }

                    client.SetFactory(factory);
                    client.VisualizeChart();
                }
                else
                {
                    Console.WriteLine("Invalid input, enter a number");
                }
            }
        }
    }
}