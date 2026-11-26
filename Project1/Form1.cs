using Project1.Entities.shopItems;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project1
{
    public partial class Form1 : Form
    {
        HomePage homePage = null;  
        MapPage mapPage = new Pages.MapPage();
        FightPage fightPage = new Pages.FightPage();
        InventoryPage inventoryPage;
        public Player player;
        Form1 mainForm;

        public Form1()
        {
            InitializeComponent();
            homePage = new HomePage(this, player);
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(homePage);
            homePage.InvButton2.Enabled = false;
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(homePage);
        }


    }
}
