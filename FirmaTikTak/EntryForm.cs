using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirmaTikTak
{
    public partial class EntryForm : Form
    {
        OracleConnection connection = new OracleConnection(ConfigurationManager.ConnectionStrings["Con1"].ConnectionString);
        OracleDataAdapter adapter;
        OracleCommand cmd;
        public EntryForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection.Open();
            if (connection.State.ToString() == "Open")
            {
                connect.Text = "Соединение с БД установлено";
                connect.ForeColor = Color.Green;
            }
            else
            {
                connect.Text = "Соединение с БД не установлено";
                connect.ForeColor = Color.Red;
            }

            connection.Close();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT COUNT(ID) FROM USERS WHERE LOGIN=:login AND PASSWORD=:password";
            cmd.Parameters.Add("login", OracleType.VarChar).Value = EntryLogin.Text;
            cmd.Parameters.Add("password", OracleType.VarChar).Value = EntryPassword.Text;
            object count = cmd.ExecuteScalar();
            if(count.ToString() != "1")
                MessageBox.Show("Пользователь с таким логином или паролем не существует");
            else
            {
                cmd.CommandText = "SELECT ID_EMP FROM USERS WHERE LOGIN=:login AND PASSWORD=:password";
                cmd.Parameters.Add("login", OracleType.VarChar).Value = EntryLogin.Text;
                cmd.Parameters.Add("password", OracleType.VarChar).Value = EntryPassword.Text;
                object id_employee = cmd.ExecuteScalar();
                OracleCommand cmd2 = connection.CreateCommand();
                cmd2.CommandText = "SELECT ID_POST FROM EMPLOYEES WHERE ID=" + id_employee.ToString();
                object id_post = cmd2.ExecuteScalar();
                switch (id_post.ToString())
                {
                    // Проверка что за пользователь зашёл
                    // Директор
                    case "1":
                        Director d = new Director();
                        d.Show();
                        break;
                    // Клиент
                    case "15":
                        Client c = new Client();
                        c.Show();
                        break;

                    // Менеджеры
                    case "2":
                        ManagerFirm mf = new ManagerFirm();
                        mf.Show();
                        break;
                    case "3":
                        ManagerFirm mf2 = new ManagerFirm();
                        mf2.Show();
                        break;
                    // Упр.складом
                    case "4":
                        ManagingWarehouse mw = new ManagingWarehouse(id_employee);
                        mw.Show();
                        break;
                }
                this.Hide();
            }
            connection.Close();
        }
    }
}
