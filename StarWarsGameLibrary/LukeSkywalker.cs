using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StarWarsGameLibrary
{
    public class LukeSkywalker : Bounties
    {
        public bool IsIV { get; set; }



        //set some values for a basic monster of this type in the 
        //default ctor

        public LukeSkywalker(string name, int hitChance, int block, int maxLife, int maxDamage, int minDamage, string description, bool isIV) : base(name, hitChance, block, maxLife, maxDamage, minDamage, description)
        {
            IsIV = isIV;
        }
        public LukeSkywalker()
        {
            //SET Max Values First!!
            MaxLife = 30;
            MaxDamage = 8;
            Name = "Luke Skywalker";
            Life = 30;
            HitChance = 30;
            Block = 10;
            MinDamage = 1;
            Description = "Wanted by The Glactic Empire for destruction of the Death Star and for being a self-proclaimed Jedi Knight.";
            IsIV = new Random().Next(2) == 1;
        }

        public override string ToString()
        {
            return base.ToString() + (IsIV ? "Episode IV Luke" : "Episode VI Luke");
        }

        public override int CalcBlock()
        {
            int calculatedBlock = Block;

            if (!IsIV)
            {
                calculatedBlock += calculatedBlock / 2;
            }

            return calculatedBlock;
        }

    }
}
