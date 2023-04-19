namespace CSGO_Animal_Kingdom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var gamePlay = new Gameplay();
            var Cats = new Cat();

            var Dogs = new Dog();

            gamePlay.Start(Cats, Dogs);
        }
    }
}