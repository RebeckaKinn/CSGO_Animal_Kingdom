namespace CSGO_Animal_Kingdom
{
    public class Dog
    {
        public List<Profile> Dogs { get; set; }

        public Dog()
        {
            var Dogs = new List<Profile>
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
            if (success && !CheckIfAllIsDead())
            {

                foreach (Profile p in cat.Cats)
                {
                    if (!p.CheckIfDead())
                    {
                        p.Dead();
                        break;
                    }

                }
            }
        }

        public bool CheckIfAllIsDead()
        {
            foreach (Profile p in Dogs)
            {
                if (p.IsDead) return true;
            }
            return false;
        }
        public void Win()
        {
            Console.WriteLine("The dogs win this round!");
        }

        public bool IsSuccessful(int numb)
        {
            return false;
        }

        public bool DefuseBomb()
        {
            //if (cat.All(i => i.IsDead))
            //{

            //}
            //else
            return false;

        }
    }
}
