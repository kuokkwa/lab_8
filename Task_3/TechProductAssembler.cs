using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_3.Components;

namespace Task_3
{
    public class TechProductAssembler
    {
        private TechProductFactory factory;

        public void SetFactory(TechProductFactory factory)
        {
            this.factory = factory;
        }

        public void AssembleProduct()
        {
            Screen screen = factory.CreateScreen();
            Processor processor = factory.CreateProcessor();
            Camera camera = factory.CreateCamera();

            Console.WriteLine($"Assembling a tech product with the following components:");
            Console.WriteLine($"Screen: {screen.GetDescription()}");
            Console.WriteLine($"Processor: {processor.GetDescription()}");
            Console.WriteLine($"Camera: {camera.GetDescription()}");
        }
    }
}
