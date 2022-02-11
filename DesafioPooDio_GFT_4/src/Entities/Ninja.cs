using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPooDio_GFT_4.src.Entities
{
    class Ninja: Hero
    {
        public Ninja(string name, int level, string heroType)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
        }
        public Ninja()
        {

        }

        public override string Attack()
        {
            return this.Name + " lançou sua estrela da morte com dano médio ";
        }

    }
}
