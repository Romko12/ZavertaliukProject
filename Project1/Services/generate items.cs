using Project1.Entities.shopItems;
using Project1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Services
{
    public class generate_items
    {
        public static void generateItems()
        {
            ShopItem IronArmor = new ShopItem("IronArmor", 0, 15);
            ShopItem GoldArmor = new ShopItem("GoldArmor", 50, 25);
            ShopItem DiamondArmor = new ShopItem("DiamondArmor", 100, 35);

            ShopItem IronSword = new ShopItem("IronSword", 0, 15);
            ShopItem GoldSword = new ShopItem("GoldSword", 50, 25);
            ShopItem DiamondSword = new ShopItem("DiamondSword", 100, 35);

            ShopItem HealingPotion = new ShopItem("HealingPotion", 15, 20);
            ShopItem DamagePotion = new ShopItem("DamagePotion", 15, 10);
        }
    }
}
