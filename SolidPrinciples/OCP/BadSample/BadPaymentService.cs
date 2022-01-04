using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OCP.BadSample
{
    // OCP bir sınıf gelişime açık değişime (modification) kapalı olmalı.

    // Hava ve EFT ile ödeme alacak bir sistem yapalım

    // hem gelişime hemde değişime açık bir sınıf yazmış olduk. Farklı ödeme tipleri sisteme eklendiği takdirde her seferinde kodumuz güncellenmek zorunda kalacaktır.ve her seferinde bu servis içerisindeki kodları test etmemiz gerekecektir.
    public class BadPaymentService
    {
        // Kredi kartı numarası
        public string CardNumber { get; set; }
        public string VirtualCardNumber { get; set; }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountNumber">Hesap Numarası</param>
        /// <param name="amount">Hesaba geçilecek olan miktar</param>
        public void Pay(string accountNumber, decimal amount, int paymentType)
        {
            // Havale işlemleri için gerekli kodları yazdık.

            if(paymentType == 0)
            {
                // Havale
            }
            else if(paymentType == 1)
            {
                // Credi Kartı ile ödeme
            }
            else
            {
                // Sanal Kart ile ilgili işlemler.
            }



            // mustafa
            if(paymentType == 1)
            {

            }
        }

    }
}
