using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.ISP.BadSample
{
    // md5- hash algoritması var.
    public interface ICryptor
    {
        /// <summary>
        /// Bir metni şifreler
        /// </summary>
        /// <param name="plainText"></param>
        /// <returns></returns>
        string Encrypt(string plainText);

        /// <summary>
        /// Şifrelenmiş bir metni çözer
        /// </summary>
        /// <param name="chipperText"></param>
        /// <returns></returns>
        string Decrypt(string chipperText);
    }
}
