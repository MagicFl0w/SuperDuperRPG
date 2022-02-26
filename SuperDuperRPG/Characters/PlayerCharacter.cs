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

            Console.WriteLine("Welcome to the creation part.\nPress [ENTER] to continue: ");
            Console.ReadLine();
            Console.WriteLine("Tell us your name: ");
            playerName = Console.ReadLine();
            Console.WriteLine("How old are you?: ");
            sAge = Console.ReadLine();
            //choose a class:
            Console.WriteLine("1 - Warrior \n2 - Mage \n3 - Thief");
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
            Console.WriteLine(" Your name is: " + playerName + "\n you are: " + sAge + " years old ");
            Console.WriteLine(" Class: " + PlayerClass + "\n Strenght: " + playerStrenght + "\n Agility: " + playerAgility + "\n Health: " + playerWisdom);
            Console.WriteLine("Press [ENTER] to continue: ");
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
            playerClass = "Thief";
            iStrenght = 1;
            iAgility = 3;
            iWisdom = 2;
        }

    }
}
