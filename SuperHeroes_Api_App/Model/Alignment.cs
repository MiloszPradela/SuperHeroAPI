namespace SuperHeroes_Api_App.Model
{
    public class Alignment
    {
        public int Id { get; set; }
        public string AlignmentName { get; set; }
        public ICollection<Superhero> Superheroes { get; set; }
    }
}
