namespace CSGO_Animal_Kingdom
{
    public class Cat : ICharacter
    {
        public string Role { get; }
        public string Name { get; }
        public bool IsDead { get; set; }

        public Cat(string name, string role)
        {
            Role = role;
            Name = name;
            IsDead = false;
        }

        public void FindBombSite()
        {

        }

        public bool IsSuccessful(int numb)
        {
            return false;
        }

        public void PlantBomb()
        {

        }

        public void KillFreedomFighter(Dog dog)
        {
            dog.IsDead = true;
        }

        public string GetName()
        {
            return Name;
        }
        public bool CheckIfDead()
        {
            return IsDead;
        }
        public void Dead()
        {
            IsDead = true;
        }
    }
}
