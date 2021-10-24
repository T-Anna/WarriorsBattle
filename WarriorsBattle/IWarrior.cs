using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorsBattle
{
    public interface IWarrior
    {
        public string Name { get; }
        public int Health { get; set; }
        public int MaxAttack { get; }
        public int MaxBlock { get; }

        public int Attack();
        public int Block();
        public bool IsAlive();
    }
}
