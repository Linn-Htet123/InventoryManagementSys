namespace InventoryManagementSys
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chk_showPass = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 80);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "username : ";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(25, 218);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(279, 22);
            this.txt_username.TabIndex = 2;
            // 
            // txt_password
            // 
            this.txt_password.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_password.Location = new System.Drawing.Point(25, 299);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(279, 22);
            this.txt_password.TabIndex = 4;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "password : ";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Blue;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_login.Location = new System.Drawing.Point(25, 390);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(279, 40);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "LOGIN";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InventoryManagementSys.Properties.Resources.expense_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(136, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 37);
            this.label4.TabIndex = 7;
            this.label4.Text = "Inventory";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chk_showPass
            // 
            this.chk_showPass.AutoSize = true;
            this.chk_showPass.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_showPass.Location = new System.Drawing.Point(25, 329);
            this.chk_showPass.Name = "chk_showPass";
            this.chk_showPass.Size = new System.Drawing.Size(130, 21);
            this.chk_showPass.TabIndex = 7;
            this.chk_showPass.Text = "show password";
            this.chk_showPass.UseVisualStyleBackColor = true;
            this.chk_showPass.CheckedChanged += new System.EventHandler(this.chk_showPass_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(260, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "clear";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 484);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chk_showPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(351, 531);
            this.MinimumSize = new System.Drawing.Size(351, 531);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chk_showPass;
        private System.Windows.Forms.Label label5;
    }
}

