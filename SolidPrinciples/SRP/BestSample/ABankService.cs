using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SRP.BestSample
{
    // Garanti
    public  class ABankService: IBankService
    {
        public void Pay()
        {

        }
    }


    // ING bank
    public class BBankService : IBankService
    {
        public void Pay()
        {

        }
    }
    public interface IBankService
    {
        void Pay();
    }
}
