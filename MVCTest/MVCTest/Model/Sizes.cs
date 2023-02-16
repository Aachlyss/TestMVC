using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTest.Model
{
    public class Sizes
    {
        public Sizes(double n, double w, double l, double m, double o)
        {
            this.N = n;
            this.W = w;
            this.L = l;
            this.M = m;
            this.O = o;
        }

        public double N { get; set; }
        public double W { get; set; }
        public double L { get; set; }
        public double M { get; set; }
        public double O { get; set; }

        public double CalculateТiles()
        {
            double S = N * N;
            double tile = W*L;
            double bench = M*O;

            double allAfter = (S - bench) * (tile * tile);
            return allAfter;
        }

        public double TimeNeeded()
        {
            double S = N * N;
            double tile = W * L;
            double bench = M * O;

            double allAfter = (S - bench) * (tile * tile);
            double timeNeeded = allAfter * 0.2;
            return allAfter;
        }
    }
}
