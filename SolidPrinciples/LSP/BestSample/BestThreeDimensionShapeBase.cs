using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LSP.BestSample
{
    /// <summary>
    /// Bir abstract class başka bir abstract class tan kalıtım alınca methodlarını implemente etmemeiz gerekmez. ikiside soyut sınıftır.
    /// </summary>
    public abstract class BestThreeDimensionShapeBase: BestTwoDimensionShapeBase
    {
        /// <summary>
        /// 3 boyutlu nesnelerin hacmini hesaplamamıza yarar
        /// </summary>
        /// <returns></returns>
        public abstract double GetVolume();
    }
}
