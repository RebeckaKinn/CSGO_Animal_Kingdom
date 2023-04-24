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
                dogs.KillTerrorist(cats, IsSuccessful(5));
                cats.KillFreedomFighter(dogs, IsSuccessful(7));
                CheckGameOver(cats, dogs);
            }
            for (int countDown = 15; countDown > 0; countDown--)
            {
                Console.WriteLine($"{countDown} time left to explotion!");
                dogs.KillTerrorist(cats, IsSuccessful(3));
                cats.KillFreedomFighter(dogs, IsSuccessful(7));
                CheckGameOver(cats, dogs, countDown);
            }
            cats.Win();
        }
        public void CheckGameOver(Cat cats, Dog dogs, int countDown = 10)
        {
            if (dogs.CheckIfAllIsDead()) cats.Win();
            if (cats.CheckIfAllIsDead() && dogs.DefuseTime() == 0) dogs.Win();
            if (cats.CheckIfAllIsDead() && countDown < 0) dogs.Win();
        }

        public bool IsSuccessful(int numb)
        {
            Random chance = new Random();
            return chance.Next(0, numb) == 2;
        }
    }
}
