using Project1.Entities.shopItems;
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
    public partial class ShopPage : UserControl
    {
        Player player;
        List<BaseItem> items;
        public ShopPage(Player player)
        {
            InitializeComponent();
            flowLayoutPanelShop.MouseEnter += (s, e) => flowLayoutPanelShop.Focus();
            this.Load += (s, e) => { flowLayoutPanelShop.PerformLayout(); };
        }

      
        
        private void BuyItem(Button clickedButton, int itemIndex)
        {
            if (shop.Buy(Kris, items[itemIndex]) == true)
            {
                clickedButton.Enabled = false;
                clickedButton.Text = "Already bought";
                clickedButton.BackColor = Color.LightGreen;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuyItem(button1, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BuyItem(button2, 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BuyItem(button3, 2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BuyItem(button4, 3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BuyItem(button5, 4);
        }

        private void pictureBoxShopImage_Click(object sender, EventArgs e)
        {

        }
    }
}

