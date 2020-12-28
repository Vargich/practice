using MySql.Data.MySqlClient;
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
    public partial class ContrlZakazhika : Form
    {
        public ContrlZakazhika()
        {
            InitializeComponent();
            DBConnection.GetCustomersList(); //получение списка пользователей
            dataGridView1.DataSource = DBConnection.dtCustomers; //привязка набора данных к таблице
            //DBConnection.msDataAdapter.ToString();
            DBConnection.Connect();
            msCommand = DBConnection.msCommand;
        }
        static public MySqlCommand msCommand;


        private void Bt_back_Click(object sender, EventArgs e)
        {
            this.Hide(); //скрываем текущую форму
            MenuAdmin menuAdmin = new MenuAdmin(); //создаем и показываем
            menuAdmin.Show(); //меню заказчика

        }


        //добавление нового пользователя
        static public bool AddUser(string login, string password, string role)
        {

            //формирование запроса
            msCommand.CommandText = "INSERT INTO users VALUES('" + login +
             "','" + password + "','" + role + "');";
            //выполение запроса
            if (msCommand.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
        }
        //добавление нового заказчика
        static public void AddCustomer(string user, string name, string telephone, string
        adress, string email = null)
        {
            //формирование запроса
            msCommand.CommandText = "INSERT INTO customers VALUES('" + user + "','" + name
             + "','" + telephone + "','" + email + "','" + adress + "');";
            //выполение запроса
            msCommand.ExecuteNonQuery();
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            AddUser(t_Login.Text, t_Pass.Text, "customer");
            AddCustomer(t_Login.Text, t_Name.Text, t_Telephone.Text, t_email.Text, t_Adress.Text);
            DBConnection.GetCustomersList(); //получение списка пользователей
            dataGridView1.DataSource = DBConnection.dtCustomers; //привязка набора данных к таблице

        }
    }
}
