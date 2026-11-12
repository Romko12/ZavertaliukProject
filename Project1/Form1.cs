using Project1.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        HomePage homePage = null;
        ShopPage shopPage = new Pages.ShopPage();       
        MapPage mapPage = new Pages.MapPage();
        FightPage fightPage = new Pages.FightPage();
        charactercreation characterCreationPage = new Pages.charactercreation();
        InventoryPage inventoryPage = new Pages.InventoryPage();

        public Form1()
        {
            InitializeComponent();
            homePage = new HomePage();
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(homePage);
            homePage.InvButton2.Enabled = false;
            homePage.shopButton2.Enabled = false;
        }







        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(homePage);
        }

        private void MapButton_Click(object sender, EventArgs e)
        {
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(mapPage);
        }

        private void ShopButton_Click(object sender, EventArgs e)
        {
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(shopPage);
        }
        private void InvButton_Click(object sender, EventArgs e)
        {
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(inventoryPage);
        }
    }
}
