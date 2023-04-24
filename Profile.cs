namespace CSGO_Animal_Kingdom
{
    public class Profile : ICharacter
    {
        public string Role { get; }
        public string Name { get; }
        public bool IsDead { get; set; }
        public Profile(string name, string role)
        {
            Role = role;
            Name = name;
            IsDead = false;
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
