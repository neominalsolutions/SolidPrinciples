using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LSP.BadSample
{
    // Kare
    public class BadSquare : BadShapeBase
    {
        public override double GetArea()
        {
            if(Width == Height)
            {
                return Width * Height;
            }
            else
            {
                throw new Exception("Kare olamaz");
            }
       
        }

        public override double GetPerimeter()
        {
            if(Width == Height)
            {
                return 4 * Height;
            }
            else
            {
                throw new Exception("Kare olamaz");
            }
        }
    }
}
