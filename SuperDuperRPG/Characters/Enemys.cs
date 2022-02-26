using SuperDuperRPG.Characters;
using System;
using SuperDuperRPG.Menus;
using System.Runtime;



namespace SuperDuperRPG.Characters
{
    internal class Enemy
    {
        public string enemyName;
        public string[] enemyNamesList =
        {
            "Rufus", "Bear", "The Thunder", "Monty the mighty Python"
        };
        public string enemyClass;
        public int enemyStrenght;
        public int enemyAgility;
        public int enemyWisdom;
        public int enemyHP = 20;
        public int enemyMana;
        PlayerCharacter enemyChar = new PlayerCharacter();

        public void CreateEnemy()
        {
            Random rnd = new Random();
            int enemyNameIndex = rnd.Next(enemyNamesList.Length);
            enemyName = enemyNamesList[enemyNameIndex];
            enemyAgility = rnd.Next(1, 4);
            enemyWisdom = rnd.Next(1, 4);
            enemyStrenght = rnd.Next(1, 4);
            
        }
    }
}
