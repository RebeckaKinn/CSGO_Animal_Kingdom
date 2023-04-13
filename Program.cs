namespace CSGO_Animal_Kingdom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var gamePlay = new Gameplay();
            var list = new CharacterList();
            bool dogsTurn = false;
            gamePlay.Start(list, dogsTurn);
        }
    }
}