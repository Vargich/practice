using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace rabotaSqlLR4
{
    class DBConnection
    {
        static string connectionString = @"Database = murmanryb; Data Source = localhost; UserID = root; Password = 856951"; //строка подключения
        static MySqlConnection msConnect; //объект для установки соединения с БД
        static public MySqlCommand msCommand; //объект для выполнения запросов
        static public MySqlDataAdapter msDataAdapter;

        static public string User; //логин авторизованного пользователя
        static public string Role; //роль авторизованного пользователя

        static public DataTable dtUsers = new DataTable();
        static public DataTable dtCustomers = new DataTable();


        static public bool Connect()
        {
            try
            {
                //создание объекта соединения с заданной строкой подключения
                msConnect = new MySqlConnection(connectionString);
                msConnect.Open(); //открытие подключение
                                  //создание объекта-запрос
                msCommand = new MySqlCommand();
                msCommand.Connection = msConnect;
                msDataAdapter = new MySqlDataAdapter(msCommand);
                return true; //результат «истина»
            }
            catch (Exception ex) //при возникновении ошибки
            {
                //вывод сообщения
                System.Windows.Forms.MessageBox.Show(ex.ToString(), "Ошибка!");
                return false; //результат «ложь»
            }
        }
        //отключение соединения с БД
        static public void Close()
        {
            msConnect.Close();
        }

        //авторизация пользователя, принимает параметры с формы авторизации
        static public void Authorization(string login, string password)
        {
            try
            {
                //формируем запрос: выбрать поле из таблицы значения,
                //где логин и пароль равны введенным пользователем значениям
                string sql = "SELECT Role FROM Users WHERE Login = '" + login
                 + "' AND Password = '" + password + "' ;";
                //создаем объект-запрос
                msCommand = new MySqlCommand(sql, msConnect);
                //фиксируем результат запроса
                Object result = msCommand.ExecuteScalar();
                //если в результате выполнения запроса получено непустое значение
                if (result != null)
                {
                    //заполняем информацию об авторизованном пользователе
                    Role = result.ToString();
                    User = login;
                }
                else
                {
                    //иначе тип пользователя - неавторизованный
                    Role = null;
                }
            }
            catch (Exception ex) //при возникновении ошибки
            {
                Role = User = null; //обнуляем значения полей
                                    //MessageBox.Show(ex.ToString(), "Ошибка!");



            }
        }


        //метод получения списка пользователей
        //selectedRole – значение роли для фильтрации
        //по умолчанию = null
       
        static public void GetUserList(string selectedRole = null)
        {
            //если роль не выбрана
            if (selectedRole == null)
            {
                //формируем запрос на выборку всех записей
                msCommand.CommandText = "SELECT * FROM users";
            }
            else
            {
                //иначе, формируем запрос с фильтрацией
                msCommand.CommandText = "SELECT * FROM users WHERE users.Role='" +selectedRole + "'";
            }
            dtUsers.Clear(); //очистка набора данных
            msDataAdapter = new MySqlDataAdapter(msCommand);
            msDataAdapter.Fill(dtUsers); //заполнение набора данных
                 
        }

        static public void GetCustomersList()
        {
           
                //формируем запрос на выборку всех записей
           msCommand.CommandText = "SELECT * FROM customers";
            
               //иначе, формируем запрос с фильтрацией
               // msCommand.CommandText = "SELECT * FROM users WHERE users.Role='" + selectedRole + "'";
         
            dtCustomers.Clear(); //очистка набора данных
            msDataAdapter = new MySqlDataAdapter(msCommand);
            msDataAdapter.Fill(dtCustomers); //заполнение набора данных

        }

        ////добавление нового пользователя
        //static public bool AddUser(string login, string password, string role)
        //{
        //    //формирование запроса
        //    msCommand.CommandText = "INSERT INTO users VALUES('" + login +
        //     "','" + password + "','" + role + "');";
        //    //выполение запроса
        //    if (msCommand.ExecuteNonQuery() > 0)
        //        return true;
        //    else
        //        return false;
        //}
        ////добавление нового заказчика
        //static public void AddCustomer(string user, string name, string telephone, string
        //adress, string email = null)
        //{
        //    //формирование запроса
        //    msCommand.CommandText = "INSERT INTO customers VALUES('" + user + "','" + name
        //     + "','" + telephone + "','" + email + "','" + adress + "');";
        //    //выполение запроса
        //    msCommand.ExecuteNonQuery();
        //}

    }
}
