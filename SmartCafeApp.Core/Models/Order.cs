using System;
using System.Collections.Generic;

namespace SmartCafeApp.Core.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<OrderItem> Items { get; set; }
        public decimal? TotalPrice { get; set; }
        public DateTime OrderTime { get; set; }


        public decimal GetCost(Order order)
        {
            decimal cost = 0;
            foreach (var item in Items)
            {
                foreach (var meal in item.Meals)
                {
                    cost = cost + meal.Price;
                }
            }
            order.TotalPrice = cost;
            return order.TotalPrice.Value;
        }
    }
}
