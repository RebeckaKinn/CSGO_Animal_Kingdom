namespace CSGO_Animal_Kingdom
{
    public class Gameplay
    {
        public void Start(Cat cats, Dog dogs)
        {
            int rounds = 15;
            int timer = 5;
            while (!cats.PlantBomb(timer))
            {
                _ = cats.FindBombSite(IsSuccessful(5)) == true ? cats.PlantBomb(timer) : cats.FindBombSite(IsSuccessful(5));
                dogs.KillTerrorist(cats, IsSuccessful(7));
                cats.KillFreedomFighter(dogs, IsSuccessful(7));
                CheckGameOver(cats, dogs, rounds);
            }
            for (int countDown = 15; countDown >= 0; countDown--)
            {
                dogs.KillTerrorist(cats, IsSuccessful(3));
                cats.KillFreedomFighter(dogs, IsSuccessful(7));
                dogs.DefuseBomb(5);
                countDown = rounds;
                CheckGameOver(cats, dogs, countDown);
            }
        }
        public void CheckGameOver(Cat cats, Dog dogs, int rounds)
        {
            if (rounds == 0 || dogs.CheckIfAllIsDead()) cats.Win();
            if (dogs.DefuseBomb(5) && cats.CheckIfAllIsDead() || cats.CheckIfAllIsDead() && !cats.FindBombSite(IsSuccessful(5))) dogs.Win(cats);
        }


        public bool IsSuccessful(int numb)
        {
            Random chance = new Random();
            return chance.Next(0, numb) == 2;
        }
    }
}
