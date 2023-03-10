using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsGameLibrary
{
    public class Chewbacca : Bounties
    {

        public bool IsRage { get; set; }

        public Chewbacca(string name, int hitChance, int block, int maxLife, int maxDamage, int minDamage, string description, bool isRage) : base(name, hitChance, block, maxLife, maxDamage, minDamage, description)
        {
            IsRage = isRage;
        }

        public Chewbacca()
        {
            MaxLife = 6;
            MaxDamage = 3;
            Name = "Chewbacca";
            Life = 6;
            HitChance = 25;
            Block = 20;
            MinDamage = 1;
            Description = "Wanted by Jaba the Hutt and The Galactic Empire.";
            IsRage= new Random().Next(2) == 1;
        }

        public override string ToString()
        {
            return base.ToString() + (IsRage ? "You've mad the Wookie mad! Be carful!" : "You let the Wookie win, this give you a better chance at capturing him");
        }

        public override int CalcDamage()
        {
            int calculatedDamage = MaxDamage;
            if (IsRage)
            {
                calculatedDamage += calculatedDamage + 5;
            }


            return calculatedDamage;
        }

    }
}
