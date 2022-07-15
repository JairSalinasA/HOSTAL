using FontAwesome.Sharp;
using PRESENTATION.Helpers;
using PRESENTATION.Views.Forms.Dashboard;
using PRESENTATION.Views.Forms.Hotel;
using PRESENTATION.Views.Forms.Inventario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRESENTATION.Views.Forms
{
    public partial class Desktop : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public Desktop()
        {
            InitializeComponent();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
        }


        //Structs 63, 65, 89  --241, 202, 136
        private struct RGBColors
        {
            //public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color1 = Color.FromArgb(241, 202, 136);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(63, 65, 89);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.Padding = new Padding(10); 
                leftBorderBtn.BringToFront();                
                //Current Child Form Icon
                //iconCurrentChildForm.IconChar = currentBtn.IconChar;
                //iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(4, 5, 20);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblTitleChildForm.Text = childForm.Text;
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            //iconCurrentChildForm.IconChar = IconChar.Home;
            //iconCurrentChildForm.IconColor = Color.MediumPurple;
            //lblTitleChildForm.Text = "Home";
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new DashBoard());
        }       

        private void btnHotel_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new DasboardHotelForm());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new IneventarioForm());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new PuntoVentaForm());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width==200)
            {
                //Replace image 
                btnHome.Image = Image.FromFile(@"C:\Users\mokey\Desktop\HOSTAL\HostalSol\PRESENTATION\Images\m.PNG");
                this.btnHome.Size = new System.Drawing.Size(50, 50);

                // remove name of buttons
                panelMenu.Width = 50;
                btnDashboard.Text = "";
                btnHotel.Text = "";
                btnInventario.Text = "";
                btnpos.Text = "";

                // add tolptip button
                ToolTip toolTip1 = new ToolTip();
                toolTip1.SetToolTip(this.btnDashboard, "Dashboard");
                toolTip1.SetToolTip(this.btnHotel, "Administracion Hotelera");
                toolTip1.SetToolTip(this.btnInventario, "Administracion de Inventario");
                toolTip1.SetToolTip(this.btnpos, "Punto de venta");
            }
            else
            {
                panelMenu.Width = 200;
                //Replace image 
                btnHome.Image = Image.FromFile(@"C:\Users\mokey\Desktop\HOSTAL\HostalSol\PRESENTATION\Images\m.PNG");
                this.btnHome.Size = new System.Drawing.Size(200,200);

                btnDashboard.Text = "Dashboard";
                btnHotel.Text = "Admin Hotel";
                btnInventario.Text = "Admin Inventario";
                btnpos.Text = "Punto de venta";
            }
        }

        private void CambiarColores(string Tema)
        {
            Temas.ElegirTema(Tema);
            panelMenu.BackColor = Temas.panelMenu; 
            panelBuscar.BackColor = Temas.panelBuscar;
            panelDesktop.BackColor = Temas.panelDesktop;
            btnDashboard.ForeColor = Temas.fuenteA;

            foreach (IconButton item in panelMenu.Controls)
            {
                item.ForeColor = Temas.fuenteB;
                item.IconColor = Temas.fuenteB;
            }


        }

        private void Desktop_Load(object sender, EventArgs e)
        {
            //if (Properties.Settings.Default.Tema != "")
            //{
            //    CambiarColores(Properties.Settings.Default.Tema);

            //}
            //else
            //{
            //    CambiarColores("Claro");
            //}

        }

        //private void rjToggleButton1_CheckedChanged(object sender, EventArgs e)
        //{

        //    if (rjToggleButton1.Checked)
        //    {
        //        Properties.Settings.Default.Tema = "Claro";
        //        //Properties.Settings.Default.Tema = "Obscuro";
        //        Properties.Settings.Default.Save();
        //        CambiarColores(Properties.Settings.Default.Tema);
        //    }
        //    else
        //    {
        //        //Properties.Settings.Default.Tema = "Claro";
        //        Properties.Settings.Default.Tema = "Obscuro";
        //        Properties.Settings.Default.Save();
        //        CambiarColores(Properties.Settings.Default.Tema);
        //    }
           
        //}
    }
}
