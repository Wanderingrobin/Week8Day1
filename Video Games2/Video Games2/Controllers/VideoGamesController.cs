using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Video_Games2.Controllers
{
    public class VideoGamesController : ApiController
    {
        List<VideoGames> videogames = new List<VideoGames>
        {
            new VideoGames { ID = 1, Name = "Rise of the Tomb Raider", Genre = "Action Adventure", Price = 49.99M },
            new VideoGames { ID = 2, Name = "Watch Dogs 2", Genre = "Action Adventure", Price = 59.99M },
            new VideoGames { ID = 3, Name = "The Wolf Among Us", Genre = "Action Adventure", Price = 9.99M },
            new VideoGames { ID = 4, Name = "Assassin's Creed Syndicate", Genre = "Action Adventure", Price = 39.99M },
            new VideoGames { ID = 5, Name = "Mass Effect Andromeda", Genre = "Role-Playing", Price = 59.99M },
            new VideoGames { ID = 6, Name = "Gears of War 4", Genre = "Shooter", Price = 59.99M },
            new VideoGames { ID = 7, Name = "Mortal Kombat", Genre = "Fighter", Price = 39.99M },
        };

        public IEnumerable<VideoGames> GetAllVideoGames()
        {
            return videogames;
        }

        public IHttpActionResult GetVideoGames(int ID)
        {
            var videogame = videogames.SingleOrDefault(g => g.ID == ID);

            if (videogames == null)
                return NotFound();

            return Ok(videogames);
        }

        public IHttpActionResult GetVideoGamesByGenre(string gen)
        {
            var videogame = videogames.SingleOrDefault(g => g.Genre.ToLower() == gen.ToLower());

            if (videogames == null)
                return NotFound();

            return Ok(videogames);
        }

        public IHttpActionResult GetVideoGamesByName(string gen)
        {
            var videogame = videogames.SingleOrDefault(n => n.Name.ToLower() == gen.ToLower());

            if (videogames == null)
                return NotFound();

            return Ok(videogames);
        }
    }
}
