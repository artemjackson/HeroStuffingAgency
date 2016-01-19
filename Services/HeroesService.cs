using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Entity;
using HeroesStaffingAgency.Models;

namespace HeroesStaffingAgency.HeroesServices
{
    public class HeroesService
    {
        private ApplicationDbContext context;
        public HeroesService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Hero>> GetAllAsync()
        {
            return await this.context.Heroes.ToListAsync();
        }

        public Hero GetById(int id)
        {
            return this.context.Heroes.SingleOrDefault(h => h.Id == id);
        }

        public async Task<Hero> GetByIdAsync(int id)
        {
            return await this.context.Heroes.SingleOrDefaultAsync(h => h.Id == id);
        }

        public int Create(Hero hero)
        {
            hero.Photo = "photos/unknown.jpg";
            var addedHero = this.context.Heroes.Add(hero);
            this.context.SaveChanges();
            return addedHero.Entity.Id;
        }

        public int Update(int id, Hero hero)
        {
            var existedHero = this.context.Heroes.SingleOrDefault(h => h.Id == id);

            existedHero.FirstName = String.IsNullOrEmpty(hero.FirstName) ? existedHero.FirstName : hero.FirstName;
            existedHero.LastName = String.IsNullOrEmpty(hero.LastName) ? existedHero.LastName : hero.LastName;
            existedHero.Pseudonym = String.IsNullOrEmpty(hero.Pseudonym) ? existedHero.Pseudonym : hero.Pseudonym;
            existedHero.Photo = String.IsNullOrEmpty(hero.Photo) ? existedHero.Photo : hero.Photo;

            this.context.SaveChanges();
            return existedHero.Id;
        }

        public int Delete(int id)
        {
            var hero = this.context.Heroes.SingleOrDefault(h => h.Id == id);
            this.context.Heroes.Remove(hero);
            this.context.SaveChanges();
            return hero.Id;
        }
    }
}