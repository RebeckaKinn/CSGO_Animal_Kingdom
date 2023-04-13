namespace CSGO_Animal_Kingdom
{
    public class Dog
    {
        public List<Profile> Dogs { get; set; }

        public Dog()
        {
            Dogs = new List<Profile>
            {
                new Profile("Dog1"),
                new Profile("Dog2"),
                new Profile("Dog3"),
                new Profile("Dog4"),
            };
        }

        public void SeachDogList()
        {
            //foreach (Profile dog in Dogs)
            //{
            //    if(!dog.CheckIfDead())
            //}
        }

    }
}