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
    public partial class ManageStock : Form
    {
        public ManageStock()
        {
            InitializeComponent();
        }

        ControlStock cs = new ControlStock();
        public string oldID;
        public string idStock;
        ManageGoods mg = new ManageGoods();
        
        private void ManageStock_Load(object sender, EventArgs e)
        {
            
            DataTable dt = new DataTable();
            dt = cs.ShowStock();
            StockView.DataSource = dt;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if(idText.TextLength == 0 || addressText.TextLength == 0)
            {
                statusLabel.Visible = true;
                statusLabel.Text = "You need filling all blank";
                
            }
            else
            {
                try
                {   
                    cs.Update(oldID, idText.Text, addressText.Text);
                    ManageStock_Load(sender, e);
                    statusLabel.Visible = false;
                }
                catch
                {
                    statusLabel.Visible = true;
                    statusLabel.Text = "ID already exist";
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(idText.TextLength == 0 || addressText.TextLength == 0)
            {
                statusLabel.Visible = true;
                statusLabel.Text = "You need filling all blank";
            }
            else
            {
                try
                {
                    cs.Insert(idText.Text, addressText.Text);
                    ManageStock_Load(sender, e);
                    statusLabel.Visible = false;
                }
                catch
                {
                    statusLabel.Visible = true;
                    statusLabel.Text = "ID already exist";
                }
            }
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            try
            {
                cs.Delete(idText.Text);
                ManageStock_Load(sender, e);
                statusLabel.Visible = false;
            }
            catch
            {
                statusLabel.Visible = true;
                statusLabel.Text = "Can't delete";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            idText.Clear();
            addressText.Clear();
            idText.Focus();
        }

        private void StockView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            oldID = StockView.Rows[e.RowIndex].Cells[0].Value.ToString();
            idText.Text = StockView.Rows[e.RowIndex].Cells[0].Value.ToString();
            addressText.Text = StockView.Rows[e.RowIndex].Cells[1].Value.ToString();
            idStock = StockView.Rows[e.RowIndex].Cells[0].Value.ToString();
            
        }

        private void goodsButton_Click(object sender, EventArgs e)
        {
            mg.getIdStock(oldID);
            this.Hide();
            mg.ShowDialog();
            this.Show();
        }
    }
}
