namespace SuperHeroes_Api_App.Model
{
    public class HeroAttribute
    {
        public int HeroId { get; set; }
        public int AttributeId { get; set; }
        public int AttributeValue { get; set; }
        public Superhero Superhero { get; set; }
        public Attributee Attribute { get; set; }
    }
}
