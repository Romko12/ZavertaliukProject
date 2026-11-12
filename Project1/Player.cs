using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Player
    {
        Random random = new Random();

        private string Name = "Player";

        private int Hp = 100;
        private int MaxHp = 100;

        private int Class = 0;

        private int Attack = 5;
        private int criticalChance = 5;
        private int Defense = 0;

        private int mana = 100;
        private int MaxMana = 100;

        private int money = 0;

        public Boolean shieldEquipped = false;
        public int armor = 0;
        public int weapon = 0;
        public int potion1 = 0;
        public int potion1Count = 0;
        public int potion2 = 0;
        public int potion2Count = 0;

        public Player(string name, int classValue)
        {
            Class = classValue;

            Name = name;
            Hp = MaxHp = 100;

            money = 0;

            Attack = 5;
            criticalChance = 5;
            Defense = 0;
            mana = MaxMana = 100;

            shieldEquipped = false;
            armor = 0;
            weapon = 0;

            potion1 = 0;
            potion1Count = 0;
            potion2 = 0;
            potion2Count = 0;
        }

        public void setClass(int classValue) // 1-3
        {
            Class = classValue;
        }
        public void setName(string name)
        {
            Name = name;
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

        public void increaseHp(int hp)
        {
            Hp += hp;
            if (Hp > MaxHp)
            {
                Hp = MaxHp;
            }
        }
        public void decreaseHp(int hp)
        {
            Hp -= hp;
            if (Hp < 0)
            {
                Hp = 0;
            }
        }


        public void setDefense(int DefenseValue)
        {
            Defense = DefenseValue;
        }

        public void setAttack(int AttackValue)
        {
            Attack = AttackValue;
        }

        public void setCriticalChance(int criticalChanceValue)
        {
            criticalChance = criticalChanceValue;
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


        public void CheckCritical()
        {
            int chance = random.Next(0, 100);
            if (chance < criticalChance)
            {
                Attack *= 2;
            }
        }
    }
}
