using System;
using System.Collections.Generic;
using System.Text;

namespace SmartCafeApp.Core.Models
{
    public class Table
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
        public bool IsOccupied { get; set; }
        public Order? Order { get; set; }


    }
}
