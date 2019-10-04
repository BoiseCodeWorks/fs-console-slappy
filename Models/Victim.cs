using System.Collections.Generic;

namespace Slappy.Models
{
    public class Victim
    {
        private Dictionary<string, int> _Attacks;

        public string Name { get; set; }
        public int Health { get; private set; }
        public bool Dead { get { return Health <= 0; } }

        public int Strike(string attackName)
        {
            _Attacks.TryGetValue(attackName, out int damage);
            Health -= damage;
            return damage;
        }

        public Victim(string name)
        {
            Name = name;
            Health = 100;
            _Attacks = new Dictionary<string, int>();
            _Attacks.Add("slap", 5);
            _Attacks.Add("punch", 10);
            _Attacks.Add("kick", 15);
            _Attacks.Add("haduoken", 50);
        }
    }
}