using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project1;

namespace Project1.Pages
{
    public partial class charactercreation : UserControl
    {
        Form1 mainForm;
        public charactercreation(Form1 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }
        public int playerIMGVar = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter a name");
                return;
            }

            if (PlayerImgVarRadioButton1.Checked)
            {
                playerIMGVar = 1;
            }
            else if (PlayerImgVarRadioButton2.Checked)
            {
                playerIMGVar = 2;
            }
            else
            {
                MessageBox.Show("Please select a class");
                return;
            }

            this.mainForm.player = new Player(textBox1.Text);
            MessageBox.Show("First, choose ur loadout ");
            this.mainForm.panelContent.Controls.Clear();
            this.mainForm.panelContent.Controls.Add(new InventoryPage(this.mainForm.player, this.mainForm));

        }
    }
}
