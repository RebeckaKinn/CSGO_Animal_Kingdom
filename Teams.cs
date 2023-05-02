namespace CSGO_Animal_Kingdom
{
    public class Teams : Character
    {
        public List<Character> Dogs;
        public List<Character> Cats;
        private int _timer = 5;
        private int _defuseTimer = 5;


        public List<Character> GetCatList()
        {
            Cats = new List<Character>
            {
                new Character("Cat1", "Terrorist"),
                new Character("Cat2", "Terrorist"),
                new Character("Cat3", "Terrorist"),
                new Character("Cat4", "Terrorist"),
                new Character("Cat5", "Terrorist"),
            };
            return Cats;
        }
        public List<Character> GetDogList()
        {
            Dogs = new List<Character>
            {
                new Character("Dog1", "Freedomfighter"),
                new Character("Dog2", "Freedomfighter"),
                new Character("Dog3", "Freedomfighter"),
                new Character("Dog4", "Freedomfighter"),
                new Character("Dog5", "Freedomfighter"),
            };
            return Dogs;
        }
        public void Kill(List<Character> list, bool success)
        {
            if (!success || CheckIfAllIsDead(list)) return;
            var theProfile = GetSecondList(list).FirstOrDefault(p => !p.CheckIfDead());
            if (theProfile == null) return;
            theProfile.Dead();
            Console.WriteLine($"{theProfile.Name} is dead. {StillAlive(GetSecondList(list))} left.");
        }

        public List<Character> GetSecondList(List<Character> list)
        {
            return list == Dogs ? Cats : Dogs;
        }
        public int StillAlive(List<Character> list)
        {
            return list.Where(x => !x.IsDead).Count();
        }
        public bool CheckIfAllIsDead(List<Character> list)
        {
            return list.All(x => x.IsDead == true ? true : false);
        }
        public void Win(List<Character> list)
        {
            string winningTeam = "dogs";
            if (list == Cats) winningTeam = "cats";
            Console.WriteLine($"\nThe {winningTeam} win this round!\n");
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


        public bool FindBombSite(bool success)
        {
            if (success)
            {
                Console.WriteLine("\nBomb site is found!\n");
                return true;
            }
            return false;
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
    }
}
