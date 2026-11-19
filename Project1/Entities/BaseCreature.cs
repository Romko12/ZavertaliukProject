using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Entities.enemies
{
    public class BaseCreature : BaseEntity
    {
        public Random random = new Random();
        private protected int Hp = 100;
        private protected int MaxHp = 100;
        private protected int Attack = 5;
        private protected int criticalChance = 5;
        private protected int Defense = 0;

        public BaseCreature(string name, int attack) : base(name)
        {
            Hp = MaxHp = 100;
            Attack = attack;
            criticalChance = 10;
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