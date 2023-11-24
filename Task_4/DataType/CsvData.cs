using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_4.Conversion;
using Task_4.DataType;

namespace Task_4.DataType
{
    public class CsvData : IDataPrototype
    {
        private List<string[]> data;

        public CsvData(List<string[]> data)
        {
            this.data = data;
        }

        public IDataPrototype Clone()
        {
            return new CsvData(new List<string[]>(data));
        }

        public void DisplayData()
        {
            Console.WriteLine("CSV data:");
            foreach (var row in data)
            {
                Console.WriteLine(string.Join(",", row));
            }
        }
    }
}
