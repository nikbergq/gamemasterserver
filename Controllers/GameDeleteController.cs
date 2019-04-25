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
    public class GameDeleteController : Controller
    {
        [Route("game/remove/{regdNum}")]
        // DELETE: api/<controller>
        [HttpDelete]
        public IActionResult DeleteGameRecord(String regdNum)
        {
            Console.WriteLine("In deleteGameRecord");
            return Ok(GameRegistration.getInstance().Remove(regdNum));
        }
    }
}
