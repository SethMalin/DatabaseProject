using GameLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace GameLibrary.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    
    public class GameController : ApiController
    {
        private GameRepositoryADO repository = new GameRepositoryADO();

        [Route("games/")]
        [AcceptVerbs("GET")]
        public IHttpActionResult GetAll()
        {
            return Ok(repository.GetAll());
        }

        [Route("game/{id}")]
        [AcceptVerbs("GET")]
        public IHttpActionResult GetByID(int id)
        {
            Game found = repository.GetByID(id);

            if (found == null)
            {
                return NotFound();
            }

            return Ok(found);
        }

        [Route("game/title/{title}")]
        [AcceptVerbs("GET")]
        public IHttpActionResult GetByTitle(string title)
        {
            List<Game> results = repository.GetByTitle(title);
            if (results.Count == 0)
            {
                return NotFound();
            }
            return Ok(results);
        }

        [Route("game/genre/{genre}")]
        [AcceptVerbs("GET")]
        public IHttpActionResult GetByGenre(string genre)
        {
            List<Game> results = repository.GetByGenre(genre);
            if (results.Count == 0)
            {
                return NotFound();
            }
            return Ok(results);
        }

        [Route("game/rating/{rating}")]
        [AcceptVerbs("GET")]
        public IHttpActionResult GetByRating(string rating)
        {
            List<Game> results = repository.GetByRating(rating);
            if (results.Count == 0)
            {
                return NotFound();
            }
            return Ok(results);
        }

        [Route("game/director/{director}")]
        [AcceptVerbs("GET")]
        public IHttpActionResult GetByDirector(string director)
        {
            List<Game> results = repository.GetByDirector(director);
            if (results.Count == 0)
            {
                return NotFound();
            }
            return Ok(results);
        }

        [Route("game/composer/{composer}")]
        [AcceptVerbs("GET")]
        public IHttpActionResult GetByComposer(string composer)
        {
            List<Game> results = repository.GetByComposer(composer);
            if (results.Count == 0)
            {
                return NotFound();
            }
            return Ok(results);
        }

        [Route("game/artist/{artist}")]
        [AcceptVerbs("GET")]
        public IHttpActionResult GetByArtist(string artist)
        {
            List<Game> results = repository.GetByArtist(artist);
            if (results.Count == 0)
            {
                return NotFound();
            }
            return Ok(results);
        }

        [Route("game/company/{company}")]
        [AcceptVerbs("GET")]
        public IHttpActionResult GetByCompany(string company)
        {
            List<Game> results = repository.GetByCompany(company);
            if (results.Count == 0)
            {
                return NotFound();
            }
            return Ok(results);
        }

        [Route("game/year/{year}")]
        [AcceptVerbs("GET")]
        public IHttpActionResult GetByYear(string year)
        {
            List<Game> results = repository.GetByYear(year);
            if (results.Count == 0)
            {
                return NotFound();
            }
            return Ok(results);
        }

        [Route("game/console/{console}")]
        [AcceptVerbs("GET")]
        public IHttpActionResult GetByConsole(string console)
        {
            List<Game> results = repository.GetByConsole(console);
            if (results.Count == 0)
            {
                return NotFound();
            }
            return Ok(results);
        }

        [Route ("game/")]
        [AcceptVerbs("POST")]
        public IHttpActionResult AddGame (Game game)
        {
            if (ModelState.IsValid == false)
            {
                return BadRequest(ModelState);
            }
            repository.CreateGame(game);

            return Created($"game/{game.GameID}", game);
        }
        [Route("game/{id}")]
        [AcceptVerbs("PUT")]
        public IHttpActionResult UpdateGame(int id, Game game)
        {
            if (ModelState.IsValid == false)
            {
                return BadRequest(ModelState);
            }

            repository.UpdateGame(game);
            return Ok();
        }
        [Route("game/{id}")]
        [AcceptVerbs("DELETE")]
        public void Delete(int id)
        {
            repository.DeleteGame(id);
        }
    }
}
