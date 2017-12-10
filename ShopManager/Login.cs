using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using System.Data.SqlClient;

namespace ShopManager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            idloginText.CharacterCasing = CharacterCasing.Upper;
            idLabel.Parent = pictureBox1;
            idLabel.BackColor = Color.Transparent;
            passLabel.Parent = pictureBox1;
            passLabel.BackColor = Color.Transparent;
            statusLogin.Parent = pictureBox1;
            statusLogin.BackColor = Color.Transparent;
        }

        private string position;
        LoginManager lm = new LoginManager();
        
        
        private void loginButton_Click(object sender, EventArgs e)
        {
            
            if (this.idloginText.TextLength == 0 || this.passloginText.TextLength == 0)
            {
                statusLogin.Visible = true;
                this.statusLogin.ForeColor = Color.Red;
                this.statusLogin.Text = "Enter your id and password";
            }
            else
            {
                DataTable dt = new DataTable();
                dt = lm.CheckLogin(this.idloginText.Text, this.passloginText.Text);
                if(dt.Rows.Count > 0)
                {
                    idLabel.Visible = false;
                    passLabel.Visible = false;
                    idloginText.Visible = false;
                    passloginText.Visible = false;
                    loginButton.Visible = false;
                    statusLogin.Visible = false;
                    logoutButton.Visible = true;
                    sellButton.Visible = true;
                    position = dt.Rows[0][2].ToString();
                    if (dt.Rows[0][2].ToString() == "Supervisor" || dt.Rows[0][2].ToString() == "Owner")
                    {
                        staffButton.Visible = true;
                        shopButton.Visible = true;
                        stockButton.Visible = true;
                    }
                    else
                    {
                        staffButton.Visible = false;
                        shopButton.Visible = false;
                        stockButton.Visible = false;
                    }
                }
                else
                {
                    statusLogin.Visible = true;
                    this.statusLogin.ForeColor = Color.Red;
                    this.statusLogin.Text = "Account doesn't exists";
                }
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            idLabel.Visible = true;
            passLabel.Visible = true;
            idloginText.Visible = true;
            passloginText.Visible = true;
            loginButton.Visible = true;
            statusLogin.Visible = false;
            logoutButton.Visible = false;
            staffButton.Visible = false;
            shopButton.Visible = false;
            stockButton.Visible = false;
            sellButton.Visible = false;
            passloginText.Clear();
            passloginText.Focus();
        }

        private void shopButton_Click(object sender, EventArgs e)
        {
            ManageShop ms = new ManageShop();
            this.Hide();
            ms.ShowDialog();
            this.Show();
        }

        private void staffButton_Click(object sender, EventArgs e)
        {
            ManageStaff ms = new ManageStaff();
            this.Hide();
            ms.ShowDialog();
            this.Show();
        }

        private void stockButton_Click(object sender, EventArgs e)
        {
            ManageStock ms = new ManageStock();
            this.Hide();
            ms.ShowDialog();
            this.Show();
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            ManageSell ms = new ManageSell();
            ManageShop mshop = new ManageShop();
            ms.getPositionStaff(position);
            this.Hide();
            ms.getIdStaff(idloginText.Text);
            ms.ShowDialog();
            this.Show();
        }
    }
}
