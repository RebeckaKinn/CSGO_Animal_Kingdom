namespace CSGO_Animal_Kingdom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var gamePlay = new Gameplay();
            var Cats = new List<Cat>
            {
                new Cat("Cat1", "Terrorist"),
                new Cat("Cat2", "Terrorist"),
                new Cat("Cat3", "Terrorist"),
                new Cat("Cat4", "Terrorist"),
                new Cat("Cat5", "Terrorist"),
            };
            var Dogs = new List<Dog>
            {
                new Dog("Dog1", "Freedomfighter"),
                new Dog("Dog2", "Freedomfighter"),
                new Dog("Dog3", "Freedomfighter"),
                new Dog("Dog4", "Freedomfighter"),
                new Dog("Dog5", "Freedomfighter"),
            };
            gamePlay.Start(Cats, Dogs);
        }
    }
}