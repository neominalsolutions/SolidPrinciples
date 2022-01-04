using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SRP.BestSample
{
    public interface IOrderRepository
    {
        void Save();
    }

    public class SQLServerOrderRepository : IOrderRepository
    {
        public void Save()
        {
            string query = "exec save";
        }
    }
    public class EFOrderRepository: IOrderRepository
    {
        public void Save()
        {

        }
    }


   
}
