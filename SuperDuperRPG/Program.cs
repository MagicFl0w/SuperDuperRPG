using System;
using SuperDuperRPG.Characters;
using SuperDuperRPG.Menus;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperDuperRPG
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            WelcomeMenu menus = new WelcomeMenu();
            menus.welcomeMenu();
            menus.gameMenu();
            

        }
    }
}
