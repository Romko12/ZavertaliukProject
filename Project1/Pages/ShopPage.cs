using Project1.Entities.shopItems;
using Project1.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace Project1.Pages
{
    public partial class ShopPage : UserControl
    {
        Form1 mainForm;
        private Player player;
        private List<ShopItem> weapons = new List<ShopItem>(); 
        public ShopPage(Form1 mainForm, Player player)
        {
            InitializeComponent();

            weapons.Add(GenerateItems.GenerateItem("IronArmor", 0, 15));
            weapons.Add(GenerateItems.GenerateItem("GoldArmor", 50, 25));
            weapons.Add(GenerateItems.GenerateItem("DiamondArmor", 100, 35));

            

            /*this.IronSword = GenerateItems.GenerateItem("IronSword", 0, 15);
            this.GoldSword = GenerateItems.GenerateItem("GoldSword", 50, 25);
            this.DiamondSword = GenerateItems.GenerateItem("DiamondSword", 100, 35);
            this.HealingPotion = GenerateItems.GenerateItem("HealingPotion", 15, 20);
            this.DamagePotion = GenerateItems.GenerateItem("DamagePotion", 15, 10);*/

            this.player = player;
            this.mainForm = mainForm;

            LoadVisual();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.mainForm.panelContent.Controls.Clear();
            this.mainForm.panelContent.Controls.Add(new InventoryPage(this.mainForm.player, this.mainForm));
        }
        private void playerbuy(ShopItem item, int ItemPlace)
        {
            LoadVisual();
            player.decreaseMoney(item.GetPrice());
            player.itemInv[ItemPlace] = 1;
            LoadVisual();
        }



        private void LoadVisual()
        {
            shopVisualsLoader(weapons[0], Armor1Button, 1);
            shopVisualsLoader(weapons[1], Armor2Button, 2);
            shopVisualsLoader(weapons[2], Armor3Button, 3);

            /*shopVisualsLoader(IronSword, Weapon1Button, 4);
            shopVisualsLoader(GoldSword, Weapon2Button, 5);
            shopVisualsLoader(DiamondSword, Weapon3Button, 6);

            shopVisualsLoader(HealingPotion, Potion1Button, 7);
            shopVisualsLoader(DamagePotion, Potion2Button, 7);*/
        }
        private void shopVisualsLoader(ShopItem item, Button button, int ItemPlace /*1 - 6*/ )
        {
            if (ItemPlace == 7)
            {
                button.Text = ("Buy\n" + item.GetPrice() + "$");
            }
            else
            {
                if (player.itemInv[ItemPlace] == 0)
                {
                    button.Text = ("Buy\n" + item.GetPrice() + "$");
                }
                else
                {
                    button.Text = ("Owned");
                    button.Enabled = false;
                }
            }

            if (player.getMoney() < item.GetPrice())
                button.Enabled = false;

        }

    }
}
