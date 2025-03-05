using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RandomQuotes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuotesController : ControllerBase
    {
        static readonly Random rnd = new();

        static readonly List<string> quotes = [];

        static QuotesController()
        {
            quotes.AddRange([
                "On considère que les neuf dixièmes du code correspondent à environ 90% du temps de développement. Les 10% restant correspondent également à 90% du temps de développement. (Tom Cargill)",
                "Il y existe deux manières de concevoir un logiciel. La première, c’est de le faire si simple qu’il est évident qu’il ne présente aucun problème. La seconde, c’est de le faire si compliqué qu’il ne présente aucun problème évident. La première méthode est de loin la plus complexe. (C.A.R. Hoare)",
                "Codez toujours comme si la personne qui allait maintenir votre code était un violent psychopathe qui sait où vous habitez. (John Woods)",
                "There will be two kinds of people in the world, those who tell computers what to do, and those who’re told by computers what to do. (Marc Andreesen)",
                "Programm or be programmed (Marc Andreesen)",
                "There are only two hard things in Computer Science: cache invalidation and naming things. (Phil Karlton)",
                "Vous ne pouvez pas comprendre la récursivité sans avoir d’abord compris la récursivité. (Anonyme)",
                "Si les ouvriers construisaient les bâtiments comme les développeurs écrivent leurs programmes, le premier pivert venu aurait détruit toute civilisation. (Gerald Weinberg)",
                "Avant de vouloir qu’un logiciel soit réutilisable, il faudrait d’abord qu’il ait été utilisable. (Ralph Johnson)",
                "Never trust user input ! (All Mankind)",
                "Marcher sur l'eau et développer un logiciel à partir d'une spécification sont faciles si les deux sont gelés. (Edward V. Berard)",
                "N'importe quel idiot peut écrire du code qu'un ordinateur peut comprendre. Les bons programmeurs écrivent du code que les humains peuvent comprendre. (Martin Fowler)",
                "What one programmer can do in one month, two programmers can do in two months. (Frederik Brooks)",
                "Managing senior programmers is like herding cats. (Dave Platt)"
            ]);
        }

        // GET: api/<QuotesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return quotes;
        }

        // GET api/<QuotesController>/random
        [HttpGet("random")]
        public string Random()
        {            
            return quotes[rnd.Next(quotes.Count)]; 
        }
    }
}
