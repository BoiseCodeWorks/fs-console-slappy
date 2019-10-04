using System;
using Slappy.Controllers;

namespace Slappy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Killer!");
            new GameController().GetUserInput();
        }
    }
}
