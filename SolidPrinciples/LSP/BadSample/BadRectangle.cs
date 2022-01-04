using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LSP.BadSample
{
    /// <summary>
    /// Dikdörtgen sınıfımı
    /// </summary>
    public class BadRectangle : BadShapeBase
    {
        public override double GetArea()
        {
            return Width * Height;
        }

        public override double GetPerimeter()
        {
            return (2 * (Width + Height));
        }
    }
}
