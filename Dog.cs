namespace CSGO_Animal_Kingdom
{
    public class Dog : Character
    {
        public string Role { get; }
        public string Name { get; }
        public bool IsDead { get; set; }
        public List<Dog> Dogs { get; set; }
        private int _defuseTimer = 5;
        public Dog(string name, string role)
        {
            Role = role;
            Name = name;
            IsDead = false;
        }
        public Dog()
        {
            Dogs = new List<Dog>
            {
                new Dog("Dog1", "Freedomfighter"),
                new Dog("Dog2", "Freedomfighter"),
                new Dog("Dog3", "Freedomfighter"),
                new Dog("Dog4", "Freedomfighter"),
                new Dog("Dog5", "Freedomfighter"),
            };
        }

        public void Kill(Cat cat, bool success)
        {
            if (cat.CheckIfAllIsDead()) DefuseBomb();
            if (success && !CheckIfAllIsDead())
            {
                foreach (var p in cat.Cats)
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
