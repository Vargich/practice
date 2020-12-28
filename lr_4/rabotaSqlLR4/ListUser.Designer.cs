namespace rabotaSqlLR4
{
    partial class ListUser
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Bt_otbor = new System.Windows.Forms.Button();
            this.Bt_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Login,
            this.Password,
            this.Role});
            this.dataGridView1.Location = new System.Drawing.Point(150, 129);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(870, 483);
            this.dataGridView1.TabIndex = 0;
            // 
            // Login
            // 
            this.Login.DataPropertyName = "Login";
            this.Login.Frozen = true;
            this.Login.HeaderText = "Логин";
            this.Login.MinimumWidth = 8;
            this.Login.Name = "Login";
            this.Login.Width = 150;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.Frozen = true;
            this.Password.HeaderText = "Пароль";
            this.Password.MinimumWidth = 8;
            this.Password.Name = "Password";
            this.Password.Width = 150;
            // 
            // Role
            // 
            this.Role.DataPropertyName = "Role";
            this.Role.Frozen = true;
            this.Role.HeaderText = "Роль";
            this.Role.MinimumWidth = 8;
            this.Role.Name = "Role";
            this.Role.Width = 150;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Не выбрано",
            "Администратор",
            "Заказчик"});
            this.comboBox1.Location = new System.Drawing.Point(333, 65);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(260, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Bt_otbor
            // 
            this.Bt_otbor.Location = new System.Drawing.Point(622, 62);
            this.Bt_otbor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bt_otbor.Name = "Bt_otbor";
            this.Bt_otbor.Size = new System.Drawing.Size(112, 35);
            this.Bt_otbor.TabIndex = 2;
            this.Bt_otbor.Text = "Отбор";
            this.Bt_otbor.UseVisualStyleBackColor = true;
            this.Bt_otbor.Click += new System.EventHandler(this.Bt_otbor_Click);
            // 
            // Bt_back
            // 
            this.Bt_back.Location = new System.Drawing.Point(18, 18);
            this.Bt_back.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bt_back.Name = "Bt_back";
            this.Bt_back.Size = new System.Drawing.Size(112, 35);
            this.Bt_back.TabIndex = 3;
            this.Bt_back.Text = "Назад";
            this.Bt_back.UseVisualStyleBackColor = true;
            this.Bt_back.Click += new System.EventHandler(this.Bt_back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Сортировка по роли";
            // 
            // ListUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bt_back);
            this.Controls.Add(this.Bt_otbor);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ListUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список пользователей";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Bt_otbor;
        private System.Windows.Forms.Button Bt_back;
        private System.Windows.Forms.Label label1;
    }
}