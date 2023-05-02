namespace CSGO_Animal_Kingdom
{
    public class Dog : Character
    {
        public List<Character> Dogs;
        private int _defuseTimer = 5;
        public Dog()
        {
            Dogs = new List<Character>
            {
                new Character("Dog1", "Freedomfighter"),
                new Character("Dog2", "Freedomfighter"),
                new Character("Dog3", "Freedomfighter"),
                new Character("Dog4", "Freedomfighter"),
                new Character("Dog5", "Freedomfighter"),
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
