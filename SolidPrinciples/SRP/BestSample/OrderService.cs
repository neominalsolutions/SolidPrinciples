using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SRP.BestSample
{

    // Bir sınıfın değişmesi yada sınıf içinde methodun değişmesi için tek bir sebep olması prensibine single responsibity denir. Single Responsibilty prensibinde her bir sınıfın kendisi ile alakalı sorumluluğa ayrımını yaparız.  

    public class Cart
    {
        public decimal TotolPrice { get; set; }

        public List<CartItem> Items { get; set; }


    }

    public class CartItem
    {
        public int Quantity { get; set; }
        public int ProductId { get; set; }

        public decimal Price { get; set; }

    }

    public class CustomerInfo
    {
        public string CustomerName { get; set; }
        public string Address { get; set; }

        public string CreditCardNumber { get; set; }
        public string ValidThru { get; set; }
        public string CVV { get; set; }

    }

    public class OrderInputModel
    {
        public Cart CartInfo { get; set; }
        public CustomerInfo CustomerInfo { get; set; }


        // Sepet Bilgileri
    }

   

    public class OrderService
    {
        private ABankService BankService = new ABankService();
        private EFOrderRepository orderrepository = new EFOrderRepository();
        private EFProductRepository ProductRepository = new EFProductRepository();
        private TurkcellEmailService EmailService = new TurkcellEmailService();

        public OrderService()
        {

        }

        public void DoOrder(OrderInputModel model)
        {
            BankService.Pay();
            orderrepository.Save();
            ProductRepository.Update();
            EmailService.SendEmail();
        }

    }
}
