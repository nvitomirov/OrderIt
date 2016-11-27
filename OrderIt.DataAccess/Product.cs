﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderIt.DataAccess
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string SerialNumber { get; set; }

        public string Description { get; set; }

        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
    }
}
