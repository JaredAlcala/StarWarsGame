using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsGameLibrary
{
    public class Weapons

    {
        //Fields
        /* int max damage (cannot be less than 0) -assign first in ctor -buissness rule*/
        private int _maxDamage;

        /*int min damage (cannot be less than 0 or over max damage) buissness rule*/
        private int _minDamage;

        /* string for the name*/
        private string _name;
        /* int for bonusHitChance*/
        private int _bonusHitChance;
        /* bool isTwoHanded*/
        private bool _isTwoHanded;

        private WeaponTypes _type;

        //Props - 1 for each field
        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }

        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int BonusHitChance
        {
            get { return _bonusHitChance; }
            set { _bonusHitChance = value; }
        }

        public bool IsTwoHanded
        {
            get { return _isTwoHanded; }
            set { _isTwoHanded = value; }
        }

        public WeaponTypes Type
        {
            get { return _type; }
            set { _type = value; }
        }
        //Constructors/Ctors
        //1 fq ctor, and i unqualified ctor if you want Object Initialization Syntax
        public Weapons() { }
        public Weapons(int maxDamage, int minDamage, string name, int bonusHitChance, bool isTwoHanded, WeaponTypes type)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Name = name;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;
            Type = type;


        }

        //Method
        //nicely formatted ToString() over ride
        public override string ToString()
        {
            //return base.ToString();
            return $"{Name}\n" +
                $"Weapon Type: {Type}\n" +
                $"MaxDamage: {MaxDamage}\n" +
                $"MinDamage: {MinDamage}\n" +
                $"Bonus Hit Chance: {BonusHitChance} \n" +
                $"Is Two Handed: {IsTwoHanded}\n";
        }

        public static Weapons GetWeapon(WeaponTypes type)
        {
            Weapons w1 = new(5, 1, "Fists", 5, true, WeaponTypes.Fists);
            Weapons w2 = new(10, 4, "DC-17 Blaster Pistol", 5, true, WeaponTypes.DC17_Pistol);
            Weapons w3 = new(15, 6, "WESTAR-34 Blaster Pistol", 5, true, WeaponTypes.WESTAR34_Pistol);
            Weapons w4 = new(20, 10, "EE-3 Blaster Rifle", 5, false, WeaponTypes.EE3_Blaster_Rifle);
            Weapons w5 = new(30, 10, "DLT-19 Heavy Blaster", 5, false, WeaponTypes.DLT19_Heavy_Blaster);
            Weapons w6 = new(40, 20, "DC-15X Sniper Blaster", 5, false, WeaponTypes.DC15X_Sniper);
            Weapons w7 = new(20, 10, "A280 Blaster Rifle", 5, false, WeaponTypes.A280_Blaster_Rifle);
            Weapons w8 = new(25, 6, "Cycler Rifle", 5, false, WeaponTypes.Cycler_Rifle);
            Weapons w9 = new(20, 6, "E-11 Blaster Rifle", 5, false, WeaponTypes.E11_Blaster_Rifle);

            List<Weapons> weapon = new()
            {
                w1,
                w2,
                w3,
                w4,
                w5,
                w6,
                w7,
                w8,
                w9,
            };

            return Weapons.GetWeapon(type);
        }
    }
}
