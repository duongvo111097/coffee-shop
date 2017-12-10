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
            this.menuGrid = new System.Windows.Forms.DataGridView();
            this.drinks_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drinks_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drinks_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectList = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.sellButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.totalLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.quantityPanel = new System.Windows.Forms.Panel();
            this.enterButton = new System.Windows.Forms.Button();
            this.quantityText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idShopText = new System.Windows.Forms.TextBox();
            this.enterShopButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.menuGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.quantityPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuGrid
            // 
            this.menuGrid.AllowUserToAddRows = false;
            this.menuGrid.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.menuGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.drinks_id,
            this.drinks_name,
            this.drinks_price});
            this.menuGrid.GridColor = System.Drawing.SystemColors.Control;
            this.menuGrid.Location = new System.Drawing.Point(520, 81);
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
            this.selectList.Location = new System.Drawing.Point(26, 59);
            this.selectList.Name = "selectList";
            this.selectList.Size = new System.Drawing.Size(305, 400);
            this.selectList.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.Info;
            this.addButton.Location = new System.Drawing.Point(378, 141);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(104, 42);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "SELECT";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Visible = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.SystemColors.Info;
            this.removeButton.Location = new System.Drawing.Point(378, 238);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(104, 42);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "REMOVE";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Visible = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // sellButton
            // 
            this.sellButton.BackColor = System.Drawing.SystemColors.Info;
            this.sellButton.Location = new System.Drawing.Point(378, 335);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(104, 42);
            this.sellButton.TabIndex = 5;
            this.sellButton.Text = "SELL";
            this.sellButton.UseVisualStyleBackColor = false;
            this.sellButton.Visible = false;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.totalLabel);
            this.panel1.Controls.Add(this.label1);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Total";
            // 
            // quantityPanel
            // 
            this.quantityPanel.BackColor = System.Drawing.Color.Lavender;
            this.quantityPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantityPanel.Controls.Add(this.enterButton);
            this.quantityPanel.Controls.Add(this.quantityText);
            this.quantityPanel.Controls.Add(this.label2);
            this.quantityPanel.Location = new System.Drawing.Point(296, 218);
            this.quantityPanel.Name = "quantityPanel";
            this.quantityPanel.Size = new System.Drawing.Size(258, 135);
            this.quantityPanel.TabIndex = 7;
            this.quantityPanel.Visible = false;
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.SystemColors.Info;
            this.enterButton.Location = new System.Drawing.Point(90, 87);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(88, 32);
            this.enterButton.TabIndex = 8;
            this.enterButton.Text = "ENTER";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // quantityText
            // 
            this.quantityText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityText.Location = new System.Drawing.Point(143, 34);
            this.quantityText.Name = "quantityText";
            this.quantityText.Size = new System.Drawing.Size(76, 26);
            this.quantityText.TabIndex = 1;
            this.quantityText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityText_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quantity";
            // 
            // idShopText
            // 
            this.idShopText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idShopText.Location = new System.Drawing.Point(64, 22);
            this.idShopText.Name = "idShopText";
            this.idShopText.Size = new System.Drawing.Size(100, 22);
            this.idShopText.TabIndex = 8;
            // 
            // enterShopButton
            // 
            this.enterShopButton.BackColor = System.Drawing.SystemColors.Info;
            this.enterShopButton.Location = new System.Drawing.Point(217, 17);
            this.enterShopButton.Name = "enterShopButton";
            this.enterShopButton.Size = new System.Drawing.Size(88, 32);
            this.enterShopButton.TabIndex = 9;
            this.enterShopButton.Text = "ENTER";
            this.enterShopButton.UseVisualStyleBackColor = false;
            this.enterShopButton.Click += new System.EventHandler(this.enterShopButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.SystemColors.Info;
            this.menuButton.Location = new System.Drawing.Point(378, 423);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(104, 42);
            this.menuButton.TabIndex = 10;
            this.menuButton.Text = "CHANGE MENU";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Visible = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // ManageSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(936, 544);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.enterShopButton);
            this.Controls.Add(this.idShopText);
            this.Controls.Add(this.quantityPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.selectList);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.menuGrid);
            this.Controls.Add(this.addButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ManageSell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ManageSell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.quantityPanel.ResumeLayout(false);
            this.quantityPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView menuGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn drinks_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn drinks_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn drinks_price;
        private System.Windows.Forms.ListBox selectList;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel quantityPanel;
        private System.Windows.Forms.TextBox quantityText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.TextBox idShopText;
        private System.Windows.Forms.Button enterShopButton;
        private System.Windows.Forms.Button menuButton;
    }
}