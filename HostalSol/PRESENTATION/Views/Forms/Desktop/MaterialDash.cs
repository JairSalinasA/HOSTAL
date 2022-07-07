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

namespace PRESENTATION.Views.Forms.Dashboard
{

    public partial class MaterialDash : MaterialForm
    {
        //readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public MaterialDash()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Blue900, Accent.Blue700,TextShade.WHITE);
        }

        MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;
         

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblHora1.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha1.Text = DateTime.Now.ToShortDateString();
        }

        private void themeToggle_CheckedChanged_1(object sender, EventArgs e)
        {
            if (themeToggle.Checked)
            {
                ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
            }
            else
            {
                ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;
            }
        }
    }
}
