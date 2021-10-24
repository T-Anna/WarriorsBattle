using System;

namespace WarriorsBattle
{
    public class Game
    {
        private bool hasGameEnded { get; set; }
        private IWarrior FirstWarrior { get; set; }
        private IWarrior SecondWarrior { get; set; }
        public IWarrior Winner { get; private set; }

        public Game(IWarrior first, IWarrior second)
        {
            FirstWarrior = first;
            SecondWarrior = second;
        }

        public void Play()
        {
            IWarrior attacker = FirstWarrior;
            IWarrior defender = SecondWarrior;

            while (!hasGameEnded)
            {
                Combat currentCombat = new Combat(attacker, defender);
                currentCombat.Execute();

                UIMessages.printCombatResult(currentCombat);
                UIMessages.printHealth(FirstWarrior, SecondWarrior);

                if (!defender.IsAlive())
                {
                    hasGameEnded = true;
                    Winner = attacker;
                    UIMessages.printEndMessage(this);
                }
                else
                {
                    swapWarriors(ref attacker,  ref defender);
                }
            }
        }

        private static void swapWarriors(ref IWarrior first, ref IWarrior second)
        {
            IWarrior temp = first;
            first = second;
            second = temp;
        }

    }
}