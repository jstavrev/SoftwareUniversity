using DungeonsAndCodeWizards.Characters;
using DungeonsAndCodeWizards.Items.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Items
{
    public abstract class Item : IItem
    {
        private int weight;

        public Item(int weight)
        {
            this.Weight = weight;
        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public abstract void AffectCharacter(Character character);
    }
}
