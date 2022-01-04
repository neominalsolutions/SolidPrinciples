using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OCP.BestSample
{

    // bu payment ödeme işlemini yapmamızı sağlayan arayüzümüz yani ödeme işleminin nasıl yapılacağına dair işin özetini veren base sınıf.
    public abstract class PaymentBase
    {
        public string SenderIBanNumber { get; set; }


        // eğer bir abstract sınıf içerisinde bir abstract method yada üye kullanıyorsak o işin detayını bilmiyoruzdur. sadece özetine dair bir fikrmimiz vardır.
        public abstract void Pay(decimal amount);
    }

    public interface IPaymentService
    {
        string SenderIBanNumber { get; set; }
        void Pay(decimal amount);
    }
}
