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
        protected int damage;

        public Character(string name, int life, int damage)
        {
            this.name = name;
            this.life = life;
            this.damage = damage;
        }
    }
}
