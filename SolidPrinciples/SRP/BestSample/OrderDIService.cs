using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SRP.BestSample
{

    // OCP, SRP ve DIP, DI örnekleri birleşerek kod en temiz haline geldi.

    public class OrderDIService
    {

        private IBankService _bankService;
        private IOrderRepository _orderRepository;
        private IProductRepository _productRepository;
        private IEmailService _emailService;

        public OrderDIService(IBankService bankService, IOrderRepository orderRepository, IProductRepository productRepository, IEmailService emailService)
        {
            _bankService = bankService;
            _orderRepository = orderRepository;
            _productRepository = productRepository;
            _emailService = emailService;
        }

            public void DoOrder(OrderInputModel model)
            {
                _bankService.Pay();
                _orderRepository.Save();
                _productRepository.Update();
                _emailService.SendEmail();
            }

        
    }
}
