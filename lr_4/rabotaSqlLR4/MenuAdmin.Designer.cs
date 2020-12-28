namespace rabotaSqlLR4
{
    partial class MenuAdmin
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
            this.Bt_list = new System.Windows.Forms.Button();
            this.Bt_ControlZakazhika = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bt_back
            // 
            this.Bt_back.Location = new System.Drawing.Point(286, 89);
            this.Bt_back.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bt_back.Name = "Bt_back";
            this.Bt_back.Size = new System.Drawing.Size(112, 35);
            this.Bt_back.TabIndex = 0;
            this.Bt_back.Text = "Выход";
            this.Bt_back.UseVisualStyleBackColor = true;
            this.Bt_back.Click += new System.EventHandler(this.Bt_back_Click);
            // 
            // Bt_list
            // 
            this.Bt_list.Location = new System.Drawing.Point(232, 178);
            this.Bt_list.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bt_list.Name = "Bt_list";
            this.Bt_list.Size = new System.Drawing.Size(224, 42);
            this.Bt_list.TabIndex = 1;
            this.Bt_list.Text = "Список пользователей";
            this.Bt_list.UseVisualStyleBackColor = true;
            this.Bt_list.Click += new System.EventHandler(this.Bt_list_Click);
            // 
            // Bt_ControlZakazhika
            // 
            this.Bt_ControlZakazhika.Location = new System.Drawing.Point(232, 246);
            this.Bt_ControlZakazhika.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bt_ControlZakazhika.Name = "Bt_ControlZakazhika";
            this.Bt_ControlZakazhika.Size = new System.Drawing.Size(222, 38);
            this.Bt_ControlZakazhika.TabIndex = 2;
            this.Bt_ControlZakazhika.Text = "Управление заказчиками";
            this.Bt_ControlZakazhika.UseVisualStyleBackColor = true;
            this.Bt_ControlZakazhika.Click += new System.EventHandler(this.Bt_ControlZakazhika_Click);
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(680, 380);
            this.Controls.Add(this.Bt_ControlZakazhika);
            this.Controls.Add(this.Bt_list);
            this.Controls.Add(this.Bt_back);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню администрации";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bt_back;
        private System.Windows.Forms.Button Bt_list;
        private System.Windows.Forms.Button Bt_ControlZakazhika;
    }
}