namespace CSGO_Animal_Kingdom
{
    public class Dog
    {
        public List<Profile> Dogs { get; set; }
        private int _defuseTimer = 5;
        public int CountDown = 15;
        public Dog()
        {
            Dogs = new List<Profile>
            {
                new Profile("Dog1", "Freedomfighter"),
                new Profile("Dog2", "Freedomfighter"),
                new Profile("Dog3", "Freedomfighter"),
                new Profile("Dog4", "Freedomfighter"),
                new Profile("Dog5", "Freedomfighter"),
            };
        }

        public void KillTerrorist(Cat cat, bool success)
        {
            if (success && !CheckIfAllIsDead())
            {
                foreach (Profile p in cat.Cats)
                {
                    if (!p.CheckIfDead())
                    {
                        p.Dead();
                        Console.WriteLine($"The dogs killed {p.Name}.");
                        break;
                    }
                }
            }
        }

        public bool CheckIfAllIsDead()
        {
            return Dogs.All(x => x.IsDead == true ? true : false);
        }
        public void Win()
        {
            Console.WriteLine("\nThe dogs win this round!\n");
            Console.ReadKey();
        }

        public void DefuseBomb(Cat cats)
        {
            _defuseTimer--;
            if (_defuseTimer <= 0)
            {
                Console.WriteLine("\nThe bomb exploded!\n");
                cats.Win();
            }
            Console.WriteLine($"Defusing bomb...{_defuseTimer}...");
        }
    }
}
