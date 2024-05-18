namespace SuperHeroes_Api_App.Model
{
    public class Attributee
    {
        public int Id { get; set; }
        public string AttributeName { get; set; }
        public ICollection<HeroAttribute> HeroAttributes { get; set; }
    }
}
