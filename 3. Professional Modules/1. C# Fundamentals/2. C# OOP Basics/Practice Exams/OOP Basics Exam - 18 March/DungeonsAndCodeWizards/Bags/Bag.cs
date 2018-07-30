using DungeonsAndCodeWizards.Bags.Contracts;
using DungeonsAndCodeWizards.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Bags
{
    public abstract class Bag : IBag
    {
        private int capacity;
        private int load;
        private readonly List<Item> items;

        public Bag(int capacity)
        {
            this.Capacity = capacity;
        }

        public IReadOnlyCollection<Item> Items
        {
            get
            {
                return this.items.AsReadOnly();
            }
        }

        public int Load
        {
            get { return load; }
            set { load = value; }
        }

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public void AddItem(Item item)
        {
            throw new NotImplementedException("Bag - Add Item not implemented");
        }

        public Item GetItem(string name)
        {
            throw new NotImplementedException("Bag - Get Item not implemented");
        }
    }
}
