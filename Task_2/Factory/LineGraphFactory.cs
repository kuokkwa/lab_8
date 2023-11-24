using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.ForChart;

namespace Task_2.ChartFactory
{
    internal class LineGraphFactory: GraphFactory
    {
        public override IChart CreateChart()
        {
            return new LineGraph();
        }
    }
}
