using CustomerOrder.Core.Entity;
using CustomerOrder.Data.Repository.Base;
using CustomerOrder.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Invoice.Data.Repository
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        OrderDbContext _context;

        public CustomerRepository(OrderDbContext context) : base(context)
        {
            _context = context;
        }
        public List<CustomerOrderVm> All()
        {
            return _context.Orders.Include(x=> x.Customer).Select(x=> new CustomerOrderVm 
            {
                Date = x.Date,
                Location = x.Customer.Name,
                Name = x.Customer.Name,
                Number = x.Number
            }).ToList();
            
        }
        public int AddCustomer(Customer customer)
        {
            _context.Add(customer);
            _context.SaveChanges();
            return customer.Id;
        }


    }
}
