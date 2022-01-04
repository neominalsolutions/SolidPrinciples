using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LSP.BestSample
{
    public class BestSquareShape : BestTwoDimensionShapeBase
    {
        public double Size { get; set; }

        public override double GetArea()
        {
            return Size * Size;
        }

        public override double GetPerimeter()
        {
            return Size * 4;
        }
    }
}
