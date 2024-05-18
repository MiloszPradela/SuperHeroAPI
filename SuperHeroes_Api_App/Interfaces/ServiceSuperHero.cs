using SuperHeroes_Api_App.Data;
using SuperHeroes_Api_App.Model;

namespace SuperHeroes_Api_App.Interfaces
{
    public class ServiceSuperHero : ISuperHeroInterface
    {
        private readonly DataContext _context;

        public Superhero FindHeroByID(int id)
        {
            return _context.Superheroes.FirstOrDefault(h => h.Id == id);

        }
        public ServiceSuperHero(DataContext context)
        {
            _context = context;
        }
    }
}
