using DungeonsAndCodeWizards.Bags;
using DungeonsAndCodeWizards.Characters.Common;
using DungeonsAndCodeWizards.Characters.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Characters
{
    public class Warrior : Character, IAttackable
    {
        public Warrior(string name, Faction faction, double health = 100, double armor = 50, double abilityPoints = 40) : base(name, health, armor, abilityPoints)
        {
            base.Faction = faction;
            base.Bag = new Satchel();
        }

        public void Attack(Character character)
        {
            throw new NotImplementedException();
        }

        private void EnsureNoFriendlyFire(Character character)
        {
            if (this.Faction == character.Faction)
            {
                throw new ArgumentException($"Friendly fire! Both characters are from {this.Faction} faction!");
            }
        }
    }
}
