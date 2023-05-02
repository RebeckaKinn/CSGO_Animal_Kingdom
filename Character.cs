namespace CSGO_Animal_Kingdom
{
    public class Character
    {
        public string Role { get; }
        public string Name { get; }
        public bool IsDead { get; set; }

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
