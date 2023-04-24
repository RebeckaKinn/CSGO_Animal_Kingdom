namespace CSGO_Animal_Kingdom
{
    public class Dog
    {
        public List<Profile> Dogs { get; set; }
        private int _defuseTimer = 5;
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
            if (cat.CheckIfAllIsDead()) DefuseBomb();
            if (success && !CheckIfAllIsDead())
            {
                foreach (Profile p in cat.Cats)
                {
                    if (!p.CheckIfDead())
                    {
                        p.Dead();
                        Console.WriteLine($"{p.Name} is dead. {cat.StillAlive()} left.");
                        break;
                    }
                }
            }
        }
        public int StillAlive()
        {
            return Dogs.Where(x => !x.IsDead).Count();
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
        public bool DefuseBomb()
        {
            _defuseTimer--;
            Console.WriteLine($"Defusing bomb...{_defuseTimer}...");
            if (_defuseTimer <= 0)
            {
                Console.WriteLine("\nDEFUSED\n");
                return true;
            }
            return false;
        }
        public int DefuseTime()
        {
            return _defuseTimer;
        }
    }
}
