namespace CSGO_Animal_Kingdom
{
    public class Dog
    {
        public List<Profile> Dogs { get; set; }

        public Dog()
        {
            Dogs = new List<Profile>
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
                        Console.WriteLine($"The dogs killed {p.Name}.");
                        break;
                    }

                }
            }
        }

        public bool CheckIfAllIsDead()
        {
            //foreach (Profile p in Dogs)
            //{
            //    if (p.IsDead)
            //    {
            //        return true;
            //    }
            //    return false;
            //}
            return Dogs.All(x => x.IsDead == true ? true : false);
        }
        public void Win()
        {
            Console.WriteLine("The dogs win this round!");
        }

        public bool DefuseBomb(int timer)
        {
            timer--;
            if (timer <= 0) return true;
            return false;
        }
    }
}
