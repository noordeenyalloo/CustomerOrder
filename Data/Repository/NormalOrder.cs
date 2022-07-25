﻿using CustomerOrder.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerOrder.Data.Repository
{
    public class NormalOrder : OrderRepository
    {
        OrderDbContext _context;

        public NormalOrder(OrderDbContext context) : base(context)
        {
            _context = context;

        }

        public override void SendOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }
    }
}
