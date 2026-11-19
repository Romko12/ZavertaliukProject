using Project1.shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Entities.shopItems.Weapons
{
    internal class WeaponsTank
    {
        public void GenerateTankWeapons()
        {
            BaseWeapon tankWeapon1 = new BaseWeapon("Sword of Fire", 0, 15);
            BaseWeapon tankWeapon2 = new BaseWeapon("Sword of Ice", 100, 15);
            BaseWeapon tankWeapon3 = new BaseWeapon("Sword of Lightning", 200, 15);
        }
    }
}
