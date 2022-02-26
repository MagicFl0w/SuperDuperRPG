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
                Console.WriteLine("Greetings Stranger. This is supposed to be a little Text Adventure Game at some point. Press [ENTER] to continue");
                Console.WriteLine("1 - Start the game \n0 - Quit the Game.");
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
                Console.WriteLine("Early version of the arena hub. from here the player choose the different scenes");
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
