using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsGameLibrary
{
    public class Bounties : Character
    {
        //Fields
        private int _maxDamage;

        private int _minDamage;

        private string _description;

        //Props


        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }
        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value > 0 && value <= MaxDamage ? value : 0; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        //CTORS

        public Bounties(string name, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description) : base(name, maxLife, hitChance, block)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
        }

        public Bounties()
        {

        }


        //Methods
        public override string ToString()
        {
            return base.ToString() + $"\nMaxDamage: {MaxDamage}\n" +
                $"MinDamage: {MinDamage}\n" +
                $"Description: {Description}";
        }
        public override int CalcDamage()
        {
            //create a random object
            Random rand = new Random();
            //determine the damage
            int damage = rand.Next(MinDamage, MaxDamage + 1);
            //return the damage
            return damage;
        }
        public static Bounties GetBounty()
        {
            //Create a variety of monsters
            LukeSkywalker b1 = new LukeSkywalker(name: "Luke Skywalker", hitChance: 50, block: 20, maxLife: 25, maxDamage: 8, minDamage: 2, description: "Wanted by The Glactic Empire for destruction of the Death Star and for being a self-proclaimed Jedi Knight.", new Random().Next(2) == 1);
            Chewbacca b2 = new(name: "Chewbacca", hitChance: 70, block: 8, maxLife: 30, maxDamage: 8, minDamage: 1, description: "Wanted by Jaba the Hutt and The Galactic Empire.", new Random().Next(2) == 1);
            HanSolo b3 = new(name: "Han Solo", hitChance: 50, block: 10, maxLife: 25, maxDamage: 4, minDamage: 1, description: "Wanted by Jabba the Hutt and The Galactic Empire, price is around 200,000 credits...", new Random().Next(2) == 1);
            LeiaOrgana b4 = new(name: "Leia Organa", hitChance: 65, block: 20, maxLife: 20, maxDamage: 15, minDamage: 1, description: "Wanted by The Galactic Empire for helping and leading the Rebel Alliance for a price of 10,000,000 credits.", new Random().Next(2) == 1);
            TheMythrol b5 = new(name: "The Mythrol", hitChance: 20, block: 5, maxLife: 10, maxDamage: 10, minDamage: 1, description: "This Male Myhtrol stole credits from one of the Bounty Hunter Guild Leaders, Greef Karga. You can bring him in warm or you can bring him in cold.", 5, 10);

            //Add the monsters to a collection
            List<Bounties> bounties = new()
            {
                b1,
                b2,
                b3,
                b4,
                b5,b5,b5
            };
            //Pick one at random to place in our dungeion room
            return bounties[new Random().Next(bounties.Count)];
        }
    }
}
