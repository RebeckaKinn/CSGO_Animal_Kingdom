namespace CSGO_Animal_Kingdom
{
    public class Character
    {
        public string Role { get; }
        public string Name { get; }
        public bool IsDead { get; set; }
        public Character(string name, string role)
        {
            Role = role;
            Name = name;
            IsDead = false;
        }

        public Character() { }
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
