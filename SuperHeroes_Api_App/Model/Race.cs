namespace SuperHeroes_Api_App.Model
{
    public class Race
    {
        public int Id { get; set; }
        public string RaceName { get; set; }
        public ICollection<Superhero> Superheroes { get; set; }
    }
}
