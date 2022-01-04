using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OCP.BestSample
{
    public class MoneyTransferService : PaymentBase
    {
        public string IBANNumber { get; set; }

        public override void Pay(decimal amount)
        {
            Console.WriteLine("Para EFT ile ödendi");
        }
    }
}
