using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_3.CameraType;
using Task_3.Components;
using Task_3.ProcessorType;
using Task_3.ScreenType;

namespace Task_3.Factory
{
    public class LaptopFactory : TechProductFactory
    {
        public override Screen CreateScreen()
        {
            return new OLED();
        }

        public override Processor CreateProcessor()
        {
            return new IntelCore();
        }

        public override Camera CreateCamera()
        {
            return new DualCamera();
        }
    }
}
