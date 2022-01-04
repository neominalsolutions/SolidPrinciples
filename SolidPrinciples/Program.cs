using SolidPrinciples.ISP.BadSample;
using SolidPrinciples.OCP.BestSample;
using SolidPrinciples.SRP.BestSample;
using System;
using System.IO;
using System.Security.Cryptography;

namespace SolidPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //var orderService = new OrderService();
            //orderService.DoOrder(new OrderInputModel());


            //var orderDIService1 = new OrderDIService(new ABankService(), new EFOrderRepository(), new EFProductRepository(), new TurkcellEmailService());


            //var orderDIService2 = new OrderDIService(new BBankService(), new SQLServerOrderRepository(), new EFProductRepository(), new VodafoneEmailService());

            //var manager = new PaymentManager(PaymentType.Credit);
            //manager.Pay(21312321);

            //var diPaymentManager = new DIP.BestSample.PaymentManager(new CreditPaymentService());
            //diPaymentManager.Pay(213132);


            //var diPaymentManager2 = new DIP.BestSample.PaymentManager(new MoneyTransferService());
            //diPaymentManager2.Pay(213132);

            // c# tarafından unmanagement olarak işaretlenmiş içerisinde System IO (dosya işlemleri), Okuma yazma, Apiye call yapma, veri tabanına bağlanma, Stream ile verinin ramde tampon bölgeye çekildiği işlemler de c# ilgili sınıfları garbage colector üzerinden tamizleyemez. Bundan dolayı yazılımcıların bu tarz kodları using kod blogu içerisine yazması gerekir. Aes işleminde MemoryStream kullanıldığından using kod bloğu ile çevreledik. 

            using (AesManaged aes = new AesManaged())
            {
                var aes1 = new ISP.BestSample.AESCryptor();
                aes1.Key = aes.Key;
                aes1.IV = aes.IV;

                byte[] chiper = aes1.Encrypt("Merhaba Dünya");
                var plainText = aes1.Decrypt(chiper);
            }




            var hash = new ISP.BestSample.HashCryptor();
            byte[] passwordByte = hash.Encrypt("23432hujsad0*43");


            // hexadecimal formatına çevrilmiş şifrelenmiş parola
            string password = hash.GetHexdecimalString(passwordByte);

             





            //// Encrypt string    
            //byte[] encrypted = Encrypt("Merhaba Dünya", aes.Key, aes.IV);
            //// Print encrypted string    
            //Console.WriteLine($"Encrypted data: {System.Text.Encoding.UTF8.GetString(encrypted)}");
            //// Decrypt the bytes to a string.    
            //string decrypted = Decrypt(encrypted, aes.Key, aes.IV);
            //// Print decrypted string. It should be same as raw data    
            //Console.WriteLine($"Decrypted data: {decrypted}");



            Console.ReadKey();


        }


    

    }
}
