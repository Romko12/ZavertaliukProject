using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Project1.Pages
{
    public partial class HomePage : UserControl
    {
        Form1 mainForm;
        public HomePage(Form1 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            int varplay = 0;
            if (varplay == 0)
            {
                varplay = 1;
                this.mainForm.panelContent.Controls.Clear();
                this.mainForm.panelContent.Controls.Add(new charactercreation());
            }
            else
            {
                this.mainForm.panelContent.Controls.Clear();
                this.mainForm.panelContent.Controls.Add(new MapPage());
            }
        }
    }
}