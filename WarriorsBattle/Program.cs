using System;

namespace WarriorsBattle
{
    class Program
    {
        static void Main(string[] args)
        {
           Random random = new Random();
           Warrior ted=new Warrior(random, "ted", 1000, 120, 110);
           Warrior bob = new Warrior(random, "bob", 1000, 100, 200);

           Game game = new Game(ted, bob);
           game.Play();
        }
    }
}
