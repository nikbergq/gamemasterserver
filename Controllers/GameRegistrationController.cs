using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using GameRegistrationServer.Models;

namespace GameRegistrationServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameRegistrationController : Controller
    {
        // POST: api/<controller>
        [HttpPost]
        public GameRegistrationReply RegisterGame(Game gameregd)
        {
            Console.WriteLine("In registerGame");
            GameRegistrationReply stdregreply = new GameRegistrationReply();
            GameRegistration.getInstance().Add(gameregd);
            stdregreply.Name = gameregd.Name;
            stdregreply.Ip = gameregd.Ip;
            stdregreply.RegistrationNumber = gameregd.RegistrationNumber;
            stdregreply.RegistrationStatus = "Successful";

            return stdregreply;
        }

        [HttpPost("InsertGame")]
        public IActionResult InsertGame(Game gameregd)
        {
            Console.WriteLine("In registerGame");
            GameRegistrationReply stdregreply = new GameRegistrationReply();
            GameRegistration.getInstance().Add(gameregd);
            stdregreply.Name = gameregd.Name;
            stdregreply.Ip = gameregd.Ip;
            stdregreply.RegistrationNumber = gameregd.RegistrationNumber;
            stdregreply.RegistrationStatus = "Successful";

            return Ok(stdregreply);
        }

        [Route("game/")]
        [HttpPost("AddGame")]
        public JsonResult AddGame(Game gameregd)
        {
            Console.WriteLine("In registerGame");
            GameRegistrationReply stdregreply = new GameRegistrationReply();
            GameRegistration.getInstance().Add(gameregd);
            stdregreply.Name = gameregd.Name;
            stdregreply.Ip = gameregd.Ip;
            stdregreply.RegistrationNumber = gameregd.RegistrationNumber;
            stdregreply.RegistrationStatus = "Successful";

            return Json(stdregreply);
        }

    }
}
