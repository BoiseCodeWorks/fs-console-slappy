using System;
using System.Collections.Generic;
using Slappy.Models;

namespace Slappy.Services
{
    public class GameService
    {
        private Victim Victim { get; set; }
        private List<string> Messages { get; set; } = new List<string>();

        public void Attack(string attackName)
        {
            if (Victim.Dead)
            {
                throw new Exception("Victim is already dead, please stop");
            }

            int damage = Victim.Strike(attackName);
            Messages.Add($"Player used {attackName} for {damage} damage");
        }

        public IEnumerable<string> GetMessageLog()
        {
            return Messages;
        }


        public GameService()
        {
            Victim = new Victim("Jimmy___Tester");
        }
    }
}