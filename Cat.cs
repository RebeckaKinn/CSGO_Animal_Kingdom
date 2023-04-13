namespace CSGO_Animal_Kingdom
{
    public class Cat
    {
        public List<Profile> Cats { get; set; }

        public Cat()
        {
            Cats = new List<Profile>
            {
                new Profile("Cat1"),
                new Profile("Cat2"),
                new Profile("Cat3"),
                new Profile("Cat4"),
            };
        }
    }
}
