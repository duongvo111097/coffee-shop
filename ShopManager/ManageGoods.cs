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
    public partial class ManageGoods : Form
    {

        private string idStock;
        ControlGoods cs = new ControlGoods();
        string oldID;
        public ManageGoods()
        {
            InitializeComponent();
        }

        
        public void getIdStock(string id)
        {
            idStock = id;
        }
        private void ManageGoods_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = cs.ShowGoods(idStock);
            GoodsView.DataSource = dt;
            nameLabel.Text = idStock;
        }

        private void GoodsView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            oldID = GoodsView.Rows[e.RowIndex].Cells[0].Value.ToString();
            idText.Text = GoodsView.Rows[e.RowIndex].Cells[0].Value.ToString();
            nameText.Text = GoodsView.Rows[e.RowIndex].Cells[1].Value.ToString();
            quantityText.Text = GoodsView.Rows[e.RowIndex].Cells[2].Value.ToString();
            priceText.Text = GoodsView.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void insertButton_Click_1(object sender, EventArgs e)
        {
            if (idText.TextLength == 0 || nameText.TextLength == 0 || quantityText.TextLength == 0 || priceText.TextLength == 0)
            {
                statusLabel.Visible = true;
                statusLabel.Text = "You need filling all blank";
            }
            else
            {
                try
                {
                    cs.Insert(idText.Text, nameText.Text, quantityText.Text, int.Parse(priceText.Text), idStock);
                    ManageGoods_Load(sender, e);
                    statusLabel.Visible = false;
                }
                catch
                {
                    statusLabel.Visible = true;
                    statusLabel.Text = "Can't insert";
                }
            }
        }

        private void updateButton_Click_1(object sender, EventArgs e)
        {
            if (idText.TextLength == 0 || nameText.TextLength == 0 || quantityText.TextLength == 0 || priceText.TextLength == 0)
            {
                statusLabel.Visible = true;
                statusLabel.Text = "You need filling all blank";
            }
            else
            {
                try
                {
                    cs.Update(idText.Text, nameText.Text, quantityText.Text, int.Parse(priceText.Text), idStock, oldID);
                    ManageGoods_Load(sender, e);
                    statusLabel.Visible = false;
                }
                catch
                {
                    statusLabel.Visible = true;
                    statusLabel.Text = "Can't update";
                }
            }
        }

        private void delButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                cs.Delete(idText.Text);
                ManageGoods_Load(sender, e);
                statusLabel.Visible = false;
            }
            catch
            {
                statusLabel.Visible = true;
                statusLabel.Text = "Can't delete";
            }
        }

        private void clearButton_Click_1(object sender, EventArgs e)
        {
            idText.Clear();
            nameText.Clear();
            quantityText.Clear();
            priceText.Clear();
            statusLabel.Visible = false;
            idText.Focus();
        }
    }
}
