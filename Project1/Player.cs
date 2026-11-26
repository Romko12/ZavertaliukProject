using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Project1.Entities;
using Project1.Entities.enemies;
using Project1.Entities.shopItems;
namespace Project1
{
    public class Player : BaseCreature
    {
        private int money = 0;
        private int HpotionCount = 0;
        private int DpotionCount = 0;
        private Boolean shieldEquipped = false;
        private int Weapon;
        private int Armor;
        public List<int> itemInv = new List<int> {0, 0, 0, 0, 0, 0};

        public Player(string name) : base(name, 0)
        {

            money = 0;
            HpotionCount = 0;
            DpotionCount = 0;
            shieldEquipped = false;
        }

        public void increaseMoney(int amount)
        {
            money += amount;
        }
        public void decreaseMoney(int amount)
        {
            money -= amount;
            if (money < 0)
            {
                money = 0;
            }
        }
        public int getMoney() => money;

        public void increaseHPotionCount(int potion1CountValue)
        {
            HpotionCount = potion1CountValue;
        }
        public void decreaseHPotionCount(int potion1CountValue)
        {
            HpotionCount -= potion1CountValue;
            if (HpotionCount < 0)
            {
                HpotionCount = 0;
            }
        }
        public int getHPotionCount() => HpotionCount;

        public void increaseDPotionCount(int potion2CountValue)
        {
            DpotionCount = potion2CountValue;
        }
        public void decreaseDPotionCount(int potion2CountValue)
        {
            DpotionCount -= potion2CountValue;
            if (DpotionCount < 0)
            {
                DpotionCount = 0;
            }
        }
        public int getDPotionCount() => DpotionCount;

        public void ToggleAditionalWeapon()
        {
            shieldEquipped = true;
        }

    }
}

