using System;
using System.Collections.Generic;
using System.Text;


namespace CatWeighing
{
    class Program
    {
        static void Main(string[] args)
        {
            var cat = new Cat("Lerroy");
            cat.AddWeight(2.3);
            cat.AddWeight(3.1);
            cat.AddWeight(3.8);
            cat.AddWeight(4.3);
            cat.AddWeight(5);
            cat.ShowCatStats();

        }
    }
}
