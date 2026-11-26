using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Entities.shopItems
{
    public class ShopItem : BaseEntity
    {
        protected int _price;
        protected int _value;

        public ShopItem(string name, int price, int value) : base(name)
        {
            _price = price;
            _value = value;

        }

        public int GetPrice() => _price;
        public int GetDefense() => _value;
        public int GetDamage() => _value;
        public int GetEffectAmount() => _value;
    }
}
