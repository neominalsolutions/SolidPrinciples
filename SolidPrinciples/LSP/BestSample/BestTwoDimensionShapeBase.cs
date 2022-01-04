using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LSP.BestSample
{
    public abstract class BestTwoDimensionShapeBase
    {
        /// <summary>
        /// Alan hesaplama methodu
        /// </summary>
        /// <returns></returns>
        public abstract double GetArea();

        /// <summary>
        /// Çevre Hesaplama methodu
        /// </summary>
        /// <returns></returns>
        public abstract double GetPerimeter();
    }
}
