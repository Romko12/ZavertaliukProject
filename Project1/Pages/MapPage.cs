using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1.Pages
{
    public partial class MapPage : UserControl
    {
        public int MapEnemyVal = 0;
        public MapPage()
        {
            InitializeComponent();
            Enemy2Button.Enabled = false;
            Enemy3Button.Enabled = false;
            Enemy4Button.Enabled = false;
            BossButton.Enabled = false;
        }

        private void Enemy1Button_Click(object sender, EventArgs e)
        {
            MapEnemyVal = 1;
        }

        private void Enemy2Button_Click(object sender, EventArgs e)
        {
            MapEnemyVal = 2;
        }

        private void Enemy3Button_Click(object sender, EventArgs e)
        {
            MapEnemyVal = 3;
        }

        private void Enemy4Button_Click(object sender, EventArgs e)
        {
            MapEnemyVal = 4;
        }

        private void BossButton_Click(object sender, EventArgs e)
        {
            MapEnemyVal = 5;
        }
    }
}
