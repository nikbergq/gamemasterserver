using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text;

using GameRegistrationServer.Models;

namespace GameRegistrationServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameUpdateController : Controller
    {
        // GET: api/<controller>
        [HttpPut]
        public JsonResult UpdateGameRecord( Game stdn)
        {
            Console.WriteLine("In updateGameRecord");
            return Json(GameRegistration.getInstance().UpdateGame(stdn));
        }
    }
}
