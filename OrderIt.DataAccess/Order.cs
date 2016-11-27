using System;
using System.Collections.Generic;

namespace OrderIt.DataAccess
{
    public class Order : BaseEntity
    {
        public Guid CustomerId { get; set; }
        public List<Guid> ProductId { get; set; }
        public Customer Customer { get; set; }
        public List<Product> Products { get; set; }
    }
}
