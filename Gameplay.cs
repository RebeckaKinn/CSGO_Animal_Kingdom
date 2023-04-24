namespace CSGO_Animal_Kingdom
{
    public class Gameplay
    {
        public void Start(Cat cats, Dog dogs)
        {

            while (!cats.FindBombSite(IsSuccessful(10)))
            {
                dogs.KillTerrorist(cats, IsSuccessful(7));
                cats.KillFreedomFighter(dogs, IsSuccessful(7));
                CheckGameOver(cats, dogs);
            }
            while (!cats.PlantBomb())
            {
                dogs.KillTerrorist(cats, IsSuccessful(7));
                cats.KillFreedomFighter(dogs, IsSuccessful(7));
                CheckGameOver(cats, dogs);
            }
            for (int countDown = 15; countDown > 0; countDown--)
            {
                dogs.CountDown--;
                Console.WriteLine($"{dogs.CountDown} time left to explotion!");
                dogs.KillTerrorist(cats, IsSuccessful(3));
                cats.KillFreedomFighter(dogs, IsSuccessful(7));
                dogs.DefuseBomb(IsSuccessful(7));
                CheckGameOver(cats, dogs);
            }
            cats.Win();
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
