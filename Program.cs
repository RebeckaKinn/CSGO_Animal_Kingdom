namespace CSGO_Animal_Kingdom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var gamePlay = new Gameplay();
            var cats = new Cat();
            var dogs = new Dog();
            gamePlay.Start(cats, dogs);
        }
    }
}