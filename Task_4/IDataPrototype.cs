using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_4.Conversion;
using Task_4.DataType;

namespace Task_4
{
    public interface IDataPrototype
    {
        IDataPrototype Clone();
        void DisplayData();
    }
}
