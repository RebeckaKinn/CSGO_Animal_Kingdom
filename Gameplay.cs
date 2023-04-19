namespace CSGO_Animal_Kingdom
{
    public class Gameplay
    {
        public void Start(Cat cats, Dog dogs)
        {
            while (!cats.BombIsPlanted())
            {
                cats.FindBombSite();
                dogs.KillTerrorist(cats, IsSuccessful(10));
                cats.KillFreedomFighter(dogs, IsSuccessful(10));
                CheckGameOver(cats, dogs);
            }
            for (int countDown = 15; countDown >= 0; countDown--)
            {
                dogs.KillTerrorist(cats, IsSuccessful(3));
                cats.KillFreedomFighter(dogs, IsSuccessful(10));
                CheckGameOver(cats, dogs);
            }
        }
        public void CheckGameOver(Cat cats, Dog dogs)
        {
            if (BombCountdown() <= 0 || dogs.CheckIfAllIsDead()) cats.Win();
            if (dogs.DefuseBomb() || cats.CheckIfAllIsDead() && !cats.BombIsPlanted()) dogs.Win();
        }

        public int BombCountdown()
        {
            return 0;
        }

        public bool IsSuccessful(int numb)
        {
            Random chance = new Random();
            return chance.Next(0, numb) == 2;
        }
    }
}
