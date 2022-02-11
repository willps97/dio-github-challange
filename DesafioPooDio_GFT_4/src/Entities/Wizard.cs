using System;


namespace DesafioPooDio_GFT_4.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
        }

        public override string Attack()
        {
            return this.Name + " lançou magia!";
        }

        public string Attack (int Bonus)
        {
            if(Bonus > 6)
            {
                return this.Name + " lançou sua magia super efetiva com bonus " + Bonus;
            }
            else
            {
                return this.Name + " lançou sua magia com força fraca com bonus de ataque de " + Bonus;
            }
            
        }
    }

}
