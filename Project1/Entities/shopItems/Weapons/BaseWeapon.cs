using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Entities.shopItems.Weapons
{
    public class BaseWeapon : BaseItem
    {
        public BaseWeapon(string name, int price, int value) : base(name, price, value)
        {

        }
        public int GetDamage() => _value;
    }
}
