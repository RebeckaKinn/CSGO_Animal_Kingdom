namespace CSGO_Animal_Kingdom
{
    public class Cat
    {
        public List<Profile> Cats { get; set; }

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
                return true;
            }
            return false;
        }

        public bool CheckIfAllIsDead()
        {
            //foreach (Profile p in Cats)
            //{
            //    if (p.IsDead) return true;
            //}
            //return false;
            return Cats.All(x => x.IsDead == true ? true : false);
        }

        public bool PlantBomb(int timer)
        {
            timer--;
            if (timer < 0) return true;
            else return false;
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
            Console.WriteLine("The cats win this round!");
        }

    }
}
