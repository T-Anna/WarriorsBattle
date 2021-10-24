using System;

namespace WarriorsBattle
{
    public class Warrior: IWarrior
    {
        private int health;
        private Random rand;

        public string Name { get; private set; } 
        public int Health
        {
            get { return health; }
            set
            {
                health = value > 0 ? value : 0;
            }
        }
        public int MaxAttack { get; private set; }
        public int MaxBlock { get; private set; }

        public Warrior (Random rand, string name, int health, int maxAttack, int maxBlock)
        {
            this.rand = rand;
            Name = name;
            Health = health;
            MaxAttack = maxAttack;
            MaxBlock = maxBlock;
        }

        public int Attack()
        {
            return rand.Next(1, MaxAttack+1);
        }

        public int Block()
        {
            return rand.Next(1, MaxBlock+1);
        }

        public bool IsAlive()
        {
            return Health > 0;
        }
    }
}