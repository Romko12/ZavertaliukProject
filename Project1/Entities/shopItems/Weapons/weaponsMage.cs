using Project1.Entities.shopItems;
using Project1.Entities.shopItems.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.shop
{
    public class BaseMageWeapon : BaseWeapon
    {
        private int _manaCost;
        public BaseMageWeapon(string name, int price, int manaCost, int value) : base(name, price, value)
        {
            _manaCost = manaCost;
        }
        public int GetManaCost() => _manaCost;
        public void GenerateMageWeapons()
        {
            BaseMageWeapon mageWeapon1 = new BaseMageWeapon("Staff of Fire", 0, 25, 20);
            BaseMageWeapon mageWeapon2 = new BaseMageWeapon("Staff of Ice", 100, 30, 25);
            BaseMageWeapon mageWeapon3 = new BaseMageWeapon("Staff of Lightning", 200, 30, 30);
            BaseWeapon specialWeapon = new BaseWeapon("Dagger", 5, 5);
        }
    }
}
   
    