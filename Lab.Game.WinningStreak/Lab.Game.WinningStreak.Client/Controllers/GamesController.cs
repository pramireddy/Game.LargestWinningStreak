using Lab.Game.WinningStreak.BLL;
using System;
using System.Net;
using System.Web.Http;

namespace Lab.Game.WinningStreak.Client.Controllers
{
    public class GamesController : ApiController
    {
        private const int WinningNumber = 6;
        private IWinningStreakProcessor _winningStreakProcessor;

        public GamesController(IWinningStreakProcessor winningStreakProcessor)
        {
            _winningStreakProcessor = winningStreakProcessor;
        }

        [HttpGet]
        [Route("api/games/largestwinningstreak/{throws:int}")]
        public IHttpActionResult Get(int throws)
        {
            try
            {
                if (throws < 2 || throws > 1000000)
                    return BadRequest("Number of times to throw the die is required.And min throws: 2 and max throws : 1 million");

                var largestWinningStreak =
                    _winningStreakProcessor.LargestWinningStreak(WinningNumber, throws);

                return Ok(largestWinningStreak);

            }
            catch (Exception)
            {
                //log exception by using either log4net or NLog
                return StatusCode(HttpStatusCode.InternalServerError);
            }
        }
    }
}
