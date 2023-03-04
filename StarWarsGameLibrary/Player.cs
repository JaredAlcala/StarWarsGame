﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsGameLibrary
{
    public class Player : Character
    {
        //Fields

        //Probs
        public Race PlayerRace { get; set; }
        public Weapons EquippedWeapon { get; set; }

        //Constructors
        public Player(string Name, int MaxLife, int HitChance, int Block, Race playerRace, Weapons equippedWeapon)
            : base(Name, MaxLife, HitChance, Block)
        {
            PlayerRace = playerRace;
            EquippedWeapon = equippedWeapon;

            #region Potential Expansion - Racial Bonuses
            switch (PlayerRace)
            {
                case Race.Rodians:
                    break;
                case Race.Wookie:
                    break;
                case Race.Mandalorian:
                    break;
                case Race.Human:
                    break;
                case Race.Trandoshan:
                    break;
                case Race.Duros:
                    break;

            }
            #endregion


        }
        //Methods
        public override string ToString()
        {
            //create a string , switch on player race and write some descri[tion about tthat race
            string description = PlayerRace.ToString();
            return base.ToString() + $"\nWeapon: {EquippedWeapon}\n" +
                $"Description: {description}";
        }
        public override int CalcDamage()
        {
            //create a random object
            Random rand = new Random();
            //determine the damage
            int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage);
            //return the damage
            return damage;
        }
        public override int CalcHitChance()
        {
            return HitChance + EquippedWeapon.BonusHitChance;


        }
    }
}
