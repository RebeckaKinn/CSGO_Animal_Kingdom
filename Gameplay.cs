namespace CSGO_Animal_Kingdom
{
    public class Gameplay
    {
        public void Start(Dog dogs, Cat cats)
        {

            while (!cats.BombIsPlanted())
            {
                cats.FindBombSite();
                dogs.KillTerrorist(cats);
                cats.KillFreedomFighter(dogs);
                dogs.KillTerrorist(cats);
            }
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


}
}
