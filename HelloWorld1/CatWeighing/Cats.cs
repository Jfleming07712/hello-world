using System;
using System.Collections.Generic;
using System.Text;

namespace CatWeighing
{
    class Cat
    {
        public Cat (string name)
        {
            weights = new List<double>();
            this.name = name;
        }
        public void AddWeight(double weight)
        {
            weights.Add(weight); 
        }

        public void ShowCatStats()
        {

            var result = 0.0;
            var lowWeight = double.MaxValue;
            var highWeight = double.MinValue;

            foreach (var number in weights) 
            {
                lowWeight = Math.Min(number, lowWeight);
                highWeight = Math.Max(number, highWeight);
                result += number;
            }
            result /= weights.Count;
            Console.WriteLine($"Lerroy's lowest weight was {lowWeight:N2}");
            Console.WriteLine($"Lerroy's highest weight was {highWeight:N2}");
            Console.WriteLine($"Lerroy's average weight was {result:N2}");
        }

        private List<double> weights;
        private string name;
    }
}
