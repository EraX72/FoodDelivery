using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Last.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string DeliveryAddress { get; set; }
        public string ContactNumber { get; set; }
        public List<string> OrderItems { get; set; }
        public string SpecialInstructions { get; set; }
        public string PaymentStatus { get; set; }

    }
}
    