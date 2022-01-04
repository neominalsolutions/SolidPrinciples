using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OCP.BestSample
{
    public class VirtualCardPaymentService : IPaymentService
    {
        public string SenderIBanNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Pay(decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
