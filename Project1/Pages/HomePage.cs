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
    public partial class HomePage : UserControl
    {
        Form1 form1 = new Form1();
        public HomePage()
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            int varplay = 0;
            if (varplay == 0)
            {
                varplay = 1;
                this.form1.panelContent.Controls.Clear();
                this.form1.panelContent.Controls.Add(new charactercreation());
            }
            else
            {
                this.form1.panelContent.Controls.Clear();
                this.form1.panelContent.Controls.Add(new MapPage());
            }
        }
    }
}
