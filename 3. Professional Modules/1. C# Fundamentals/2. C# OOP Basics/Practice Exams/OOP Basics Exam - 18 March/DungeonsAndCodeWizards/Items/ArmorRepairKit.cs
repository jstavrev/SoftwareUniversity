using System;
using System.Collections.Generic;
using System.Text;
using DungeonsAndCodeWizards.Characters;

namespace DungeonsAndCodeWizards.Items
{
    public class ArmorRepairKit : Item
    {
        public ArmorRepairKit(int weight = 10) : base(weight)
        {
        }

        public override void AffectCharacter(Character character)
        {
            throw new Exception("Armor Repair Kit - Affect Character not implemented");
        }
    }
}
