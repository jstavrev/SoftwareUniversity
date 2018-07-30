using DungeonsAndCodeWizards.Bags;
using DungeonsAndCodeWizards.Characters.Common;
using DungeonsAndCodeWizards.Characters.Contracts;
using DungeonsAndCodeWizards.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Characters
{
    public abstract class Character : ICharacter
    {
        private string name;
        private double baseHealth;
        private double health;
        private double baseArmor;
        private double armor;
        private double abilityPoints;
        private Bag bag;
        private Faction faction;
        private bool isAlive;
        private double restHealMultiplier;

        public Character(string name, double health, double armor, double abilityPoints)
        {
            this.Name = name;
            this.Health = health;
            this.BaseHealth = health;
            this.Armor = armor;
            this.BaseArmor = armor;
            this.AbilityPoints = abilityPoints;
            this.IsAlive = true;
            this.RestHealMultiplier = 0.2;
        }

        public double RestHealMultiplier
        {
            get { return restHealMultiplier; }
            set { restHealMultiplier = value; }
        }

        public bool IsAlive
        {
            get { return isAlive; }
            set { isAlive = value; }
        }

        public Faction Faction
        {
            get { return faction; }
            set { faction = value; }
        }

        public Bag Bag
        {
            get { return bag; }
            set { bag = value; }
        }

        public double AbilityPoints
        {
            get { return abilityPoints; }
            set { abilityPoints = value; }
        }

        public double Armor
        {
            get { return armor; }
            set { armor = value; }
        }

        public double BaseArmor
        {
            get { return baseArmor; }
            set { baseArmor = value; }
        }

        public double Health
        {
            get { return health; }
            set { health = value; }
        }

        public double BaseHealth
        {
            get { return baseHealth; }
            set { baseHealth = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void GiveCharacterItem(Item item, Character character)
        {
            throw new NotImplementedException();
        }

        public void ReceiveItem(Item item)
        {
            throw new NotImplementedException();
        }

        public void Rest()
        {
            throw new NotImplementedException();
        }

        public void TakeDamage(double hitpoints)
        {
            throw new NotImplementedException();
        }

        public void UseItem(Item item)
        {
            throw new NotImplementedException();
        }

        public void UseItemOn(Item item, Character character)
        {
            throw new NotImplementedException();
        }
    }
}
