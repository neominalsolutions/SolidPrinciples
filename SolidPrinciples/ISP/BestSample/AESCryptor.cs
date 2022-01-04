using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.ISP.BestSample
{
    // instantly messaging yani chat sistemlerinde gönderilen metnin şifrelenmesi veya wireless teknolojilerinde bir networkün şifrelenmesi için yaygın kullanılır. Şifrelenen değer geri çözülebilir.
    public class AESCryptor : IEncryptor, IDecryptor
    {
       public byte[] Key { get; set; }
        
        public byte[] IV { get; set; }

        public string Decrypt(byte[] chiper)
        {
            //byte[] chiperData = Encoding.ASCII.GetBytes(chipperText);

            string plaintext = null;
            // Create AesManaged    
            using (AesManaged aes = new AesManaged())
            {
                // Create a decryptor    
                ICryptoTransform decryptor = aes.CreateDecryptor(Key, IV);
                // Create the streams used for decryption.    
                using (MemoryStream ms = new MemoryStream(chiper))
                {
                    // Create crypto stream    
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        // Read crypto stream    
                        using (StreamReader reader = new StreamReader(cs))
                            plaintext = reader.ReadToEnd();
                    }
                }
            }
            return plaintext;
        }

        public byte[] Encrypt(string plainText)
        {
            byte[] encrypted;

            using (AesManaged aes = new AesManaged())
            {
                // Create encryptor    
                ICryptoTransform encryptor = aes.CreateEncryptor(Key, IV);
                // Create MemoryStream    
                using (MemoryStream ms = new MemoryStream())
                {
                    // Create crypto stream using the CryptoStream class. This class is the key to encryption    
                    // and encrypts and decrypts data from any given stream. In this case, we will pass a memory stream    
                    // to encrypt    
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        // Create StreamWriter and write data to a stream    
                        using (StreamWriter sw = new StreamWriter(cs))
                            sw.Write(plainText);
                        encrypted = ms.ToArray();

                        //Her byte'i dizi içerisinden alarak string türüne dönüştürdük.

                       
                    }

                }
            }

            return encrypted;
        }

      
    }
}
