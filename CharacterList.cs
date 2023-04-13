namespace CSGO_Animal_Kingdom
{
    public class CharacterList
    {
        public List<Profile> Cats { get; set; }
        public List<Profile> Dogs { get; set; }

        public CharacterList()
        {
            Cats = new List<Profile>
            {
                new Profile("Cat1"),
                new Profile("Cat2"),
                new Profile("Cat3"),
                new Profile("Cat4"),
            };

            Dogs = new List<Profile>
            {
                new Profile("Dog1"),
                new Profile("Dog2"),
                new Profile("Dog3"),
                new Profile("Dog4"),
            };
        }

        public List<Profile> AliveList(List<Profile> ChosenList)
        {
            return ChosenList.Where(i => i.CheckIfDead()).ToList();
        }

        public Profile GetProfile(int index, List<Profile> ChosenList)
        {
            return ChosenList[index];
        }
    }
}
