using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project1;

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
             MagePlayer player = new MagePlayer(textBox1.Text);
           }
           else if (TankRadioButton1.Checked)
           {
             TankPlayer player = new TankPlayer(textBox1.Text);
           }

           else
           {
               MessageBox.Show("Please select a class.");
           }

        }
    }
}
