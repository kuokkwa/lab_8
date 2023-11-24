using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_3.CameraType;
using Task_3.ScreenType;
using Task_3.ProcessorType;
using Task_3.Components;

namespace Task_3.FactoryType
{
    public class SmartphoneFactory : TechProductFactory
    {
        public override Screen CreateScreen()
        {
            return new AMOLED();
        }

        public override Processor CreateProcessor()
        {
            return new Dimensity();
        }

        public override Camera CreateCamera()
        {
            return new TripleCamera();
        }
    }
}
