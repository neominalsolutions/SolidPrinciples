using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OCP.BestSample
{
    // OCP kullanırken her gelen yeni iş istediği için bir sınıf açarız. bu açılan sınıfı ise ortak bir arayüzden yada abstract sınıftan türetiriz. Bu ortak olan arayüz işin özetini belirtiğimiz bir methodu içinde barındırır. Örnek PaymentBase abstract class

    public class CreditPaymentService : PaymentBase
    {
        public string CreditNumber { get; set; }
        public string ValidThru { get; set; }
        public string CVV { get; set; }

        public override void Pay(decimal amount)
        {
            Console.WriteLine("Para kredi kartı ile ödendi");
        }
    }
}
