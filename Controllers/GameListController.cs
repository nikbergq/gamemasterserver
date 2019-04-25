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
    public class GameListController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public List<Game> GetAllGames()
        {
            return GameRegistration.getInstance().getAllGame();
        }

        [HttpGet("GetAllGameRecords")]
        public JsonResult GetAllGameRecords()
        {
            return Json(GameRegistration.getInstance().getAllGame());
        }
    }
}
