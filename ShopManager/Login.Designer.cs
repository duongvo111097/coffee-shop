namespace ShopManager
{
    partial class Login
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
            this.staffButton = new System.Windows.Forms.Button();
            this.stockButton = new System.Windows.Forms.Button();
            this.shopButton = new System.Windows.Forms.Button();
            this.sellButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.idloginText = new System.Windows.Forms.TextBox();
            this.passloginText = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.statusLogin = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // staffButton
            // 
            this.staffButton.BackColor = System.Drawing.SystemColors.Window;
            this.staffButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffButton.Location = new System.Drawing.Point(411, 426);
            this.staffButton.Name = "staffButton";
            this.staffButton.Size = new System.Drawing.Size(73, 28);
            this.staffButton.TabIndex = 4;
            this.staffButton.Text = "Staff";
            this.staffButton.UseVisualStyleBackColor = false;
            this.staffButton.Visible = false;
            this.staffButton.Click += new System.EventHandler(this.staffButton_Click);
            // 
            // stockButton
            // 
            this.stockButton.BackColor = System.Drawing.SystemColors.Window;
            this.stockButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockButton.Location = new System.Drawing.Point(411, 471);
            this.stockButton.Name = "stockButton";
            this.stockButton.Size = new System.Drawing.Size(73, 28);
            this.stockButton.TabIndex = 3;
            this.stockButton.Text = "Stock";
            this.stockButton.UseVisualStyleBackColor = false;
            this.stockButton.Visible = false;
            this.stockButton.Click += new System.EventHandler(this.stockButton_Click);
            // 
            // shopButton
            // 
            this.shopButton.BackColor = System.Drawing.SystemColors.Window;
            this.shopButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopButton.Location = new System.Drawing.Point(275, 471);
            this.shopButton.Name = "shopButton";
            this.shopButton.Size = new System.Drawing.Size(73, 28);
            this.shopButton.TabIndex = 2;
            this.shopButton.Text = "Shop";
            this.shopButton.UseVisualStyleBackColor = false;
            this.shopButton.Visible = false;
            this.shopButton.Click += new System.EventHandler(this.shopButton_Click);
            // 
            // sellButton
            // 
            this.sellButton.BackColor = System.Drawing.SystemColors.Window;
            this.sellButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellButton.Location = new System.Drawing.Point(273, 426);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(73, 28);
            this.sellButton.TabIndex = 1;
            this.sellButton.Text = "Sell";
            this.sellButton.UseVisualStyleBackColor = false;
            this.sellButton.Visible = false;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Ivory;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loginButton.Location = new System.Drawing.Point(464, 424);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(91, 65);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.idLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.idLabel.Location = new System.Drawing.Point(211, 426);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(20, 15);
            this.idLabel.TabIndex = 2;
            this.idLabel.Text = "ID";
            // 
            // idloginText
            // 
            this.idloginText.Location = new System.Drawing.Point(291, 424);
            this.idloginText.Name = "idloginText";
            this.idloginText.Size = new System.Drawing.Size(149, 20);
            this.idloginText.TabIndex = 3;
            // 
            // passloginText
            // 
            this.passloginText.Location = new System.Drawing.Point(291, 469);
            this.passloginText.Name = "passloginText";
            this.passloginText.Size = new System.Drawing.Size(149, 20);
            this.passloginText.TabIndex = 5;
            this.passloginText.UseSystemPasswordChar = true;
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.passLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.passLabel.Location = new System.Drawing.Point(211, 471);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(59, 15);
            this.passLabel.TabIndex = 4;
            this.passLabel.Text = "Password";
            // 
            // statusLogin
            // 
            this.statusLogin.AutoSize = true;
            this.statusLogin.Location = new System.Drawing.Point(302, 492);
            this.statusLogin.Name = "statusLogin";
            this.statusLogin.Size = new System.Drawing.Size(35, 13);
            this.statusLogin.TabIndex = 6;
            this.statusLogin.Text = "status";
            this.statusLogin.Visible = false;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.White;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.logoutButton.Location = new System.Drawing.Point(622, 25);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(83, 27);
            this.logoutButton.TabIndex = 7;
            this.logoutButton.Text = "SIGN OUT";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Visible = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ShopManager.Properties.Resources.coffee05;
            this.pictureBox1.Location = new System.Drawing.Point(-8, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(741, 562);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(732, 550);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.staffButton);
            this.Controls.Add(this.statusLogin);
            this.Controls.Add(this.stockButton);
            this.Controls.Add(this.passloginText);
            this.Controls.Add(this.shopButton);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.idloginText);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idloginText;
        private System.Windows.Forms.TextBox passloginText;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label statusLogin;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button staffButton;
        private System.Windows.Forms.Button stockButton;
        private System.Windows.Forms.Button shopButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}