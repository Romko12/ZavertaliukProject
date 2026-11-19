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
using Project1.Services;

namespace Project1.Pages
{
    public partial class ShopPage : UserControl
    {
        public ShopPage()
        {
            InitializeComponent();
            GenerateShop generateShop = new GenerateShop();
            generateShop.DisplayPotions();
        }
    }
}
