using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.ForChart
{
    internal class BarGraph: IChart
    {
        private List<int> data;

        public void Draw()
        {
            Console.WriteLine("Drawing 'bar graph'...");
            Console.WriteLine($"Data: {string.Join(", ", data)}");
        }

        public void SetData(List<int> data)
        {
            this.data = data;
        }
    }
}
