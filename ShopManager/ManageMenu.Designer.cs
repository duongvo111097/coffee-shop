namespace ShopManager
{
    partial class ManageMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageMenu));
            this.label3 = new System.Windows.Forms.Label();
            this.priceText = new System.Windows.Forms.TextBox();
            this.menuView = new System.Windows.Forms.DataGridView();
            this.drinks_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drinks_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drinks_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idText = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.insertButton = new DevExpress.XtraEditors.SimpleButton();
            this.updateButton = new DevExpress.XtraEditors.SimpleButton();
            this.clearButton = new DevExpress.XtraEditors.SimpleButton();
            this.delButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.menuView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // priceText
            // 
            this.priceText.Location = new System.Drawing.Point(116, 228);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(123, 20);
            this.priceText.TabIndex = 4;
            // 
            // menuView
            // 
            this.menuView.AllowUserToAddRows = false;
            this.menuView.AllowUserToDeleteRows = false;
            this.menuView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.menuView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.drinks_id,
            this.drinks_name,
            this.drinks_price});
            this.menuView.Location = new System.Drawing.Point(287, 78);
            this.menuView.Name = "menuView";
            this.menuView.Size = new System.Drawing.Size(307, 379);
            this.menuView.TabIndex = 5;
            this.menuView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.menuView_RowEnter);
            // 
            // drinks_id
            // 
            this.drinks_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.drinks_id.DataPropertyName = "drinks_id";
            this.drinks_id.HeaderText = "ID";
            this.drinks_id.Name = "drinks_id";
            // 
            // drinks_name
            // 
            this.drinks_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.drinks_name.DataPropertyName = "drinks_name";
            this.drinks_name.HeaderText = "Name";
            this.drinks_name.Name = "drinks_name";
            // 
            // drinks_price
            // 
            this.drinks_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.drinks_price.DataPropertyName = "drinks_price";
            this.drinks_price.HeaderText = "Price";
            this.drinks_price.Name = "drinks_price";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(116, 175);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(123, 20);
            this.nameText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID";
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(116, 124);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(123, 20);
            this.idText.TabIndex = 6;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.ForeColor = System.Drawing.Color.Red;
            this.statusLabel.Location = new System.Drawing.Point(41, 285);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(35, 13);
            this.statusLabel.TabIndex = 11;
            this.statusLabel.Text = "status";
            this.statusLabel.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(594, 80);
            this.panel2.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ShopManager.Properties.Resources.menu;
            this.pictureBox1.Location = new System.Drawing.Point(158, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(258, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 43);
            this.label4.TabIndex = 6;
            this.label4.Text = "My Menu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.delButton);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.updateButton);
            this.panel1.Controls.Add(this.insertButton);
            this.panel1.ForeColor = System.Drawing.Color.Coral;
            this.panel1.Location = new System.Drawing.Point(0, 341);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 116);
            this.panel1.TabIndex = 13;
            // 
            // insertButton
            // 
            this.insertButton.Image = ((System.Drawing.Image)(resources.GetObject("insertButton.Image")));
            this.insertButton.Location = new System.Drawing.Point(17, 13);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(97, 42);
            this.insertButton.TabIndex = 0;
            this.insertButton.Text = "INSERT";
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click_1);
            // 
            // updateButton
            // 
            this.updateButton.Image = ((System.Drawing.Image)(resources.GetObject("updateButton.Image")));
            this.updateButton.Location = new System.Drawing.Point(171, 13);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(97, 42);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "UPDATE";
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click_1);
            // 
            // clearButton
            // 
            this.clearButton.Image = ((System.Drawing.Image)(resources.GetObject("clearButton.Image")));
            this.clearButton.Location = new System.Drawing.Point(171, 62);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(97, 42);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "CLEAR";
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click_1);
            // 
            // delButton
            // 
            this.delButton.Image = ((System.Drawing.Image)(resources.GetObject("delButton.Image")));
            this.delButton.Location = new System.Drawing.Point(17, 61);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(97, 42);
            this.delButton.TabIndex = 3;
            this.delButton.Text = "DELETE";
            this.delButton.Click += new System.EventHandler(this.delButton_Click_1);
            // 
            // ManageMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 457);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ManageMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControlMenu";
            this.Load += new System.EventHandler(this.ManageMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.DataGridView menuView;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn drinks_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn drinks_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn drinks_price;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton delButton;
        private DevExpress.XtraEditors.SimpleButton clearButton;
        private DevExpress.XtraEditors.SimpleButton updateButton;
        private DevExpress.XtraEditors.SimpleButton insertButton;
    }
}