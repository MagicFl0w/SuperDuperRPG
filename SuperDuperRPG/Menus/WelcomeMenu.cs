using System;
using SuperDuperRPG.Characters;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace SuperDuperRPG.Menus
{
    internal class WelcomeMenu
    {

        PlayerCharacter playerCharacter = new PlayerCharacter();
        FightMenu fightMenu = new FightMenu();
        string menuInput;
        public void welcomeMenu()
        {
            do
            {
                Console.WriteLine("Willkommen. Das soll mal ein kleines text spiel werden. Drücke einer der Tasten um zu beginnen");
                Console.WriteLine("1 - Spiel starten \n0 - Spiel beenden.");
                menuInput = Console.ReadLine();
                if (menuInput == "1")
                {
                    playerCharacter.CreateChar();
                    break;
                    //gameMenu();
                    
                }
            } while (menuInput != "0");
        }
        //Arena Hub Menu
        public void gameMenu()
        {
            do
            {
                Console.WriteLine("Das hier soll das game menu sein bzw arena hub. von hier aus sollen die szenen angesteuert werden");
                Console.WriteLine("1 - Start Arena Fight \n2 - Display Stats");
                menuInput = Console.ReadLine(); 
                if (menuInput == "2")
                {
                    playerCharacter.DisplayStat();
                }
                if (menuInput == "1")
                {
                    fightMenu.FightScene0();
                }
            } while (menuInput != "0");


        }
        


    }
}
