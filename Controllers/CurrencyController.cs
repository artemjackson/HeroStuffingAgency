using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace HeroesStaffingAgency.Controllers
{
    [Route("api/[controller]")]
    public class CurrencyController : Controller
    {
        private readonly string baseUri = "https://currency-api.appspot.com/api/usd/rub.json";
        // GET: api/currency
        [HttpGet]
        public async Task<string> Get()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(this.baseUri);
                client.DefaultRequestHeaders.Accept.Clear();

                var response = await client.GetAsync(this.baseUri);

                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}