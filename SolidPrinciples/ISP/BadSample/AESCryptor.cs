using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.ISP.BadSample
{
    // instantly messaging yani chat sistemlerinde gönderilen metnin şifrelenmesi veya wireless teknolojilerinde bir networkün şifrelenmesi için yaygın kullanılır. Şifrelenen değer geri çözülebilir.
    public class AESCryptor : ICryptor
    {
        public string Decrypt(string chipperText)
        {
            throw new NotImplementedException();
        }

        public string Encrypt(string plainText)
        {
            throw new NotImplementedException();
        }
    }
}
