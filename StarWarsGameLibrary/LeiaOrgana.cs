using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsGameLibrary
{
    public class LeiaOrgana : Bounties
    {

        public bool IsRebelGen { get; set; }


        //set some values for a basic monster of this type in the 
        //default ctor

        public LeiaOrgana(string name, int hitChance, int block, int maxLife, int maxDamage, int minDamage, string description, bool isRebelGen) : base(name, hitChance, block, maxLife, maxDamage, minDamage, description)
        {
            IsRebelGen = isRebelGen;
        }
        public LeiaOrgana()
        {
            //SET Max Values First!!
            MaxLife = 6;
            MaxDamage = 3;
            Name = "Leia Organa";
            Life = 6;
            HitChance = 20;
            Block = 20;
            MinDamage = 1;
            Description = "Wanted by The Galactic Empire for helping and leading the Rebel Alliance for a price of 10,000,000 credits.";
            IsRebelGen= new Random().Next(2) == 1;

        }

        public override string ToString()
        {
            return base.ToString() + (IsRebelGen ? "General Organa is a firce oppentent after years of battle." : "The Galactic Empire wants her captured before their Rebel threat grows!");
        }

        public override int CalcBlock()
        {
            int calculatedBlock = Block;
            if (IsRebelGen)
            {
                calculatedBlock += calculatedBlock + 5;
            }
            return calculatedBlock;
        }
    }
}
