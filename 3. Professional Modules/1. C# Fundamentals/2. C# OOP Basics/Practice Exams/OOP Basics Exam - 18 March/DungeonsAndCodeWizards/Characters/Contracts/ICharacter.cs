using DungeonsAndCodeWizards.Bags;
using DungeonsAndCodeWizards.Characters.Common;
using DungeonsAndCodeWizards.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Characters.Contracts
{
    public interface ICharacter
    {
        string Name { get; }
        double BaseHealth { get; }
        double Health { get; }
        double BaseArmor { get; }
        double Armor { get; }
        double AbilityPoints { get; }
        Bag Bag { get; }
        Faction Faction { get; }
        bool IsAlive { get; set; }
        double RestHealMultiplier { get; set; }
        void TakeDamage(double hitpoints);
        void Rest();
        void UseItem(Item item);
        void UseItemOn(Item item, Character character);
        void GiveCharacterItem(Item item, Character character);
        void ReceiveItem(Item item);
    }
}
