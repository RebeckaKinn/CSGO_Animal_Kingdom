namespace CSGO_Animal_Kingdom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var gamePlay = new Gameplay();
            var teams = new Teams();
            gamePlay.Start(teams.GetCatList(), teams.GetDogList(), teams);
        }
    }
}