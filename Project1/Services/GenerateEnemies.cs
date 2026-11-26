using Project1.Entities.enemies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Services
{
    internal class GenerateEnemies
    {
        public void displayEnemies()
        {
            BaseCreature enemy1= new BaseCreature("Mage", 9);
            BaseCreature enemy2 = new BaseCreature("Tank", 20);
            BaseCreature enemy3 = new BaseCreature("Mage", 25);
            BaseCreature enemy4 = new BaseCreature("Tank", 30);
            BaseCreature boss = new BaseCreature("Mage", 50);
        }
    }
}
