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

        public void KillFreedomFighter(Dog dog, int chanceCount)
        {
            int num = new Random().Next(0, chanceCount);
            foreach (Profile p in dog.Dogs)
            {
                if (dog.Dogs.IndexOf(p) == num) p.Dead();
            }
        }


    }
}
