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
    public partial class ListUser : Form
    {
        public ListUser()
        {
            InitializeComponent();
            DBConnection.GetUserList(); //получение списка пользователей
            dataGridView1.DataSource = DBConnection.dtUsers; //привязка набора данных к таблице
        }

        private void Bt_otbor_Click(object sender, EventArgs e)
        {
            string selectedRole = null; //выбранное значение поля
                                        //сопоставление номера выбранного значения в списке с типами ролей
            switch (comboBox1.SelectedIndex)
            {
                case 1:
                    selectedRole = "admin";
                    break;
                case 2:
                    selectedRole = "customer";
                    break;
            }
            DBConnection.GetUserList(selectedRole); //получение списка пользователей
        }

        private void Bt_back_Click(object sender, EventArgs e)
        {
            this.Hide(); //скрываем текущую форму
            MenuAdmin menuAdmin  = new MenuAdmin(); //создаем и показываем
            menuAdmin.Show(); //меню заказчика

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
