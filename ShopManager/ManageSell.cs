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
    public partial class ManageSell : Form
    {
        private string id;
        private string name;
        private int price = 0;
        private int total = 0;
        private int quantity = 0;
        private string text = " ";
        private string idStaff;
        private int count = 0;
        private int invoice_id;
        private string positionStaff;
        public ManageSell()
        {
            InitializeComponent();
        }
        ControlSell cs = new ControlSell();

        private void ManageSell_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = cs.ShowMenu();
            menuGrid.DataSource = dt;
           
        }

        private void menuGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            id = menuGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            name = menuGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            price = int.Parse(menuGrid.Rows[e.RowIndex].Cells[2].Value.ToString());
            if (positionStaff == "Supervisor" || positionStaff == "Owner")
            {
                menuButton.Visible = true;
            }
            
        }

        private void quantityText_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        public void getIdStaff(string id)
        {
            idStaff = id;
        }

        public void getPositionStaff(string position)
        {
            positionStaff = position;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void quantityButton_Click(object sender, EventArgs e)
        {
            try
            {
                quantity = int.Parse(quantityText.Text);
            }
            catch
            {

            }

            if (quantity != 0)
            {
                selectList.Items.Add(id + "        " + name + "        " + quantity + "        " + price);
            }
            quantityPanel.Visible = false;
            quantityText.Clear();
            total = total + price * quantity;
            totalLabel.Text = total.ToString();
            ManageSell_Load(sender, e);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if (id != " ")
            {
                quantityPanel.Visible = true;
            }
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (idShopText.TextLength != 0)
            {
                DataTable dt = new DataTable();
                dt = cs.SelectShop(idShopText.Text);
                if (dt.Rows.Count > 0)
                {
                    selectButton.Visible = true;
                    removeButton.Visible = true;
                    sellButton.Visible = true;
                }
            }
        }

        private void removeButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                text = selectList.GetItemText(selectList.SelectedItem).ToString();
                string[] split = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int removeQuantity = int.Parse(split[2]);
                int removePrice = int.Parse(split[3]);
                total = total - removePrice * removeQuantity;
                totalLabel.Text = total.ToString();
                selectList.Items.Remove(selectList.SelectedItem);
                ManageSell_Load(sender, e);
            }
            catch
            {

            }
        }

        private void sellButton_Click_1(object sender, EventArgs e)
        {
            foreach (object listItem in selectList.Items)
            {
                DataTable dt = new DataTable();
                dt = cs.AutoId();
                invoice_id = int.Parse(dt.Rows[0][0].ToString()) + 1;
                MessageBox.Show("Sell success");
                string text = listItem.ToString();
                string[] split = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string id = split[0];
                int drink_quantity = int.Parse(split[2]);
                int drink_price = int.Parse(split[3]);
                int total_bill = drink_price * drink_quantity;
                cs.Sell(invoice_id, total_bill, drink_quantity, idStaff, idShopText.Text, id);
                count++;
            }
        }

        private void menuButton_Click_1(object sender, EventArgs e)
        {
            ManageMenu mm = new ManageMenu();
            this.Hide();
            mm.ShowDialog();
            this.Show();
            ManageSell_Load(sender, e);
        }
    }
}
