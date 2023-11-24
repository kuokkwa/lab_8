using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_4.Conversion;
using Task_4.DataType;

namespace Task_4.DataType
{
    public class JsonData : IDataPrototype
    {
        private string jsonContent;

        public JsonData(string jsonContent)
        {
            this.jsonContent = jsonContent;
        }

        public IDataPrototype Clone()
        {
            return new JsonData(jsonContent);
        }

        public void DisplayData()
        {
            Console.WriteLine("JSON data:");
            Console.WriteLine(jsonContent);
        }
    }
}
