using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNet.Http;
using Microsoft.Net.Http.Headers;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Mvc;
using HeroesStaffingAgency.HeroesServices;
using HeroesStaffingAgency.Models;


namespace HeroesStaffingAgency.Controllers
{
    [Route("api/[controller]")]
    public class HeroesController : Controller
    {
        private HeroesService service;
        private IHostingEnvironment env;

        public HeroesController(IHostingEnvironment env, HeroesService service)
        {
            this.service = service;
            this.env = env;
        }

        // GET: api/heroes
        [HttpGet]
        public async Task<IEnumerable<Hero>> Get()
        {
            return await this.service.GetAllAsync();
        }

        // GET api/heroes/5
        [HttpGet("{id}")]
        public async Task<Hero> Get(int id)
        {
            return await this.service.GetByIdAsync(id);
        }

        // POST api/heroes
        [HttpPost]
        public int Post([FromBody] Hero hero)
        {
            return this.service.Create(hero);
        }

        // PUT api/heroes/5
        [HttpPut("{id}")]
        public int Put(int id, [FromBody] Hero hero)
        {
            return this.service.Update(id, hero);
        }

        // POST api/heroes/5/photo
        [HttpPost("{id}/photo")]
        public void Post(int id, IFormFile file)
        {
            if (file.Length > 0)
            {
                var uploads = "photos";
                var uploadsAbsPath = Path.Combine(env.WebRootPath, uploads);

                var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                var relFileName = Path.Combine(uploads, fileName);

                var hero = new Hero
                {
                    Photo = relFileName
                };
                this.service.Update(id, hero);

                file.SaveAs(Path.Combine(uploadsAbsPath, fileName));
            }
        }

        // DELETE api/heroes/5
        [HttpDelete("{id}")]
        public int Delete(int id)
        {
            return this.service.Delete(id);
        }
    }
}
