namespace rabotaSqlLR4
{
    partial class ContrlZakazhika
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
            this.Bt_back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_Login = new System.Windows.Forms.TextBox();
            this.t_Name = new System.Windows.Forms.TextBox();
            this.t_Telephone = new System.Windows.Forms.TextBox();
            this.t_email = new System.Windows.Forms.TextBox();
            this.t_Adress = new System.Windows.Forms.TextBox();
            this.bt_Add = new System.Windows.Forms.Button();
            this.t_Pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Bt_back
            // 
            this.Bt_back.Location = new System.Drawing.Point(12, 12);
            this.Bt_back.Name = "Bt_back";
            this.Bt_back.Size = new System.Drawing.Size(75, 23);
            this.Bt_back.TabIndex = 4;
            this.Bt_back.Text = "Назад";
            this.Bt_back.UseVisualStyleBackColor = true;
            this.Bt_back.Click += new System.EventHandler(this.Bt_back_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User,
            this.Name,
            this.Telephone,
            this.Email,
            this.Adress});
            this.dataGridView1.Location = new System.Drawing.Point(189, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(584, 281);
            this.dataGridView1.TabIndex = 5;
            // 
            // User
            // 
            this.User.DataPropertyName = "User";
            this.User.HeaderText = "Login";
            this.User.Name = "User";
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Имя";
            this.Name.Name = "Name";
            // 
            // Telephone
            // 
            this.Telephone.DataPropertyName = "Telephone";
            this.Telephone.HeaderText = "Телефон";
            this.Telephone.Name = "Telephone";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Почта";
            this.Email.Name = "Email";
            // 
            // Adress
            // 
            this.Adress.DataPropertyName = "Adress";
            this.Adress.HeaderText = "Адрес";
            this.Adress.Name = "Adress";
            // 
            // t_Login
            // 
            this.t_Login.Location = new System.Drawing.Point(74, 70);
            this.t_Login.Name = "t_Login";
            this.t_Login.Size = new System.Drawing.Size(100, 20);
            this.t_Login.TabIndex = 6;
            // 
            // t_Name
            // 
            this.t_Name.Location = new System.Drawing.Point(74, 136);
            this.t_Name.Name = "t_Name";
            this.t_Name.Size = new System.Drawing.Size(100, 20);
            this.t_Name.TabIndex = 7;
            // 
            // t_Telephone
            // 
            this.t_Telephone.Location = new System.Drawing.Point(74, 162);
            this.t_Telephone.Name = "t_Telephone";
            this.t_Telephone.Size = new System.Drawing.Size(100, 20);
            this.t_Telephone.TabIndex = 8;
            // 
            // t_email
            // 
            this.t_email.Location = new System.Drawing.Point(74, 188);
            this.t_email.Name = "t_email";
            this.t_email.Size = new System.Drawing.Size(100, 20);
            this.t_email.TabIndex = 9;
            // 
            // t_Adress
            // 
            this.t_Adress.Location = new System.Drawing.Point(74, 214);
            this.t_Adress.Name = "t_Adress";
            this.t_Adress.Size = new System.Drawing.Size(100, 20);
            this.t_Adress.TabIndex = 10;
            // 
            // bt_Add
            // 
            this.bt_Add.Location = new System.Drawing.Point(52, 259);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(75, 23);
            this.bt_Add.TabIndex = 11;
            this.bt_Add.Text = "Добавить";
            this.bt_Add.UseVisualStyleBackColor = true;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // t_Pass
            // 
            this.t_Pass.Location = new System.Drawing.Point(74, 96);
            this.t_Pass.Name = "t_Pass";
            this.t_Pass.Size = new System.Drawing.Size(100, 20);
            this.t_Pass.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Телефон";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Почта";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Адрес";
            // 
            // ContrlZakazhika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t_Pass);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.t_Adress);
            this.Controls.Add(this.t_email);
            this.Controls.Add(this.t_Telephone);
            this.Controls.Add(this.t_Name);
            this.Controls.Add(this.t_Login);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Bt_back);
            //this.Name = "ContrlZakazhika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление заказчиками";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bt_back;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adress;
        private System.Windows.Forms.TextBox t_Login;
        private System.Windows.Forms.TextBox t_Name;
        private System.Windows.Forms.TextBox t_Telephone;
        private System.Windows.Forms.TextBox t_email;
        private System.Windows.Forms.TextBox t_Adress;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.TextBox t_Pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}