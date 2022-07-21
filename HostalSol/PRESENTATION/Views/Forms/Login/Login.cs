using DOMAIN.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRESENTATION.Views.Forms.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            {
                if (txtuser.Text != "Username" /*&& txtuser.TextLength >2*/ )
                {
                    if (txtpassword.Text != "Password")
                    {
                        UsersModels user = new UsersModels();
                        var validLogin = user.LoginUser(txtuser.Texts, txtpassword.Texts);
                        if (validLogin == true)
                        {
                            Desktop desktop = new Desktop();
                           // MessageBox.Show("Bienvenido " + UserCache.FirstName + ", " + UserCache.LastName);
                            desktop.Show();
                            //this.Hide();
                            desktop.FormClosed += Logout;
                            this.Hide();
                        }
                        else
                        {
                            msgError("Incorrect username or password entered. \n   Please try again.");
                            txtpassword.Texts = "Password";
                            txtpassword.PasswordChar = false;
                            txtuser.Focus();
                        }
                    }
                    else msgError("Please enter password.");
                }
                else msgError("Please enter username.");
            }
        }
        public void msgError(string msg)
        {
            lblErrorMessage.Text = "     " + msg;
            lblErrorMessage.Visible = true;
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtpassword.Texts = "Password";
            txtpassword.PasswordChar = false;
            txtuser.Text = "Username";
            lblErrorMessage.Visible = false;
            this.Show();
        }
    }
}


