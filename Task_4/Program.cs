using Task_4.Conversion;
using Task_4.DataType;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose the source data format:");
                Console.WriteLine("1 - CSV");
                Console.WriteLine("2 - XML");
                Console.WriteLine("3 - JSON");
                Console.WriteLine("4 - Exit");

                int sourceChoice;
                if (!int.TryParse(Console.ReadLine(), out sourceChoice))
                {
                    Console.WriteLine("Invalid input, enter a number");
                    continue;
                }

                if (sourceChoice == 4)
                {
                    break;
                }

                Console.WriteLine("Choose the target data format:");
                Console.WriteLine("1 - XML");
                Console.WriteLine("2 - JSON");

                int targetChoice;
                if (!int.TryParse(Console.ReadLine(), out targetChoice))
                {
                    Console.WriteLine("Invalid input, enter a number");
                    continue;
                }

                IDataPrototype sourceData = null;

                switch (sourceChoice)
                {
                    case 1:
                        sourceData = new CsvData(new List<string[]> { new string[] { "Data1", "Data2" }, new string[] { "Data3", "Data4" } });
                        break;
                    case 2:
                        sourceData = new XmlData("<data><item>Data1</item><item>Data2</item></data>");
                        break;
                    case 3:
                        sourceData = new JsonData("{ \"item\": [\"Data1\", \"Data2\"] }");
                        break;
                }

                IDataAdapter adapter = null;

                switch (targetChoice)
                {
                    case 1:
                        adapter = new CsvToXmlAdapter();
                        break;
                    case 2:
                        adapter = new CsvToJsonAdapter();
                        break;
                }

                if (adapter != null)
                {
                    IDataPrototype targetData = adapter.ConvertData(sourceData.Clone());
                    targetData.DisplayData();
                }
            }
        }
    }
}