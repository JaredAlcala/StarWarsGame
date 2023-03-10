using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StarWarsGameLibrary
{
    public class HanSolo : Bounties
    {
        public bool IsFluffy { get; set; }



        //set some values for a basic monster of this type in the 
        //default ctor

        public HanSolo(string name, int hitChance, int block, int maxLife, int maxDamage, int minDamage, string description, bool isFluffy) : base(name, hitChance, block, maxLife, maxDamage, minDamage, description)
        {
            IsFluffy = isFluffy;
        }
        public HanSolo()
        {
            //SET Max Values First!!
            MaxLife = 6;
            MaxDamage = 3;
            Name = "Han Solo";
            Life = 6;
            HitChance = 20;
            Block = 20;
            MinDamage = 1;
            Description = "Wanted by Jabba the Hutt and The Galactic Empire, price is around 200,000 credits...";
            IsFluffy = new Random().Next(2) == 1;
        }

        public override string ToString()
        {
            return base.ToString() + (IsFluffy ? "Fluffy" : "Not so fluffy");
        }

        public override int CalcBlock()
        {
            int calculatedBlock = Block;

            //Apply a 50% increase to the Rabbit's block if it's fluffy
            if (IsFluffy)
            {
                calculatedBlock += calculatedBlock / 2;
            }

            return calculatedBlock;
        }

    }
}
