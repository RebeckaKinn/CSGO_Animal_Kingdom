namespace CSGO_Animal_Kingdom
{
    public class Cat
    {
        public List<Profile> Cats { get; set; }

        public Cat()
        {
            var Cats = new List<Profile>
            {
                new Profile("Cat1", "Terrorist"),
                new Profile("Cat2", "Terrorist"),
                new Profile("Cat3", "Terrorist"),
                new Profile("Cat4", "Terrorist"),
                new Profile("Cat5", "Terrorist"),
            };
        }

        public void FindBombSite()
        {

        }

        public bool CheckIfAllIsDead()
        {
            foreach (Profile p in Cats)
            {
                if (p.IsDead) return true;
            }
            return false;
        }

        public bool IsSuccessful(int numb)
        {
            return false;
        }

        public void PlantBomb()
        {
            BombIsPlanted();
        }

        public bool BombIsPlanted()
        {
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
