using System;
using Slappy.Services;

namespace Slappy.Controllers
{
    public class GameController
    {
        private GameService _gs = new GameService();

        public void GetUserInput()
        {
            System.Console.WriteLine("Whats Next?");
            string input = Console.ReadLine();
            Console.Clear();
            try
            {
                _gs.Attack(input);

            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
                System.Console.WriteLine("would you like to quit now Y/n:");
                var choice = Console.ReadLine().ToLower();
                if (choice == "y")
                {
                    Environment.Exit(0);
                }
                System.Console.WriteLine("You really are a monster....");
            }
            var messages = _gs.GetMessageLog();
            foreach (var m in messages)
            {
                System.Console.WriteLine(m);
            }

            GetUserInput();
        }

    }
}