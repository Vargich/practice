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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (!DBConnection.Connect()) //если соединение не установлено
            {
                this.Close(); //выход из программы
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //вызываем метод авторизации и передаем введенные логин и пароль
            DBConnection.Authorization(txtLogin.Text, txtPassword.Text);
            switch (DBConnection.Role)
            {
                //если роль не распознана, пользователь не авторизован
                case null:
                    MessageBox.Show("Неверные данные!");
                    break;
                //если авторизован заказчик
                case "customer":
                    this.Hide(); //скрываем текущую форму
                    MenuZakazhik CustomerMenuFrm = new MenuZakazhik(); //создаем и показываем
                    CustomerMenuFrm.Show(); //меню заказчика
                    break;
                //если авторизован администратор
                case "admin":
                    this.Hide(); //скрываем текущую форму
                    MenuAdmin AdminFrm = new MenuAdmin();//создаем и показываем
                    AdminFrm.Show(); //меню администратора
                    break;
            }

        }
    }
}
