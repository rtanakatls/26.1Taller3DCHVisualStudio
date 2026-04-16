using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3DCH261
{
    internal class Character
    {

        protected string name;
        protected int life;

        public Character(string name, int life)
        {
            this.name = name;
            this.life = life;
        }
    }
}
