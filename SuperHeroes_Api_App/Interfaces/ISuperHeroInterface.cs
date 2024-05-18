using SuperHeroes_Api_App.Model;

namespace SuperHeroes_Api_App.Interfaces
{
    public interface ISuperHeroInterface
    {
        public Superhero FindHeroByID(int id); 
    }
}
