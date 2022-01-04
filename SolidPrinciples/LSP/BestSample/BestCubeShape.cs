using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LSP.BestSample
{
    public class BestCubeShape : BestThreeDimensionShapeBase
    {
        public double Size { get; set; }

        public override double GetArea()
        {
            return 6 * Math.Pow(Size, 2);
        }

        public override double GetPerimeter()
        {
            return Size * 12;
        }

        public override double GetVolume()
        {
            return Math.Pow(Size, 3);
        }
    }
}
