using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.enemies
{
    internal class Enemy4
    {
        Random random = new Random();

        private string Name = "Player";

        private int Hp = 100;
        private int MaxHp = 100;


        private int Attack = 5;
        private int criticalChance = 5;
        private int Defense = 0;


        public int armor = 0;
        public int weapon = 0;

        public int enemyval = 4;

        public Enemy4(string name, int weapon, int armor)
        {
            enemyval = 4;

            Name = name;
            Hp = MaxHp = 100;

            armor = 0;
            weapon = 0;

            Attack = 5;
            criticalChance = 5;
            Defense = 0;

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
