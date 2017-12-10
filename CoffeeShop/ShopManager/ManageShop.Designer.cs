namespace ShopManager
{
    partial class ManageShop
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.ShopView = new System.Windows.Forms.DataGridView();
            this.idshop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameshop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shopaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idstock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.idshopText = new System.Windows.Forms.TextBox();
            this.addressText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameshopText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.stockText = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ShopView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Peru;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.SeaShell;
            this.addButton.Location = new System.Drawing.Point(25, 439);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(95, 34);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "INSERT";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.Peru;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.SeaShell;
            this.updateButton.Location = new System.Drawing.Point(346, 439);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(95, 34);
            this.updateButton.TabIndex = 12;
            this.updateButton.Text = "UPDATE";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // delButton
            // 
            this.delButton.BackColor = System.Drawing.Color.Peru;
            this.delButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delButton.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delButton.ForeColor = System.Drawing.Color.SeaShell;
            this.delButton.Location = new System.Drawing.Point(346, 479);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(95, 34);
            this.delButton.TabIndex = 13;
            this.delButton.Text = "DELETE";
            this.delButton.UseVisualStyleBackColor = false;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Peru;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.SeaShell;
            this.clearButton.Location = new System.Drawing.Point(25, 479);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(95, 34);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.Red;
            this.statusLabel.Location = new System.Drawing.Point(118, 379);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(40, 15);
            this.statusLabel.TabIndex = 16;
            this.statusLabel.Text = "status";
            this.statusLabel.Visible = false;
            // 
            // ShopView
            // 
            this.ShopView.AllowUserToAddRows = false;
            this.ShopView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ShopView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShopView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idshop,
            this.nameshop,
            this.shopaddress,
            this.idstock});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ShopView.DefaultCellStyle = dataGridViewCellStyle1;
            this.ShopView.Location = new System.Drawing.Point(462, -1);
            this.ShopView.Name = "ShopView";
            this.ShopView.Size = new System.Drawing.Size(386, 527);
            this.ShopView.TabIndex = 0;
            this.ShopView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShopView_RowEnter);
            // 
            // idshop
            // 
            this.idshop.DataPropertyName = "shop_id";
            this.idshop.HeaderText = "ID";
            this.idshop.Name = "idshop";
            this.idshop.Width = 50;
            // 
            // nameshop
            // 
            this.nameshop.DataPropertyName = "shop_name";
            this.nameshop.HeaderText = "Name";
            this.nameshop.Name = "nameshop";
            // 
            // shopaddress
            // 
            this.shopaddress.DataPropertyName = "shop_address";
            this.shopaddress.HeaderText = "Address";
            this.shopaddress.Name = "shopaddress";
            // 
            // idstock
            // 
            this.idstock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idstock.DataPropertyName = "stock_id";
            this.idstock.HeaderText = "Stock ID";
            this.idstock.Name = "idstock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Sienna;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label2.Location = new System.Drawing.Point(109, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // idshopText
            // 
            this.idshopText.BackColor = System.Drawing.SystemColors.Window;
            this.idshopText.Location = new System.Drawing.Point(181, 108);
            this.idshopText.Name = "idshopText";
            this.idshopText.Size = new System.Drawing.Size(100, 20);
            this.idshopText.TabIndex = 4;
            // 
            // addressText
            // 
            this.addressText.Location = new System.Drawing.Point(181, 181);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(100, 20);
            this.addressText.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Sienna;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label4.Location = new System.Drawing.Point(109, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Sienna;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label3.Location = new System.Drawing.Point(109, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // nameshopText
            // 
            this.nameshopText.Location = new System.Drawing.Point(181, 252);
            this.nameshopText.Name = "nameshopText";
            this.nameshopText.Size = new System.Drawing.Size(100, 20);
            this.nameshopText.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Sienna;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label5.Location = new System.Drawing.Point(109, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Stock ID";
            // 
            // stockText
            // 
            this.stockText.Location = new System.Drawing.Point(181, 321);
            this.stockText.Name = "stockText";
            this.stockText.Size = new System.Drawing.Size(100, 20);
            this.stockText.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ShopManager.Properties.Resources.cafe;
            this.pictureBox2.Location = new System.Drawing.Point(346, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(95, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ShopManager.Properties.Resources._98775_OLDLDC_182;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(466, 527);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // ManageShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(847, 525);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ShopView);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.stockText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addressText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameshopText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idshopText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageShop";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageShop";
            this.Load += new System.EventHandler(this.ManageShop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShopView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.DataGridView ShopView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idshop;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameshop;
        private System.Windows.Forms.DataGridViewTextBoxColumn shopaddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idshopText;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameshopText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox stockText;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}