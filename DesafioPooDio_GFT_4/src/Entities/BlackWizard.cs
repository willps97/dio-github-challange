using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPooDio_GFT_4.src.Entities
{
    class BlackWizard: Hero
    {
        public BlackWizard(string name, int level, string heroType)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
        }

        public BlackWizard()
        {

        } 

        public override string Attack()
        {
            return this.Name + " lançou magia escura!";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 4)
            {
                return this.Name + " lançou sua magia escura super efetiva com bonus " + Bonus;
            }
            else
            {
                return this.Name + " lançou sua magia escura com força fraca com bonus de ataque de " + Bonus;
            }

        }
    }
}
