using CarCheckpoint.Models;
using CarCheckpoint.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Http;

namespace CarCheckpoint.BussinesLogic
{
    public class Users
    {
        public static IEnumerable<User> GetAllUsers() => new CarCheckerContext().Users;

        public static User GetUser(int id) => new CarCheckerContext().Users.Find(id);  
        public static AllUserData GetUser(string card) =>
            new AllUserData
            {
                User = GetUserByCard(card),
                //Card = db.Cards.FirstOrDefault(c => c.CardId == card)
            };   

        private static User GetUserByCard(string card) =>         
                new CarCheckerContext().Cards
                    .Include(c => c.User)
                    .ToList()
                    .FirstOrDefault(u => u.CardId == card)
                    .User;        

        public static string[] GetGarageNumbers()
        {
            var db = new CarCheckerContext();
            var garages = db.Users.Select(u => u.GarageNumber).OrderBy(k => k).ToArray();
            var garagesInString = new List<string>();
            foreach (var garage in garages)            
                garagesInString.Add(garage.ToString());
            
            return garagesInString.ToArray();
        }

        public static List<WriteOff> GetAllWriteOff() => new CarCheckerContext().WriteOff.ToList();

        public static bool Add(User user, string cardNumber)
        {
            var succsess = false;
            var db = new CarCheckerContext();

            db.Users.Add(user);
            db.SaveChanges();

            AddCardToUser(user, cardNumber);
            succsess = true;
            return succsess;
        }
        public static void AddCardToUser(User user, string cardNumber)
        {
            var db = new CarCheckerContext();
            db.Cards.Add(new RFIDCard
            {
                CardId = cardNumber,
                UserId = user.Id
            });
            db.SaveChanges();
        }
    }
}