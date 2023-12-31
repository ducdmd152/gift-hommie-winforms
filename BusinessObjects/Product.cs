﻿using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class Product
    {
        public Product()
        {
            Carts = new HashSet<Cart>();
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public int? CategoryId { get; set; }
        public string Avatar { get; set; }
        public bool Status { get; set; }
        public bool? IsDelete { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
