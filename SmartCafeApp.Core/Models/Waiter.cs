using SmartCafeApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartCafeApp.Core.Models
{
    public class Waiter : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public decimal SalaryPH { get; set; }

        public bool IsValid()
        {
            return !string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Phone) && (SalaryPH > 0);
        }
    }
}
