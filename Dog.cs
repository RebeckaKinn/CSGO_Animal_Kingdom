namespace CSGO_Animal_Kingdom
{
    public class Dog
    {
        public List<Profile> Dogs { get; set; }

        public Dog()
        {
            var Dogs = new List<Profile>
            {
                new Profile("Dog1", "Freedomfighter"),
                new Profile("Dog2", "Freedomfighter"),
                new Profile("Dog3", "Freedomfighter"),
                new Profile("Dog4", "Freedomfighter"),
                new Profile("Dog5", "Freedomfighter"),
            };
        }

        public void KillTerrorist(Cat cat, int chanceCount)
        {
            int num = new Random().Next(0, chanceCount);
            foreach (Profile p in cat.Cats)
            {
                if (cat.Cats.IndexOf(p) == num) p.Dead();
            }
        }

        public bool IsSuccessful(int numb)
        {
            return false;
        }

        public void DefuseBomb(List<Cat> cat)
        {
            if (cat.All(i => i.IsDead))
            {

            }
            else return;

        }
    }
}
