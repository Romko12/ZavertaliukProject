using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1.Entities;

namespace Project1.Entities.enemies
{
    public class MageClass : BaseCreature
    {
        private protected int mana = 100;
        private int MaxMana = 100;

        public MageClass(string name, int attack) : base(name, 0)
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
    }

    public class TankClass : BaseCreature
    {
        public TankClass(string name, int attack) : base(name, attack)
        { }
    }
}
