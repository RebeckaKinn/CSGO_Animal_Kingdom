namespace CSGO_Animal_Kingdom
{
    public class Cat
    {
        public List<Profile> Cats { get; set; }
        private int _timer = 5;
        public Cat()
        {
            Cats = new List<Profile>
            {
                new Profile("Cat1", "Terrorist"),
                new Profile("Cat2", "Terrorist"),
                new Profile("Cat3", "Terrorist"),
                new Profile("Cat4", "Terrorist"),
                new Profile("Cat5", "Terrorist"),
            };
        }

        public bool FindBombSite(bool success)
        {
            if (success)
            {
                Console.WriteLine("\nBomb site is found!\n");
                return true;
            }
            return false;
        }

        public bool CheckIfAllIsDead()
        {
            return Cats.All(x => x.IsDead == true ? true : false);
        }

        public bool PlantBomb()
        {
            _timer--;
            if (_timer < 0)
            {
                Console.WriteLine("\nThe bomb is planted!\n");
                return true;
            }
            Console.WriteLine($"Planting bomb...{_timer}...");
            return false;
        }

        public void KillFreedomFighter(Dog dog, bool success)
        {
            if (success)
            {
                foreach (Profile p in dog.Dogs)
                {
                    if (!p.CheckIfDead())
                    {
                        p.Dead();
                        Console.WriteLine($"{p.Name} is dead.");
                        break;
                    }
                }
            }
        }
        public void Win()
        {
            Console.WriteLine("\nThe cats win this round!\n");
            Console.ReadKey();
        }

    }
}
