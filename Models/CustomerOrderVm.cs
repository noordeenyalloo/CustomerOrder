using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerOrder.Models
{
    public class CustomerOrderVm
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public decimal Descount { get; set; }
        public int OrderType { get; set; }
    }
}
