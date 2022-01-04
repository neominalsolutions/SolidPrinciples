using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SRP.BadSample
{
    public class BadProduct
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public short Stock { get; set; }

    }

    public class BadCustomerCredit
    {
        public string CardNumber { get; set; }
        public string ValidThru { get; set; }
        public string CVV { get; set; }

    }

  
    public class BankService
    {
       public void Pay()
        {

        }
    }
   

    public class BadOrderService
    {
        public string CustomerName { get; set; }
        public string Address { get; set; }

        private BankService bankService = new BankService();
       

        public void DoOrder(List<BadProduct> products, BadCustomerCredit credit)
        {
           

            // OrderRepository
            string query = "insert into orders() values()";
            bankService.Pay();
            // ProductRepository
            string productquery = "update products set stock where productId=1";


            // EmailService
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("email", "password"),
                EnableSsl = true,
            };

            smtpClient.Send("email", "recipient", "subject", "body");

            // Ürünler sipariş tablosuna kaydedilecek
            // Sipariş tablosuna kaydedilmeden önce banka servisinden müşterini kart bilgilerine göre para çekilecek
            // Ürünün stok bilgisi güncellenecek
            // mail atma işlemi



        }


    }
}
