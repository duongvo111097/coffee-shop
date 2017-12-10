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
    public partial class ManageStaff : Form
    {
        public ManageStaff()
        {
            InitializeComponent();
        }

        ControlStaff cs = new ControlStaff();
        string oldID;

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = cs.ShowStaff();
            StaffView.DataSource = dt;
            posBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genderBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (nameText.TextLength == 0 || phoneText.TextLength == 0 || passText.TextLength == 0
                || emailText.TextLength == 0 || idenText.TextLength == 0 || idshopText.TextLength == 0)
            {
                statusLabel.Text = "You need filling all blank";
                statusLabel.Visible = true;
            }
            else
            {
                try
                {
                    cs.InsertStaff(idText.Text, nameText.Text, genderBox.Text, phoneText.Text, passText.Text, posBox.Text, emailText.Text, idenText.Text, idshopText.Text);
                    statusLabel.Visible = false;
                    Form1_Load(sender, e);
                }
                catch
                {
                    statusLabel.Text = "ID already exists or Shop doesn't exists";
                    statusLabel.Visible = true;
                }
            }
        }

        private void StaffView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            oldID = StaffView.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.nameText.Text = StaffView.Rows[e.RowIndex].Cells[6].Value.ToString();
            this.idText.Text = StaffView.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.passText.Text = StaffView.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.genderBox.Text = StaffView.Rows[e.RowIndex].Cells[8].Value.ToString();
            this.idenText.Text = StaffView.Rows[e.RowIndex].Cells[5].Value.ToString();
            this.emailText.Text = StaffView.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.phoneText.Text = StaffView.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.posBox.Text = StaffView.Rows[e.RowIndex].Cells[4].Value.ToString();
            this.idshopText.Text = StaffView.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (nameText.TextLength == 0 || phoneText.TextLength == 0 || passText.TextLength == 0
                || emailText.TextLength == 0 || idenText.TextLength == 0 || idshopText.TextLength == 0)
            {
                statusLabel.Text = "You need filling all blank";
                statusLabel.Visible = true;
            }
            else
            {
                try
                {
                    statusLabel.Visible = false;
                    cs.UpdateStaff(oldID, this.idText.Text, this.nameText.Text, this.genderBox.Text, this.phoneText.Text, this.passText.Text, this.posBox.Text,
                        this.emailText.Text, idenText.Text, idshopText.Text);
                    Form1_Load(sender, e);
                }
                catch
                {
                    statusLabel.Text = "ID already exists or Shop doesn't exists";
                    statusLabel.Visible = true;
                }
            } 
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            cs.DeleteStaff(this.idText.Text);
            Form1_Load(sender, e);
            statusLabel.Visible = false;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            statusLabel.Visible = false;
            this.nameText.Clear();
            this.idText.Clear();
            this.passText.Clear();
            this.genderBox.SelectedIndex = -1;
            this.idshopText.Clear();
            this.idenText.Clear();
            this.emailText.Clear();
            this.phoneText.Clear();
            this.posBox.SelectedIndex = -1;
            this.idText.Focus();
        }
    }
}
