using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_4.Conversion;
using Task_4.DataType;

namespace Task_4.Conversion
{
    public class CsvToXmlAdapter : IDataAdapter
    {
        public IDataPrototype ConvertData(IDataPrototype sourceData)
        {
            Console.WriteLine("Converting CSV to XML...");
            return new XmlData("Converted XML data");
        }
    }
}
