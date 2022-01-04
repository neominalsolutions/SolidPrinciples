using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.ISP.BadSample
{
    // bu sınıf ise genelde paralaların şifreli bir şekilde tutulması ile ilgilenir.Parola geri çözülemez. Şifrelenmiş parolalar eşleşiyorsa parola onaylanır.
    // Kullanıcı hesaplarını şifrelemek için bu algoritma kullanılır.

    // ISP bir interface (arayüz) Kullanılmayan arabirime bağımlı (bağlı) olmaya zorlanmamalısın.
    public class HashCryptor : ICryptor
    {
        // kullanılmayan bir methodu interface kullandığımız implemente etmek zorundayız. 
        public string Decrypt(string chipperText)
        {
            // Hash algoritması ile bir geri çevirme işlemi olmayacağından ICryptor interfacedeki Decyrpt methodunu kullanamayacğız. 
            throw new NotImplementedException();
        }

        public string Encrypt(string plainText)
        {
            //Parametre olarak gelen veriyi byte dizisine dönüştürdük.
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] dizi = Encoding.UTF8.GetBytes(plainText);
            //dizinin hash'ini hesaplattık.
            dizi = md5.ComputeHash(dizi);
            //Hashlenmiş verileri depolamak için StringBuilder nesnesi oluşturduk.
            StringBuilder sb = new StringBuilder();
            //Her byte'i dizi içerisinden alarak string türüne dönüştürdük.

            foreach (byte ba in dizi)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }

            //hexadecimal(onaltılık) stringi geri döndürdük.
            return sb.ToString();
        }
    }
    
}
