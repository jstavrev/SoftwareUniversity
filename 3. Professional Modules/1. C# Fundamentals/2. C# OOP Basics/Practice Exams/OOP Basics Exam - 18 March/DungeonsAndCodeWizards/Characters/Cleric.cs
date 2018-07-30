using DungeonsAndCodeWizards.Bags;
using DungeonsAndCodeWizards.Characters.Common;
using DungeonsAndCodeWizards.Characters.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Characters
{
    public class Cleric : Character, IHealable
    {
        public Cleric(string name, Faction faction, double health = 50, double armor = 25, double abilityPoints = 40) : base(name, health, armor, abilityPoints)
        {
            base.Faction = faction;
            base.Bag = new Backpack();
            base.RestHealMultiplier = 0.5;
        }

        public void Heal(Character character)
        {
            throw new NotImplementedException();
        }
    }
}
