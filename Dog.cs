namespace CSGO_Animal_Kingdom
{
    public class Dog : ICharacter
    {
        public string Role { get; }
        public string Name { get; }
        public bool IsDead { get; set; }

        public Dog(string name, string role)
        {
            Role = role;
            Name = name;
            IsDead = false;
        }

        public void KillTerrorist(Cat cat)
        {
            cat.IsDead = true;
        }

        public bool IsSuccessful(int numb)
        {
            return false;
        }

        public void DefuseBomb(List<Cat> cat)
        {
            if (cat.All(i => i.IsDead))
            {

            }
            else return;

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
