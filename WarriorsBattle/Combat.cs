using System;


namespace WarriorsBattle
{
    public class Combat
    {
        public IWarrior Attacker { get; private set; }
        public IWarrior Defender { get; private set; }
        public int AttackPoints { get; private set; }
        public int BlockPoints { get; private set; }
        public int Damage { get; private set; }

        public Combat (IWarrior attacker, IWarrior defender)
        {
            Attacker = attacker;
            Defender = defender;
        }

        public void Execute()
        {
            AttackPoints = Attacker.Attack();
            BlockPoints = Defender.Block();
            Damage = CalculateDamage();
            DealDamageToDefender();
        }

        private void DealDamageToDefender()
        {
            Defender.Health -= Damage;
        }

        private int CalculateDamage()
        {
            return AttackPoints - BlockPoints > 0 ? AttackPoints - BlockPoints : 0;
        }
    }
}