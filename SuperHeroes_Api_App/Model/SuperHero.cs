namespace SuperHeroes_Api_App.Model
{
    public class Superhero
    {
        public int Id { get; set; }
        public string SuperheroName { get; set; }
        public string FullName { get; set; }
        public int GenderId { get; set; }
        public int EyeColourId { get; set; }
        public int HairColourId { get; set; }
        public int SkinColourId { get; set; }
        public int RaceId { get; set; }
        public int PublisherId { get; set; }
        public int AlignmentId { get; set; }
        public int HeightCm { get; set; }
        public int WeightKg { get; set; }

        public Gender Gender { get; set; }
        public Colour EyeColour { get; set; }
        public Colour HairColour { get; set; }
        public Colour SkinColour { get; set; }
        public Race Race { get; set; }
        public Publisher Publisher { get; set; }
        public Alignment Alignment { get; set; }
        public ICollection<HeroPower> HeroPowers { get; set; }
        public ICollection<HeroAttribute> HeroAttributes { get; set; }
    }

}
