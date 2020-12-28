using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rabotaSqlLR4
{
    public partial class MenuZakazhik : Form
    {
        public MenuZakazhik()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); //скрываем текущую форму
            Form1 MyForm = new Form1(); //создаем и показываем
            MyForm.Show(); //меню заказчика

        }
    }
}
