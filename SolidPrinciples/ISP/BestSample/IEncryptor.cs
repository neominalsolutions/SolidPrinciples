using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.ISP.BestSample
{
    public interface IEncryptor
    {
        byte[] Encrypt(string plainText);
    }
}
