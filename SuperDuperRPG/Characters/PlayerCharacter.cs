using System;

namespace SuperDuperRPG.Characters
{
    internal class PlayerCharacter
    {
        CharacterClasses charClass = new CharacterClasses();
        public string PlayerClass;
        public string input;
        public string sAge;
        public string playerName;
        public int iAge;
        public int playerHP = 100;
        public int playerStrenght;
        public int playerAgility;
        public int playerWisdom;
        public void CreateChar()
        {

            Console.WriteLine("Herzlich Willkommen bei der Charakter erstellung.\nDrücken Sie Enter um fortzufahren: ");
            Console.ReadLine();
            Console.WriteLine("Nennen Sie uns Ihren Namen: ");
            playerName = Console.ReadLine();
            Console.WriteLine("Wie alt sind Sie?: ");
            sAge = Console.ReadLine();
            //choose a class:
            Console.WriteLine("1 - Krieger \n2 - Magier \n3 - Dieb");
            Console.WriteLine("Choose a class: ");
            input = Console.ReadLine();
            if (input == "1")
            {
                charClass.Warrior();
            }
            if (input == "2")
            {
                charClass.Mage();
            }
            if (input == "3")
            {
                charClass.Thief();
            }

        }

        public void CharStats()
        {
            PlayerClass = charClass.playerClass;
            playerAgility = charClass.iAgility;
            playerStrenght = charClass.iStrenght;
            playerWisdom = charClass.iWisdom;

        }

        public void DisplayStat()
        {
            CharStats();
            Console.WriteLine(" Dein Name ist " + playerName + "\n Du bist: " + sAge + " Jahre alt");
            Console.WriteLine(" Klasse: " + PlayerClass + "\n Stärke: " + playerStrenght + "\n Agilität: " + playerAgility + "\n Weisheit: " + playerWisdom);
            Console.WriteLine("Drücken Sie enter um fortzufahren: ");
            Console.ReadLine();
        }

    }

    internal class CharacterClasses
    {
        public string playerClass;
        public int iStrenght;
        public int iWisdom;
        public int iAgility;

        public void Warrior()
        {
            playerClass = "Warrior";
            iStrenght = 3;
            iAgility = 2;
            iWisdom = 1;
        }
        public void Mage()
        {
            playerClass = "Mage";
            iStrenght = 1;
            iAgility = 2;
            iWisdom = 3;
        }
        public void Thief()
        {
            playerClass = "Dieb";
            iStrenght = 1;
            iAgility = 3;
            iWisdom = 2;
        }

    }
}
