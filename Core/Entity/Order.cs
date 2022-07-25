using CustomerOrder.Core.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerOrder.Core.Entity
{
    public partial class Order : BaseModel 
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public decimal Descount { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

    }
}
