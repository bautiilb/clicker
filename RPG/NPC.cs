using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    internal class NPC : Entity
    {
        public NPC(string name, int HP) : base(name, HP)
        {
            this.name = name;
            HP = 1;
        }
    }
}
