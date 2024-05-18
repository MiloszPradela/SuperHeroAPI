namespace SuperHeroes_Api_App.Model
{
    public class HeroPower
    {
        public int HeroId { get; set; }
        public int PowerId { get; set; }
        public Superhero Superhero { get; set; }
        public Superpower Superpower { get; set; }
    }
}
