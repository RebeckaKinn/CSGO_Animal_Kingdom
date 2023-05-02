namespace CSGO_Animal_Kingdom
{
    public class Gameplay
    {
        public void Start(List<Character> cats, List<Character> dogs, Teams teams)
        {
            while (!teams.FindBombSite(IsSuccessful(10)))
            {
                teams.Kill(cats, IsSuccessful(7));
                teams.Kill(dogs, IsSuccessful(7));
                CheckGameOver(cats, dogs, teams);
            }
            while (!teams.PlantBomb())
            {
                teams.Kill(cats, IsSuccessful(5));
                teams.Kill(dogs, IsSuccessful(7));
                CheckGameOver(cats, dogs, teams);
            }
            for (int countDown = 15; countDown > 0; countDown--)
            {
                Console.WriteLine($"{countDown} time left to explotion!");
                teams.Kill(cats, IsSuccessful(3));
                teams.Kill(dogs, IsSuccessful(7));
                CheckGameOver(cats, dogs, teams, countDown);
            }
            teams.Win(cats);
        }
        public void CheckGameOver(List<Character> cats, List<Character> dogs, Teams teams, int countDown = 10)
        {
            if (teams.CheckIfAllIsDead(dogs)) teams.Win(cats);
            if (teams.CheckIfAllIsDead(cats) && teams.DefuseTime() == 0) teams.Win(dogs);
            if (teams.CheckIfAllIsDead(cats) && countDown < 0) teams.Win(dogs);
        }

        public bool IsSuccessful(int numb)
        {
            Random chance = new Random();
            return chance.Next(0, numb) == 2;
        }
    }
}
