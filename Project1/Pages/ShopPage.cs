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
namespace Project1.Pages
{
    public partial class ShopPage : UserControl
    {
        Form1 mainForm;
        private Player player;
        private ShopItem IronArmor, GoldArmor, DiamondArmor;
        private ShopItem IronSword, GoldSword, DiamondSword;
        private ShopItem HealingPotion, DamagePotion;
        public ShopPage(Form1 mainForm, Player player, ShopItem IronArmor, ShopItem GoldArmor, ShopItem DiamondArmor, 
        ShopItem IronSword, ShopItem GoldSword, ShopItem DiamondSword, ShopItem HealingPotion, ShopItem DamagePotion)
        {
            InitializeComponent();

            generate_items.generateItems();
            this.IronArmor = IronArmor;
            this.GoldArmor = GoldArmor;
            this.DiamondArmor = DiamondArmor;
            this.IronSword = IronSword;
            this.GoldSword = GoldSword;
            this.DiamondSword = DiamondSword;
            this.HealingPotion = HealingPotion;
            this.DamagePotion = DamagePotion;

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
            shopVisualsLoader(IronArmor, Armor1Button, 1);
            shopVisualsLoader(GoldArmor, Armor2Button, 2);
            shopVisualsLoader(DiamondArmor, Armor3Button, 3);

            shopVisualsLoader(IronSword, Weapon1Button, 4);
            shopVisualsLoader(GoldSword, Weapon2Button, 5);
            shopVisualsLoader(DiamondSword, Weapon3Button, 6);

            shopVisualsLoader(HealingPotion, Potion1Button, 7);
            shopVisualsLoader(DamagePotion, Potion2Button, 7);
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
