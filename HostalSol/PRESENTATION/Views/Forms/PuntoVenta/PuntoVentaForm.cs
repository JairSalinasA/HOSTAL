using FontAwesome.Sharp;
using PRESENTATION.Views.Forms.PuntoVenta.HTRABAJOS;
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
    public partial class PuntoVentaForm : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public PuntoVentaForm()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            //leftBorderBtn.Size = new Size(7,50);
            //panelM.Controls.Add(leftBorderBtn);
        }
        private struct RGBColors
        {
            //public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color1 = Color.FromArgb(241, 202, 136);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(249, 118, 176);
            public static Color color8 = Color.FromArgb(253, 138, 114);
        }
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
                leftBorderBtn.Location = new Point(0, currentBtn.Location.X);
                leftBorderBtn.Visible = true;
                leftBorderBtn.Padding = new Padding(1);
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
            panelDsktop.Controls.Add(childForm);
            panelDsktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblTitleChildForm.Text = childForm.Text;
        }
         
        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new CajaForms());
            leftBorderBtn.Visible = false;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new ProductosForms());
            leftBorderBtn.Visible = false;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new ProductosForms());
            leftBorderBtn.Visible = false;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new ProductosForms());
            leftBorderBtn.Visible = false;
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new ProductosForms());
            leftBorderBtn.Visible = false;
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new ProductosForms());
            leftBorderBtn.Visible = false;
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new ProductosForms());
            leftBorderBtn.Visible = false;
        }
    }
}
