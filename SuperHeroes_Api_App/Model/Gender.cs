namespace SuperHeroes_Api_App.Model
{
    public class Gender
    {
        public int Id { get; set; }
        public string GenderName { get; set; }
        public ICollection<Superhero> Superheroes { get; set; }
    }
}
