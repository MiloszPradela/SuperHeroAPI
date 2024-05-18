namespace SuperHeroes_Api_App.Model
{
    public class Superpower
    {
        public int Id { get; set; }
        public string PowerName { get; set; }
        public ICollection<HeroPower> HeroPowers { get; set; }
    }
}
