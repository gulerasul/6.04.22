using Stripe;
using System;
using System.Collections.Generic;

namespace Json.Models
{
    class Order 
    {
        
        public int Id { get; set; }
        public List<OrderItem> OrderItems { get; set; }

       
    }
}

