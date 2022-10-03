using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO.NET_Finn
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        
        public static OleDbConnection conn = new OleDbConnection();
        string Login;
        string Password;
        //public bool LoginSuccess = false;

        private void loginButton_Click(object sender, EventArgs e)
        {
            //string newConn = $"Provider=SQLOLEDB.1;Data Source=localhost\SQLEXPRESS;Initial Catalog=Northwind;Persist Security Info=True;User ID={Login.Text};Password={Password.Text}";
            //using (OleDbConnection conn = new OleDbConnection(newConn))
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    Login = LoginTextBox.Text;
                    Password = PasswordTextBox.Text;
                    conn.ConnectionString = $"Provider=SQLOLEDB.1;Data Source=localhost\\SQLEXPRESS;Initial Catalog=Northwind;Persist Security Info=True;User ID={{Login}};Password={{Password.Text}}";
                    conn.Open();

                    MessageBox.Show("Соединение установленно");

                    this.Close();
                }
            else
            {
                MessageBox.Show("Соединение уже было установлено");
                this.Close();
            }
            }
            catch (OleDbException XcpSQL)
            {
            foreach (OleDbError se in XcpSQL.Errors)
            {
            MessageBox.Show(se.Message, "SQL Error code " + se.NativeError, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception Xcp)
            {
                MessageBox.Show(Xcp.Message, "Unexpected Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}