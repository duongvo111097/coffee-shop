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

namespace ShopManager
{
    public partial class ManageMenu : Form
    {
        ControlMenu cm = new ControlMenu();
        private string oldID;
        public ManageMenu()
        {
            InitializeComponent();
        }

        private void ManageMenu_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = cm.showMenu();
            menuView.DataSource = dt;
        }

        private void menuView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            oldID = menuView.Rows[e.RowIndex].Cells[0].Value.ToString();
            idText.Text = menuView.Rows[e.RowIndex].Cells[0].Value.ToString();
            nameText.Text = menuView.Rows[e.RowIndex].Cells[2].Value.ToString();
            priceText.Text = menuView.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void insertButton_Click_1(object sender, EventArgs e)
        {
            if (idText.TextLength == 0 || nameText.TextLength == 0 || priceText.TextLength == 0)
            {
                statusLabel.Text = "You need filling all blank";
                statusLabel.Visible = true;
            }
            else
            {
                try
                {
                    cm.Insert(idText.Text, nameText.Text, int.Parse(priceText.Text));
                    ManageMenu_Load(sender, e);
                    statusLabel.Visible = false;
                }
                catch
                {
                    statusLabel.Text = "ID already exist";
                    statusLabel.Visible = true;
                }
            }
        }

        private void updateButton_Click_1(object sender, EventArgs e)
        {
            if (idText.TextLength == 0 || nameText.TextLength == 0 || priceText.TextLength == 0)
            {
                statusLabel.Text = "You need filling all blank";
                statusLabel.Visible = true;
            }
            else
            {
                try
                {
                    cm.Update(idText.Text, nameText.Text, int.Parse(priceText.Text), oldID);
                    ManageMenu_Load(sender, e);
                    statusLabel.Visible = false;
                }
                catch
                {
                    statusLabel.Text = "ID already exist";
                    statusLabel.Visible = true;
                }
            }
        }

        private void delButton_Click_1(object sender, EventArgs e)
        {
            cm.Delete(idText.Text);
            ManageMenu_Load(sender, e);
            statusLabel.Visible = false;
        }

        private void clearButton_Click_1(object sender, EventArgs e)
        {
            idText.Clear();
            nameText.Clear();
            priceText.Clear();
            idText.Focus();
            statusLabel.Visible = false;
        }
    }
}
