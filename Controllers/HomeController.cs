using CustomerOrder.Core.Entity;
using CustomerOrder.Data.Repository;
using CustomerOrder.Models;
using Invoice.Data.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerOrder.Controllers
{
    public class HomeController : Controller
    {


        private readonly IOrderRepository _orderRepository;
        private OrderRepository _orderRepos;
        private readonly OrderDbContext _context;

        private readonly ICustomerRepository _customerRepository;
        private IConfiguration _iConfiguration;
        private readonly ILogger<HomeController> _logger;
        public HomeController(OrderDbContext context, ILogger<HomeController> logger, IConfiguration iConfiguration,
            IOrderRepository orderRepository, ICustomerRepository customerRepository)
        {
            _iConfiguration = iConfiguration;
            _orderRepository = orderRepository;
            _customerRepository = customerRepository;
            _logger = logger;
            _context = context;
            


        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View(_customerRepository.All());
        }
        [HttpPost]
        public IActionResult Index(CustomerOrderVm customerOrderVm)
        {
            OrderRepository normal = new NormalOrder(_context);
            OrderRepository special = new SpecialOrder(_context);

            Customer customer = new Customer
            {
                Location = customerOrderVm.Location,
                Name = customerOrderVm.Name
            };

            var id = _customerRepository.AddCustomer(customer);


            if (customerOrderVm.OrderType == 1)
            {
                Order order = new Order
                {
                    CustomerId = id,
                    Date = DateTime.Now,
                    Number = customerOrderVm.Number,
                };
                normal.SendOrder(order);

            }
            if (customerOrderVm.OrderType == 2)
            {
                Order order = new Order
                {
                    CustomerId = id,
                    Date = DateTime.Now,
                    Number = customerOrderVm.Number,
                    Descount = customerOrderVm.Descount,
                };
                special.SendOrder(order);
            }

            return View();
        }

    }
}
