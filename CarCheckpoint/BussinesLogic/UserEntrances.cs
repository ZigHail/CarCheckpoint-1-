using CarCheckpoint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarCheckpoint.BussinesLogic
{
    public class UserEntrances
    {
        public static void Add(string card)
        {
            using (var db = new CarCheckerContext())
            {                
                db.Entrances.Add(new Entrance
                {
                    EntranceDate = DateTime.Now.Date,
                    UserId = Users.GetUser(card).User.Id
                });
                db.SaveChanges();
            }
        }
    }
}