using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class ChartClient
    {
        private GraphFactory factory;

        public void SetFactory(GraphFactory factory)
        {
            this.factory = factory;
        }

        public void VisualizeChart()
        {
            IChart chart = factory.CreateChart();

            Console.WriteLine("Enter data for the graph/chart (comma-separated integers):");
            string input = Console.ReadLine();
            List<int> inputData = input.Split(',').Select(int.Parse).ToList();
            chart.SetData(inputData);

            chart.Draw();
        }
    }
}
