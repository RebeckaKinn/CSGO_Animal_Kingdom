namespace CSGO_Animal_Kingdom
{
    public class Gameplay
    {
        public void Start(Cat cats, Dog dogs)
        {
            while (!cats.BombIsPlanted())
            {
                cats.FindBombSite();
                dogs.KillTerrorist(cats, 10);
                cats.KillFreedomFighter(dogs, 10);
            }
        }
        public bool GameOver()
        {
            if (BombCountdown() > 0) return false;
            return true;
        }

        public int BombCountdown()
        {
            return 0;
        }

        public static bool IsSuccessful(int numb)
        {
            return false;
        }
    }
}
