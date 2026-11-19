using Project1.shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Services
{
    internal class GenerateShop
    {
        public void DisplayPotions()
        {
            basePotion healingPotion = new basePotion("Healing Potion", 10, 20);
            basePotion manaPotion = new basePotion("Mana Potion", 10, 20);
        }
    }
}
