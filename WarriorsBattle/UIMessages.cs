using System;

namespace WarriorsBattle
{
    class UIMessages
    {

        public static void printCombatResult(Combat combat)
        {
            if (combat.Damage > 0)
            {
                Console.WriteLine($"{combat.Attacker.Name} attacked {combat.Defender.Name} and deals {combat.Damage} damage");
            }
            else
            {
                Console.WriteLine($"{combat.Attacker.Name} attacked {combat.Defender.Name} but {combat.Defender.Name} blocked all attacks");
            }
        }

        public static void printHealth(IWarrior first, IWarrior second)
        {
            Console.WriteLine($"{first.Name} has {first.Health} health");
            Console.WriteLine($"{second.Name} has {second.Health} health \n");
        }

        public static void printEndMessage(IWarrior winner)
        {
            Console.WriteLine($"{winner.Name} won");
            Console.WriteLine("Game over");
        }
    }
}
