using CarCheckpoint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarCheckpoint.BussinesLogic
{
    public class Payment
    {
        public static void Pay(User user, double price)
        {
            var db = new CarCheckerContext();
            db.Payments.Add(new Models.Payment
            {
                PayUserId = user.Id,
                Sum = price,
                DateTime = DateTime.Now
            });
            db.SaveChanges();
            db.Users.FirstOrDefault(u => u.Id == user.Id).Balance += price;
            db.SaveChanges();
        }

        public static void WriteOff(double price)
        {
            var db = new CarCheckerContext();
            foreach (var user in db.Users)
                user.Balance -= price;
            db.SaveChanges();
            db.WriteOff.Add(
                new WriteOff
                {
                    Sum = price,
                    DateTime = DateTime.Now
                });
            db.SaveChanges();
        }
    }
}