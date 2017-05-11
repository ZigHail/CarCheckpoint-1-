using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarCheckpoint.Models
{
    public class Pay
    {
        public int Id { get; set; }
        public double Sum { get; set; }
        public DateTime DateTime { get; set; }
    }
}