namespace ShopManager
{
    partial class ManageGoods
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
            this.GoodsView = new System.Windows.Forms.DataGridView();
            this.goods_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameLabel = new System.Windows.Forms.Label();
            this.insertButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.idShopLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.quantityText = new System.Windows.Forms.TextBox();
            this.priceText = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GoodsView)).BeginInit();
            this.SuspendLayout();
            // 
            // GoodsView
            // 
            this.GoodsView.AllowDrop = true;
            this.GoodsView.AllowUserToAddRows = false;
            this.GoodsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GoodsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goods_id,
            this.goods_name,
            this.quantity,
            this.goods_price});
            this.GoodsView.Location = new System.Drawing.Point(431, 26);
            this.GoodsView.Name = "GoodsView";
            this.GoodsView.Size = new System.Drawing.Size(568, 412);
            this.GoodsView.TabIndex = 0;
            this.GoodsView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GoodsView_RowEnter);
            // 
            // goods_id
            // 
            this.goods_id.DataPropertyName = "goods_id";
            this.goods_id.HeaderText = "ID";
            this.goods_id.Name = "goods_id";
            // 
            // goods_name
            // 
            this.goods_name.DataPropertyName = "goods_name";
            this.goods_name.HeaderText = "Name";
            this.goods_name.Name = "goods_name";
            this.goods_name.Width = 150;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.Width = 150;
            // 
            // goods_price
            // 
            this.goods_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.goods_price.DataPropertyName = "goods_price";
            this.goods_price.HeaderText = "Price Unit";
            this.goods_price.Name = "goods_price";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(120, 35);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(58, 21);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Stock:";
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(68, 305);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(89, 38);
            this.insertButton.TabIndex = 2;
            this.insertButton.Text = "INSERT";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(268, 305);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(89, 38);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "UPDATE";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(68, 370);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(89, 38);
            this.delButton.TabIndex = 6;
            this.delButton.Text = "DELETE ";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(268, 370);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(89, 38);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // idShopLabel
            // 
            this.idShopLabel.AutoSize = true;
            this.idShopLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idShopLabel.Location = new System.Drawing.Point(184, 35);
            this.idShopLabel.Name = "idShopLabel";
            this.idShopLabel.Size = new System.Drawing.Size(83, 21);
            this.idShopLabel.TabIndex = 7;
            this.idShopLabel.Text = "ID SHOP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Price";
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(168, 90);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(189, 20);
            this.idText.TabIndex = 12;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(168, 134);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(189, 20);
            this.nameText.TabIndex = 13;
            // 
            // quantityText
            // 
            this.quantityText.Location = new System.Drawing.Point(168, 180);
            this.quantityText.Name = "quantityText";
            this.quantityText.Size = new System.Drawing.Size(189, 20);
            this.quantityText.TabIndex = 14;
            // 
            // priceText
            // 
            this.priceText.Location = new System.Drawing.Point(168, 227);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(189, 20);
            this.priceText.TabIndex = 15;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.Red;
            this.statusLabel.Location = new System.Drawing.Point(98, 269);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(35, 13);
            this.statusLabel.TabIndex = 16;
            this.statusLabel.Text = "status";
            this.statusLabel.Visible = false;
            // 
            // ManageGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 459);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.quantityText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idShopLabel);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.GoodsView);
            this.Name = "ManageGoods";
            this.Text = "ManageGoods";
            this.Load += new System.EventHandler(this.ManageGoods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GoodsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GoodsView;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_price;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label idShopLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox quantityText;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.Label statusLabel;
    }
}