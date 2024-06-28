namespace InventoryManagementSys
{
    partial class UserForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_user = new System.Windows.Forms.DataGridView();
            this.col_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 503);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 59);
            this.panel1.TabIndex = 0;
            // 
            // dgv_user
            // 
            this.dgv_user.AllowUserToAddRows = false;
            this.dgv_user.BackgroundColor = System.Drawing.Color.White;
            this.dgv_user.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_user.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_user.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_no,
            this.col_username,
            this.col_fullname,
            this.col_password,
            this.col_phone,
            this.Column1,
            this.Column2});
            this.dgv_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_user.GridColor = System.Drawing.Color.Blue;
            this.dgv_user.Location = new System.Drawing.Point(0, 0);
            this.dgv_user.Name = "dgv_user";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_user.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_user.RowHeadersWidth = 51;
            this.dgv_user.RowTemplate.Height = 24;
            this.dgv_user.Size = new System.Drawing.Size(900, 503);
            this.dgv_user.TabIndex = 1;
            this.dgv_user.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_user_CellContentClick);
            // 
            // col_no
            // 
            this.col_no.HeaderText = "No";
            this.col_no.MinimumWidth = 6;
            this.col_no.Name = "col_no";
            this.col_no.Width = 125;
            // 
            // col_username
            // 
            this.col_username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_username.HeaderText = "Username";
            this.col_username.MinimumWidth = 6;
            this.col_username.Name = "col_username";
            this.col_username.Width = 112;
            // 
            // col_fullname
            // 
            this.col_fullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_fullname.HeaderText = "Full name";
            this.col_fullname.MinimumWidth = 6;
            this.col_fullname.Name = "col_fullname";
            this.col_fullname.Width = 106;
            // 
            // col_password
            // 
            this.col_password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_password.HeaderText = "Password";
            this.col_password.MinimumWidth = 6;
            this.col_password.Name = "col_password";
            // 
            // col_phone
            // 
            this.col_phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_phone.HeaderText = "Phone";
            this.col_phone.MinimumWidth = 6;
            this.col_phone.Name = "col_phone";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "";
            this.Column1.Image = ((System.Drawing.Image)(resources.GetObject("Column1.Image")));
            this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ToolTipText = "edit";
            this.Column1.Width = 6;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "";
            this.Column2.Image = ((System.Drawing.Image)(resources.GetObject("Column2.Image")));
            this.Column2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Users";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(813, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.dgv_user);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_username;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_password;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_phone;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}