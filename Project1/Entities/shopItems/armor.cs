using Project1.Entities;
using Project1.Entities.shopItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project1.shop
{ 
    public abstract class BaseArmor : BaseItem
    {
        public BaseArmor(string name, int price, int value) : base(name, price, value)
        {
        }
        public int GetDefense() => _value;
    }

    class armor1
    {
        public string name = "Armor of ";
        public int cost = 100;
        public int itemDefense = 5;
    }
    class armor2
    {
        public string name = "Armor of ";
        public int cost = 200;
        public int itemDefense = 10;
    }
    class armor3
    {
        public string name = "Armor of ";
        public int cost = 300;
        public int itemDefense = 15;
    }
    class armor4
    {
        public string name = "Armor of ";
        public int cost = 400;
        public int itemDefense = 20;
    }
}

