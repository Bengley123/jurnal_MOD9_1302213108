using Microsoft.AspNetCore.Mvc;

namespace jurnal_MOD9_1302213108.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        public static List<Movie> ListMovie = new List<Movie>
        {
            new Movie ("The Shawshank Redemption", "Frank Darabont", 
                new List<string>{"Tim Robbins", "Morgan Freeman", "Bob Gunton"}
            ,  "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, " +
               "redemption through basic compassion."),
            new Movie ("The Godfather", "Francis Ford Coppola", 
                new List<string>{"Marion Brando", "Al Pacino", "James Caan"}
            ,  "The aging patriarch of an organized crime dynasty in postwar New York City transfers control " +
               "of his clandestine empire to his reluctant youngest son.."),
            new Movie ("The Dark Knight", "Christopher Nolan", 
                new List<string>{ "Christian Bale", "Heath Ledger", "Aaron Eckhart" }
            ,  "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, " +
               "Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.")

        };

        [HttpGet]
        public IEnumerable<MovieController> Get()
        {
            return ListMovie;
        }

        [HttpGet("{id}")]
        public MovieController Get(int id)
        {
            return ListMovie[id];
        }


        [HttpPost]
        public void Post(MovieController M)
        {
            ListMovie.Add(M);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ListMovie.RemoveAt(id);
        }
    }

}

