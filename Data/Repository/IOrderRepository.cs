using CustomerOrder.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerOrder.Data.Repository
{
    public interface IOrderRepository
    {
        void SendOrder(Order order);
        void Close(int id);
    }
}
