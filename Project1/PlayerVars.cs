using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1.Entities;
using Project1.Entities.enemies;
namespace Project1
{
    public class PlayerBase : BaseCreature
    {
        private int money = 0;
        private int armor = 0;
        private int weapon = 0;
        private int potion1 = 0;
        private int potion1Count = 0;
        private int potion2 = 0;
        private int potion2Count = 0;


        public PlayerBase(string name) : base(name, 0)
        {

            money = 0;
            armor = 0;
            weapon = 0;
            potion1 = 0;
            potion1Count = 0;
            potion2 = 0;
            potion2Count = 0;
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



        public void setArmor(int armorValue)
        {
            armor = armorValue;
        }
        public void setWeapon(int weaponValue)
        {
            weapon = weaponValue;
        }

        public void setPotion1(int potion1Value)
        {
            potion1 = potion1Value;
        }
        public void increasePotion1Count(int potion1CountValue)
        {
            potion1Count = potion1CountValue;
        }
        public void decreasePotion1Count(int potion1CountValue)
        {
            potion1Count -= potion1CountValue;
            if (potion1Count < 0)
            {
                potion1Count = 0;
            }
        }

        public void setPotion2(int potion2Value)
        {
            potion2 = potion2Value;
        }
        public void increasePotion2Count(int potion2CountValue)
        {
            potion2Count = potion2CountValue;
        }
        public void decreasePotion2Count(int potion2CountValue)
        {
            potion2Count -= potion2CountValue;
            if (potion2Count < 0)
            {
                potion2Count = 0;
            }
        }
    }
    public class MagePlayer : PlayerBase
    {
        private Boolean aditionalweapon = false;
        protected int mana = 100;
        private int MaxMana = 100;

        public MagePlayer(string name) : base(name)
        {
            mana = MaxMana = 100;
        }
        public void increaseMana(int manaValue)
        {
            mana += manaValue;
            if (mana > MaxMana)
            {
                mana = MaxMana;
            }
        }
        public void decreaseMana(int manaValue)
        {
            mana -= manaValue;
            if (mana < 0)
            {
                mana = 0;
            }
        }
        public void generateMagePlayer(string name)
        {
            MagePlayer Player = new MagePlayer(name);
        }
    }
    public class TankPlayer : PlayerBase
    {
        protected Boolean shieldEquipped = false;
        public TankPlayer(string name) : base(name)
        {
            shieldEquipped = false;
        }
        public void ToggleAditionalWeapon()
        {
            shieldEquipped = true;
        }
        public void generateTankPlayer(string name)
        {
            TankPlayer Player = new TankPlayer(name);
        }
    }

}
    

