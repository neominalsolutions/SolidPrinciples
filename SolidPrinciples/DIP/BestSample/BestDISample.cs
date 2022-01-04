using SolidPrinciples.DIP.BadSample;
using SolidPrinciples.OCP.BestSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DIP.BestSample
{
    public class PaymentManager
    {
        // PaymentManager ile CreditPayment Service veya Money Transfer Service arasına bir abstract sınıf veya interface koyduk. DIP, yani iki sınıfın birbileri ile direk çalışmaması arayüzler üzerinden birbileri ile haberleşmesi için bunu yaptık.
        private PaymentBase _paymentService;
      

        /// <summary>
        /// Payment Type söylemeden bu nesnenin bir anlamı olmadğı için constructor ile zorunlu hale getirdik.
        /// </summary>
        /// <param name="paymentType"></param>
        public PaymentManager(PaymentBase paymentService)
        {
            // constuctor dıp uygulayarak sınıfı instance üretme sorumluluğundan kurtardık.
            // Dependecy Injection kullandık.
            _paymentService = paymentService;
        }


        public void Pay(decimal amount)
        {
            // bu manager gelen istance göre doğru servisin tetiklenmesini sağlamış oluyor.
            _paymentService.Pay(amount);
        }
    }
}
