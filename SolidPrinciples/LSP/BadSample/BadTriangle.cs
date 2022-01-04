using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LSP.BadSample
{
    public class BadTriangle : BadShapeBase
    {
        public double ACorner { get; set; }
        public double BCorner { get; set; }
        public double CCorner { get; set; }



        public override double GetArea()
        {
            return (CCorner * Height) / 2;
        }

        public override double GetPerimeter()
        {
            return ACorner + BCorner + CCorner;
        }
    }
}
