using System;
using SuperDuperRPG.Characters;
using SuperDuperRPG.Menus;


namespace SuperDuperRPG.Menus
{
    internal class FightMenu
    {
        string test;
        Enemy enemy = new Enemy();

        public void FightScene0()
        {
            Console.WriteLine("Begin of fight menu. create enemy");
            enemy.CreateEnemy();
            Console.WriteLine("HP: " + enemy.enemyHP);
            Console.WriteLine("You are fightin against: " + enemy.enemyName);
            Console.WriteLine("Test str: " + enemy.enemyStrenght);
            Console.WriteLine("test agility: " + enemy.enemyAgility);
            Console.WriteLine("Test enemy wisdom:" + enemy.enemyWisdom);
            Console.WriteLine("Press [ENTER] to Continue");
            Console.ReadLine();
        }

    }
}
