using DungeonsAndCodeWizards.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Bags.Contracts
{
    public interface IBag
    {
        int Capacity { get; }
        IReadOnlyCollection<Item> Items { get; }
        int Load { get; set; }
        void AddItem(Item item);
        Item GetItem(string name);
    }
}
