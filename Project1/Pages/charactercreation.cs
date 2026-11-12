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
    public partial class charactercreation : UserControl
    {
        public charactercreation()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MageRadioButton2.Checked)
            {
                Player player = new Player(textBox1.Text, 2);
            }
            else if (TankRadioButton1.Checked)
            {
                Player player = new Player(textBox1.Text, 1);
            }

            else
            {
                MessageBox.Show("Please select a class.");
            }

        }
    }
}
