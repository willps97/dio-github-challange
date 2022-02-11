using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPooDio_GFT_4.src.Entities
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }

        public Hero(string name, int level, string heroType)
        {
           Name = name;
           Level = level;
           HeroType = heroType;
        }
        public Hero()
        {

        }

        public virtual string Attack()
        {
            return this.Name + " atacou com a sua espada!";
        }
        public override string ToString()
        {
            return "Name: " + Name + ", Level: " + Level + ", Hero Type: " + HeroType;
        }

    }
}
