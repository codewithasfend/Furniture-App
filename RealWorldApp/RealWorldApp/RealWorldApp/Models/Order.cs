using System;
using System.Collections.Generic;
using System.Text;

namespace RealWorldApp.Models
{
    public class Order
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int OrderTotal { get; set; }
        public int UserId { get; set; }
    }
}
