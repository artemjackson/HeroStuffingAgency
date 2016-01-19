using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace HeroesStaffingAgency.Controllers
{
    [Route("api/[controller]")]
    public class HeroesInfoController : Controller
    {
        private readonly string baseUri = "https://en.wikipedia.org/w/api.php?format=xml&action=query&prop=extracts&exintro=&titles=";
        // GET: api/currency/superman 
        [HttpGet("{heroName}")]
        public async Task<string> Get(string heroName)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(this.baseUri + heroName);
                client.DefaultRequestHeaders.Accept.Clear();

                var response = await client.GetAsync(this.baseUri + heroName);

                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}