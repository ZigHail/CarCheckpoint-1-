﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Runtime.Serialization;

namespace CarCheckpoint.Models.DTO
{
    [DataContract]
    public class AllUserData
    {
        [DataMember]
        public User User { get; set; }
        [DataMember]
        public RFIDCard Card { get; set; }
        [DataMember]
        public Payment Payment { get; set; }
        [DataMember]
        public Entrance Entrance { get; set; }

        public static User GetSelectedUser(string selectedGarage)
        {
            var db = new CarCheckerContext();
            var garage = Convert.ToInt32(selectedGarage);
            var user = db.Users
                        .Include(u => u.Payments)
                        .Include(u => u.Cards)
                        .Include(u => u.Entrances)
                        .FirstOrDefault(u => u.GarageNumber == garage);

            return user;
        }
    }
}