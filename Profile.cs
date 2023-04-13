namespace CSGO_Animal_Kingdom
{
    public class Profile
    {
        private string _name { get; }
        private bool _isDead { get; set; }

        public Profile(string name)
        {
            name = _name;
            _isDead = false;
        }

        public string GetName()
        {
            return _name;
        }
        public bool CheckIfDead()
        {
            return _isDead;
        }
        public void Dead()
        {
            _isDead = true;
        }
    }
}
