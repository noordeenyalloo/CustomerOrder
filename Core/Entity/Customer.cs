using CustomerOrder.Core.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerOrder.Core.Entity
{
    public partial class Customer : BaseModel
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public ICollection<Order> Order { get; set; }
    }
}
