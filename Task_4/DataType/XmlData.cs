using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_4.Conversion;
using Task_4.DataType;

namespace Task_4.DataType
{
    public class XmlData : IDataPrototype
    {
        private string xmlContent;

        public XmlData(string xmlContent)
        {
            this.xmlContent = xmlContent;
        }

        public IDataPrototype Clone()
        {
            return new XmlData(xmlContent);
        }

        public void DisplayData()
        {
            Console.WriteLine("XML data:");
            Console.WriteLine(xmlContent);
        }
    }
}
