using Project1.Entities.shopItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.shop
{
    public class basePotion : BaseItem
    {
        public basePotion(string name, int price, int value) : base(name, price, 0)
        {
        }
        public int GetRestoreAmount() => _value;

        public void DisplayPotions()
        {
            basePotion healingPotion = new basePotion("Healing Potion", 10, 20);
            basePotion manaPotion = new basePotion("Mana Potion", 10, 20);
        }
    }
}

