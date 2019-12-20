using SmartCafeApp.Core.Interfaces;
using System;
using System.Collections.Generic;

namespace SmartCafeApp.Core.Models
{
    public class Order : IEntity
    {
        public int Id { get; set; }
        public List<OrderItem> Orders { get; set; }
        public decimal? TotalPrice { get; set; }
        
        public bool IsValid()
        {
            return (Id > 0);
        }
    }
}
