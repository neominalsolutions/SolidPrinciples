using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LSP.BadSample
{
    /// <summary>
    /// Liskov prensibinde sorunu base sınıfta aramamız lazım çünkü baseden kalıtım alan sınıflar base özelliklerini gösterirken zorlanıyorlar. 
    /// </summary>
    public abstract class BadShapeBase
    {
        /// <summary>
        /// Yükseklik Değeri
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        /// Genişlik Değeri
        /// </summary>
        public double Width { get; set; }


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
