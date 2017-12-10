namespace ShopManager
{
    using System;
    using System.Data;
    using System.Drawing;
    using System.Windows.Forms;
    using BusinessLogic;
    public partial class ManageShop : Form
    {
        public ManageShop()
        {
            InitializeComponent();
            this.label2.Parent = this.pictureBox1;
            this.label3.Parent = this.pictureBox1;
            this.label4.Parent = this.pictureBox1;
            this.label5.Parent = this.pictureBox1;
            this.label2.BackColor = Color.Transparent;
            this.label3.BackColor = Color.Transparent;
            this.label4.BackColor = Color.Transparent;
            this.label5.BackColor = Color.Transparent;
            this.statusLabel.Parent = this.pictureBox1;
            this.statusLabel.BackColor = Color.Transparent;
            pictureBox1.Controls.Add(pictureBox2);
            this.pictureBox2.BackColor = Color.Transparent;
        }

        ControlShop cs = new ControlShop();
        string oldID;
        private void ManageShop_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = cs.ShowShop();
            ShopView.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(idshopText.TextLength == 0 || addressText.TextLength == 0 || nameshopText.TextLength == 0 || stockText.TextLength == 0)
            {
                statusLabel.Visible = true;
                statusLabel.Text = "You need filling all blank";
            }
            else
            {
                try
                {
                    cs.Insert(idshopText.Text, nameshopText.Text, addressText.Text, stockText.Text);
                    statusLabel.Visible = false;
                    ManageShop_Load(sender, e);
                }
                catch
                {
                    statusLabel.Visible = true;
                    statusLabel.Text = "ID already exists or Stock doesn't exists";
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (idshopText.TextLength == 0 || addressText.TextLength == 0 || nameshopText.TextLength == 0 || stockText.TextLength == 0)
            {
                statusLabel.Visible = true;
                statusLabel.Text = "You need filling all blank";
            }
            else
            {
                try
                {
                    cs.Update(oldID, idshopText.Text, nameshopText.Text, addressText.Text, stockText.Text);
                    statusLabel.Visible = false;
                    ManageShop_Load(sender, e);
                }
                catch
                {
                    statusLabel.Visible = true;
                    statusLabel.Text = "ID already exists or Stock doesn't exists";
                }
            }
        }

        private void ShopView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            oldID = ShopView.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.idshopText.Text = ShopView.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.nameshopText.Text = ShopView.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.addressText.Text = ShopView.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.stockText.Text = ShopView.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.idshopText.Clear();
            this.nameshopText.Clear();
            this.addressText.Clear();
            this.stockText.Clear();
            this.idshopText.Focus();
            statusLabel.Visible = false;
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            cs.Delete(this.idshopText.Text);
            ManageShop_Load(sender, e);
            statusLabel.Visible = false;
        }
    }
}
