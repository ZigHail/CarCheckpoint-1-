using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CarCheckpoint.Models
{
    [DataContract]
    public class User
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Surname { get; set; }
        [DataMember]
        public DateTime Birthday { get; set; }
        [DataMember]
        public string HomeAdress { get; set; }
        [DataMember]
        public int GarageNumber { get; set; }
        [DataMember]
        public string CarNumber { get; set; }
        [DataMember]
        public double Balance { get; set; }
        [DataMember]
        public bool InGarage { get; set; }
        [DataMember]
        public string Phone { get; set; }

        [DataMember]
        public ICollection<Payment> Payments { get; set; }
        [DataMember]
        public ICollection<RFIDCard> Cards { get; set; }
        [DataMember]
        public ICollection<Entrance> Entrances { get; set; }

        public User()
        {
            Payments = new List<Payment>();
            Cards = new List<RFIDCard>();
            Entrances = new List<Entrance>();
        }
    }
}