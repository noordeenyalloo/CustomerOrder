using CustomerOrder.Core.Entity;
using CustomerOrder.Models;
using System.Collections.Generic;

namespace Invoice.Data.Repository
{
    public interface ICustomerRepository
    {
        int AddCustomer(Customer customer);
        List<CustomerOrderVm> All()
    }
}