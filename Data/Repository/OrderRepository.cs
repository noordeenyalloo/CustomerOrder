using CustomerOrder.Core.Entity;
using CustomerOrder.Data.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerOrder.Data.Repository
{
    public class OrderRepository : BaseRepository<Customer>, IOrderRepository
    {
        OrderDbContext _context;

        public OrderRepository(OrderDbContext context) : base(context)
        {
            _context = context;
        }

        public virtual void SendOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }
        public virtual void Close(int id)
        {
            throw new NotImplementedException();
        }

    }
}
