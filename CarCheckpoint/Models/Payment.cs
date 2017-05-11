using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarCheckpoint.Models
{
    public class Payment : Pay
    {
        public int PayUserId { get; set; }
        public User PayUser { get; set; }
    }
}