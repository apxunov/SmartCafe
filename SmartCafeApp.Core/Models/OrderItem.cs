using System;
using System.Collections.Generic;
using System.Text;

namespace SmartCafeApp.Core.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public List<Meal> Meals { get; set; }
        public Table Table { get; set; }
        public Waiter Waiter { get; set; }
        public DateTime OrderItemTime { get; set; }


    }
    }
}
