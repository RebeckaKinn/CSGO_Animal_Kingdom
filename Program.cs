namespace CSGO_Animal_Kingdom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var gamePlay = new Gameplay();
            var cat = new Cat();
            var dog = new Dog();
            gamePlay.Start(cat, dog);
        }
    }
}