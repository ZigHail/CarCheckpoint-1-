using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CarCheckpoint.Models
{
    [DataContract]
    public class RFIDCard
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string CardId { get; set; }

        [DataMember]
        public int UserId { get; set; }
        [DataMember]
        public User User { get; set; }
    }
}