using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OCP.BestSample
{
    public enum PaymentType
    {
        MoneyTransfer = 1,
        Credit = 2
    }

    // Bu sınıfın amacı gelen ödeme tipinde göre doğpru ödeme servisin çalışmasını sağlamak.
    public class PaymentManager
    {
        PaymentType _paymentType;
        private CreditPaymentService CreditPaymentService = new CreditPaymentService();
        private MoneyTransferService MoneyTransferService = new MoneyTransferService();

        /// <summary>
        /// Payment Type söylemeden bu nesnenin bir anlamı olmadğı için constructor ile zorunlu hale getirdik.
        /// </summary>
        /// <param name="paymentType"></param>
        public PaymentManager(PaymentType paymentType)
        {
            _paymentType = paymentType;
        }


        public void Pay(decimal amount)
        {
            if(_paymentType == PaymentType.Credit)
            {
                CreditPaymentService.Pay(amount);
            }
            else if(_paymentType == PaymentType.MoneyTransfer)
            {
                MoneyTransferService.Pay(amount);
            }
        }
    }
}
