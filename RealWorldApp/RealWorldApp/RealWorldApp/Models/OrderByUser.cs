using System;
using System.Collections.Generic;
using System.Text;

namespace RealWorldApp.Models
{
    public class OrderByUser
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public double OrderTotal { get; set; }
        public DateTime OrderPlaced { get; set; }
    }
}
