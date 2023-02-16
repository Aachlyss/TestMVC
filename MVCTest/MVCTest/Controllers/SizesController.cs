using MVCTest.Model;
using MVCTest.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTest.Controllers
{
    public class SizesController
    {
        private Display display;
        private Sizes sizes;

        public SizesController()
        {
            display = new Display();
            sizes = new Sizes(display.N, display.W, display.L, display.M, display.O);
            display.CalculateTheTiles = sizes.CalculateТiles();
            display.ShowValues();
        }
    }
}
