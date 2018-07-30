using System;
using System.Collections.Generic;
using System.Text;
using DungeonsAndCodeWizards.Characters;

namespace DungeonsAndCodeWizards.Items
{
    public class PoisonPotion : Item
    {
        public PoisonPotion(int weight = 5) : base(weight)
        {
        }

        public override void AffectCharacter(Character character)
        {
            throw new Exception("Poison Potion - Affect Character not implemented.");
        }
    }
}
