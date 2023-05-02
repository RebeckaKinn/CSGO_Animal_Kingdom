namespace CSGO_Animal_Kingdom
{
    public class Cat : Character
    {
        public string Role { get; }
        public string Name { get; }
        public bool IsDead { get; set; }
        public List<Cat> Cats { get; set; }
        private int _timer = 5;

        public Cat(string name, string role)
        {
            Role = role;
            Name = name;
            IsDead = false;
        }
        public Cat()
        {
            Cats = new List<Cat>
            {
                new Cat("Cat1", "Terrorist"),
                new Cat("Cat2", "Terrorist"),
                new Cat("Cat3", "Terrorist"),
                new Cat("Cat4", "Terrorist"),
                new Cat("Cat5", "Terrorist"),
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
