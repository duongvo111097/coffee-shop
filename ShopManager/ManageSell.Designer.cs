namespace ShopManager
{
    partial class ManageSell
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageSell));
            this.menuGrid = new System.Windows.Forms.DataGridView();
            this.drinks_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drinks_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drinks_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectList = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.totalLabel = new System.Windows.Forms.Label();
            this.quantityPanel = new System.Windows.Forms.Panel();
            this.quantityText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idShopText = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.quantityButton = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.enterButton = new DevExpress.XtraEditors.SimpleButton();
            this.selectButton = new DevExpress.XtraEditors.SimpleButton();
            this.removeButton = new DevExpress.XtraEditors.SimpleButton();
            this.sellButton = new DevExpress.XtraEditors.SimpleButton();
            this.menuButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.menuGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.quantityPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuGrid
            // 
            this.menuGrid.AllowUserToAddRows = false;
            this.menuGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.menuGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.drinks_id,
            this.drinks_name,
            this.drinks_price});
            this.menuGrid.GridColor = System.Drawing.SystemColors.Control;
            this.menuGrid.Location = new System.Drawing.Point(30, 114);
            this.menuGrid.Name = "menuGrid";
            this.menuGrid.Size = new System.Drawing.Size(384, 398);
            this.menuGrid.TabIndex = 1;
            this.menuGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.menuGrid_RowEnter);
            // 
            // drinks_id
            // 
            this.drinks_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.drinks_id.DataPropertyName = "drinks_id";
            this.drinks_id.HeaderText = "ID";
            this.drinks_id.Name = "drinks_id";
            // 
            // drinks_name
            // 
            this.drinks_name.DataPropertyName = "drinks_name";
            this.drinks_name.HeaderText = "Name";
            this.drinks_name.Name = "drinks_name";
            this.drinks_name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.drinks_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // drinks_price
            // 
            this.drinks_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.drinks_price.DataPropertyName = "drinks_price";
            this.drinks_price.HeaderText = "Price";
            this.drinks_price.Name = "drinks_price";
            // 
            // selectList
            // 
            this.selectList.BackColor = System.Drawing.SystemColors.Window;
            this.selectList.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.selectList.FormattingEnabled = true;
            this.selectList.ItemHeight = 18;
            this.selectList.Location = new System.Drawing.Point(25, 118);
            this.selectList.Name = "selectList";
            this.selectList.Size = new System.Drawing.Size(305, 346);
            this.selectList.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.totalLabel);
            this.panel1.Location = new System.Drawing.Point(26, 479);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 43);
            this.panel1.TabIndex = 6;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(200, 13);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totalLabel.Size = new System.Drawing.Size(18, 20);
            this.totalLabel.TabIndex = 8;
            this.totalLabel.Text = "0";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // quantityPanel
            // 
            this.quantityPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.quantityPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantityPanel.Controls.Add(this.quantityButton);
            this.quantityPanel.Controls.Add(this.quantityText);
            this.quantityPanel.Controls.Add(this.label2);
            this.quantityPanel.Location = new System.Drawing.Point(580, 254);
            this.quantityPanel.Name = "quantityPanel";
            this.quantityPanel.Size = new System.Drawing.Size(272, 71);
            this.quantityPanel.TabIndex = 7;
            this.quantityPanel.Visible = false;
            // 
            // quantityText
            // 
            this.quantityText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityText.Location = new System.Drawing.Point(81, 21);
            this.quantityText.Name = "quantityText";
            this.quantityText.Size = new System.Drawing.Size(82, 22);
            this.quantityText.TabIndex = 1;
            this.quantityText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityText_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quantity";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // idShopText
            // 
            this.idShopText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idShopText.Location = new System.Drawing.Point(378, 21);
            this.idShopText.Name = "idShopText";
            this.idShopText.Size = new System.Drawing.Size(104, 22);
            this.idShopText.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.menuGrid);
            this.panel2.Location = new System.Drawing.Point(500, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 541);
            this.panel2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(227, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Menu";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.selectList);
            this.panel3.Location = new System.Drawing.Point(1, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(362, 541);
            this.panel3.TabIndex = 12;
            // 
            // quantityButton
            // 
            this.quantityButton.Image = ((System.Drawing.Image)(resources.GetObject("quantityButton.Image")));
            this.quantityButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.quantityButton.Location = new System.Drawing.Point(181, 12);
            this.quantityButton.Name = "quantityButton";
            this.quantityButton.Size = new System.Drawing.Size(76, 42);
            this.quantityButton.TabIndex = 9;
            this.quantityButton.Click += new System.EventHandler(this.quantityButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ShopManager.Properties.Resources.money;
            this.pictureBox2.Location = new System.Drawing.Point(3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(78, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ShopManager.Properties.Resources.restaurant_menu__1_;
            this.pictureBox1.Location = new System.Drawing.Point(87, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ShopManager.Properties.Resources.coffee_machine;
            this.pictureBox3.Location = new System.Drawing.Point(54, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(99, 83);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selected";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(389, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Shop ID";
            // 
            // enterButton
            // 
            this.enterButton.Image = ((System.Drawing.Image)(resources.GetObject("enterButton.Image")));
            this.enterButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.enterButton.Location = new System.Drawing.Point(378, 91);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(104, 44);
            this.enterButton.TabIndex = 14;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // selectButton
            // 
            this.selectButton.Image = ((System.Drawing.Image)(resources.GetObject("selectButton.Image")));
            this.selectButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.selectButton.Location = new System.Drawing.Point(378, 189);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(104, 44);
            this.selectButton.TabIndex = 15;
            this.selectButton.Text = "SELECT";
            this.selectButton.Visible = false;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Image = ((System.Drawing.Image)(resources.GetObject("removeButton.Image")));
            this.removeButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.removeButton.Location = new System.Drawing.Point(378, 254);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(104, 44);
            this.removeButton.TabIndex = 16;
            this.removeButton.Text = "REMOVE";
            this.removeButton.Visible = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click_1);
            // 
            // sellButton
            // 
            this.sellButton.Image = ((System.Drawing.Image)(resources.GetObject("sellButton.Image")));
            this.sellButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.sellButton.Location = new System.Drawing.Point(378, 317);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(104, 44);
            this.sellButton.TabIndex = 17;
            this.sellButton.Text = "SELL";
            this.sellButton.Visible = false;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click_1);
            // 
            // menuButton
            // 
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.menuButton.Location = new System.Drawing.Point(378, 451);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(104, 62);
            this.menuButton.TabIndex = 18;
            this.menuButton.Text = "CHANGE MENU";
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click_1);
            // 
            // ManageSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(936, 544);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idShopText);
            this.Controls.Add(this.quantityPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ManageSell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ManageSell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.quantityPanel.ResumeLayout(false);
            this.quantityPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView menuGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn drinks_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn drinks_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn drinks_price;
        private System.Windows.Forms.ListBox selectList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Panel quantityPanel;
        private System.Windows.Forms.TextBox quantityText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idShopText;
        private DevExpress.XtraEditors.SimpleButton quantityButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton enterButton;
        private DevExpress.XtraEditors.SimpleButton selectButton;
        private DevExpress.XtraEditors.SimpleButton removeButton;
        private DevExpress.XtraEditors.SimpleButton sellButton;
        private DevExpress.XtraEditors.SimpleButton menuButton;
    }
}