using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.ISP.BestSample
{
    // bu sınıf ise genelde paralaların şifreli bir şekilde tutulması ile ilgilenir.Parola geri çözülemez. Şifrelenmiş parolalar eşleşiyorsa parola onaylanır.
    // Kullanıcı hesaplarını şifrelemek için bu algoritma kullanılır.
    public class HashCryptor : IEncryptor
    {


        public byte[] Encrypt(string plainText)
        {
            //Parametre olarak gelen veriyi byte dizisine dönüştürdük.
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] dizi = Encoding.UTF8.GetBytes(plainText);
            //dizinin hash'ini hesaplattık.
            dizi = md5.ComputeHash(dizi);

            return dizi;
        }


        public string GetHexdecimalString(byte[] array)
        {

            StringBuilder sb = new StringBuilder();
            //Her byte'i dizi içerisinden alarak string türüne dönüştürdük.

            foreach (byte ba in array)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }

            //hexadecimal(onaltılık) stringi geri döndürdük.
            return sb.ToString();
        }
    }
}

