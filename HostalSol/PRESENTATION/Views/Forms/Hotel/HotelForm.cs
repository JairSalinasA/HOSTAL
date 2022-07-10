using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRESENTATION.Views.Forms.Hotel
{
    public partial class HotelForm : MaterialForm
    {
        //readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public HotelForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
