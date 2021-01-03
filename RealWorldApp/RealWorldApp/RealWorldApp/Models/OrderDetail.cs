using System;
using System.Collections.Generic;
using System.Text;

namespace RealWorldApp.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int Qty { get; set; }
        public double SubTotal { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
    }
}
