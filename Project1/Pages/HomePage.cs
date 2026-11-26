using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Project1.Pages
{
    public partial class HomePage : UserControl
    {
        Form1 mainForm;
        Player player;
        public HomePage(Form1 mainForm, Player player)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }
        private int varplay = 0;
        private void playButton_Click(object sender, EventArgs e)
        {

            if (this.varplay == 0)
            {
                this.varplay = 1;
                this.mainForm.panelContent.Controls.Clear();
                this.mainForm.panelContent.Controls.Add(new charactercreation(this.mainForm));
            }
            else
            {
                this.mainForm.panelContent.Controls.Clear();
                this.mainForm.panelContent.Controls.Add(new MapPage());
            }
        }

        private void InvButton2_Click(object sender, EventArgs e)
        {
            this.mainForm.panelContent.Controls.Clear();
            this.mainForm.panelContent.Controls.Add(new InventoryPage(this.mainForm.player, this.mainForm));
        }
    }
}