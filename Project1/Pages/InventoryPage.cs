using Project1.Services;
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
    
    public partial class InventoryPage : UserControl
    {
        Form1 mainForm;
        private Player player;
        public InventoryPage(Player player, Form1 mainForm )
        {
            this.player = player;
            InitializeComponent();
            HPotionLabel.Text = player.getHPotionCount().ToString();
            DPotionLabel.Text = player.getDPotionCount().ToString();
            this.mainForm = mainForm;
        }


        private void ShopButton_Click(object sender, EventArgs e)
        {
            this.mainForm.panelContent.Controls.Clear();
            this.mainForm.panelContent.Controls.Add(new ShopPage(this.mainForm, this.player ));
        }
    }
}
