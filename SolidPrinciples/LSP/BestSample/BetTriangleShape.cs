using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LSP.BestSample
{
    public class BetTriangleShape : BestTwoDimensionShapeBase
    {
        public double CornerA { get; set; }
        public double CornerB { get; set; }
        public double CornerBase { get; set; }

        public double Height { get; set; }

        public override double GetArea()
        {
            return (CornerBase * Height) / 2;
        }

        public override double GetPerimeter()
        {
            return CornerA + CornerB + CornerBase;
        }
    }
}
