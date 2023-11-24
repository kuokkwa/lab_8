using Task_3.Factory;
using Task_3.FactoryType;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TechProductAssembler assembler = new TechProductAssembler();

            while (true)
            {
                Console.WriteLine("Choose the type of tech product:");
                Console.WriteLine("1 - Smartphone");
                Console.WriteLine("2 - Tablet");
                Console.WriteLine("3 - Laptop");
                Console.WriteLine("4 - Exit");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    if (choice == 4)
                    {
                        break;
                    }

                    TechProductFactory factory = null;

                    switch (choice)
                    {
                        case 1:
                            factory = new SmartphoneFactory();
                            break;
                        case 2:
                            factory = new TabletFactory();
                            break;
                        case 3:
                            factory = new LaptopFactory();
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            continue;
                    }

                    assembler.SetFactory(factory);
                    assembler.AssembleProduct();
                }
                else
                {
                    Console.WriteLine("Invalid input, enter a number");
                }
            }
        }
    }
}