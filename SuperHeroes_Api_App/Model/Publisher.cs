namespace SuperHeroes_Api_App.Model
{
    public class Publisher
    {
        public int Id { get; set; }
        public string PublisherName { get; set; }
        public ICollection<Superhero> Superheroes { get; set; }
    }
}
