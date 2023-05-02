namespace CSGO_Animal_Kingdom
{
    public class Cat : Character
    {
        public List<Character> Cats;
        private int _timer = 5;
        public Cat()
        {
            Cats = new List<Character>
            {
                new Character("Cat1", "Terrorist"),
                new Character("Cat2", "Terrorist"),
                new Character("Cat3", "Terrorist"),
                new Character("Cat4", "Terrorist"),
                new Character("Cat5", "Terrorist"),
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
        public int StillAlive()
        {
            return Cats.Where(x => !x.IsDead).Count();
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
        public void Kill(Dog dog, bool success)
        {
            if (success && !CheckIfAllIsDead())
            {
                foreach (var p in dog.Dogs)
                {
                    if (!p.CheckIfDead())
                    {
                        p.Dead();
                        Console.WriteLine($"{p.Name} is dead. {dog.StillAlive()} left.");
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
