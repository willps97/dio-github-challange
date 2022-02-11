using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPooDio_GFT_4.src.Entities
{
    class Knight: Hero
    {
        public Knight(string name, int level, string heroType)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
        }

        public override string ToString()
        {
            return  this.Name + " atacou com a sua espada!";
        }
    }
    
}
