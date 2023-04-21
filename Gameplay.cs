namespace CSGO_Animal_Kingdom
{
    public class Gameplay
    {
        public void Start(Cat cats, Dog dogs)
        {

            while (!cats.PlantBomb())
            {
                BombCheck(cats.FindBombSite(IsSuccessful(10)), cats);
                dogs.KillTerrorist(cats, IsSuccessful(7));
                cats.KillFreedomFighter(dogs, IsSuccessful(7));
                CheckGameOver(cats, dogs);
            }
            for (int countDown = 15; countDown >= 0; countDown--)
            {
                dogs.CountDown--;
                dogs.KillTerrorist(cats, IsSuccessful(3));
                cats.KillFreedomFighter(dogs, IsSuccessful(7));
                dogs.DefuseBomb(cats);
                CheckGameOver(cats, dogs);
            }
        }

        public void BombCheck(bool success, Cat cats)
        {
            if (success) cats.PlantBomb();
        }
        public void CheckGameOver(Cat cats, Dog dogs)
        {
            if (dogs.CountDown == 0 || dogs.CheckIfAllIsDead() || dogs.CountDown > 0 && dogs.CheckIfAllIsDead())
            {
                cats.Win();
            }
            else if (cats.CheckIfAllIsDead() && !cats.FindBombSite(IsSuccessful(5)))
            {
                dogs.Win();
            }
            else return;
        }


        public bool IsSuccessful(int numb)
        {
            Random chance = new Random();
            return chance.Next(0, numb) == 2;
        }
    }
}
