namespace SuperHeroes_Api_App.Model
{
    public class Colour
    {
        public int Id { get; set; }
        public string ColourName { get; set; }
        // Zauważ, że używamy różnych kolekcji dla różnych cech kolorystycznych
        public ICollection<Superhero> EyeColours { get; set; }
        public ICollection<Superhero> HairColours { get; set; }
        public ICollection<Superhero> SkinColours { get; set; }
    }
}
