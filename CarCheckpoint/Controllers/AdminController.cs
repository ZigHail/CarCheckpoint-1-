using CarCheckpoint.BussinesLogic;
using CarCheckpoint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CarCheckpoint.Controllers
{
    public class AdminController : ApiController
    {
        public List<AdminSettings> GetSettings() => Admin.GetSettings();

        public List<WriteOff> GetWriteOffs() => Users.GetAllWriteOff();

        public IHttpActionResult ChangeSettings(List<AdminSettings> settings)
        {
            if (Admin.ChangeSettings(settings))
                return Ok();
            else
                return InternalServerError();
        }
        
        [HttpPost]        
        public IHttpActionResult WriteOff([FromBody]int price)
        {
            BussinesLogic.Payment.WriteOff(price);
            return Ok();
        }

        public IHttpActionResult Pay(Models.Payment payment)
        {
            BussinesLogic.Payment.Pay(payment.PayUser, payment.Sum);
            return Ok();
        }
    }
}