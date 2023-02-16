using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTest.View
{
    public class Display
    {
        public Display()
        {
        }

        public Display(double n, double w, double l, double m, double o, double calculateTiles, double timeNeeded)
        {
            this.N = 0;
            this.W = 0;
            this.L = 0;
            this.M = 0;
            this.O = 0;
            this.CalculateTheTiles = 0;
            this.TimeNeeded = 0;
            this.GetValues();

        }

        public double N { get; set; }

        public double W { get; set; }

        public double L  { get; set; }

        public double M { get; set; }

        public double O { get; set; }
        public double CalculateTheTiles { get; set; }
        public double TimeNeeded { get; set; }

        public void GetValues()
        {
            Console.WriteLine("Enter N");
            this.N = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter W");
            this.W = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter L");
            this.L = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter M");
            this.M = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter O");
            this.O = double.Parse(Console.ReadLine());
        }

        public void ShowValues()
        {
            Console.WriteLine($"The amount of tiles needed is: {this.CalculateTheTiles:f2}");
            Console.WriteLine($"The time needed is: {this.TimeNeeded:f2}");
        }

    }
}
