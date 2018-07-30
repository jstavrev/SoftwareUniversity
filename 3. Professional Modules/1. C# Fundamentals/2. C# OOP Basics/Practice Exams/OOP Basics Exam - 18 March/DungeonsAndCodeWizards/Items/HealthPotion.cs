using System;
using System.Collections.Generic;
using System.Text;
using DungeonsAndCodeWizards.Characters;

namespace DungeonsAndCodeWizards.Items
{
    public class HealthPotion : Item
    {
        public HealthPotion(int weight = 5) : base(weight)
        {
        }

        public override void AffectCharacter(Character character)
        {
            throw new Exception("Health Potion - Affect Character not implemented.");
        }
    }
}
