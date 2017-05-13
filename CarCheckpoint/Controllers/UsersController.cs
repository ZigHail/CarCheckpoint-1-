using CarCheckpoint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using CarCheckpoint.BussinesLogic;
using CarCheckpoint.Models.DTO;

namespace CarCheckpoint.Controllers
{

    public class UsersController : ApiController
    {
        private CarCheckerContext db = new CarCheckerContext();

        public IEnumerable<User> GetAllUsers() => Users.GetAllUsers();

        public string[] GetAllGarages() => Users.GetGarageNumbers();

        public User GetUserById(int id) => Users.GetUser(id);

        public AllUserData GetUserByCardId(string id) => Users.GetUser(id);

        public User GetUserByGarage(string id) => AllUserData.GetSelectedUser(id);

        public IHttpActionResult AddUser([FromBody]AllUserData allData)
        {
            if (Users.Add(allData.User, allData.Card.CardId))
                return Ok();
            else
                return InternalServerError();
        }

        public IHttpActionResult AddCardToUser(AllUserData allData)
        {
            Users.AddCardToUser(allData.User, allData.Card.CardId);
            return Ok();
        }
    }
}
