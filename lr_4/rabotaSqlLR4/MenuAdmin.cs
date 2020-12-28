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
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void Bt_back_Click(object sender, EventArgs e)
        {
            this.Hide(); //скрываем текущую форму
            Form1 MyForm = new Form1(); //создаем и показываем
            MyForm.Show(); //меню заказчика
        }

        private void Bt_list_Click(object sender, EventArgs e)
        {
            this.Hide(); //скрываем текущую форму
            ListUser list = new ListUser(); //создаем и показываем
            list.Show(); //меню заказчика
        }

        private void Bt_ControlZakazhika_Click(object sender, EventArgs e)
        {
            this.Hide(); //скрываем текущую форму
            ContrlZakazhika ControlZakazhika = new ContrlZakazhika(); //создаем и показываем
            ControlZakazhika.Show(); //меню заказчика
        }
    }
}
