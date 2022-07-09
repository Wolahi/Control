using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Control
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection = null;
        public Form1()
        {
            InitializeComponent();
        }

        public void ConnectDB()
        {
            string conn = $"Data Source=Halow;User ID={login.Text}; Password = {Password.Text}";

            sqlConnection = new SqlConnection(conn);

            sqlConnection.Open();

            if (Password.Text == "123")
            {
                MessageBox.Show("Вы вошли");
            }

        }

        private void StartButt_Click(object sender, EventArgs e)
        {
            ConnectDB();

        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            sqlConnection.Close();
            MessageBox.Show("Соединение разорвано");
        }

        private void AddStroks_Click(object sender, EventArgs e)
        {
            SqlCommand commandCreate = new SqlCommand(
               "USE [TestDB]  declare @number int;  set @number = 0;  while @number < 1000 begin   INSERT INTO[dbo].[Table]  ([flag] ,[data]) VALUES  (1 , N'добавлен') set @number = @number + 1; end; ", sqlConnection);

            MessageBox.Show(commandCreate.ExecuteNonQuery().ToString());
        }

        private void TableView_Enter(object sender, EventArgs e)
        {
            tableTableAdapter.Fill(dataSet1.Table);
        }

        private void ChangeStrocks_Click(object sender, EventArgs e)
        {
            SqlCommand commandChange = new SqlCommand(
               "USE [TestDB] UPDATE[dbo].[Table] SET[flag] = 0 WHERE flag = 1; ", sqlConnection);

            MessageBox.Show(commandChange.ExecuteNonQuery().ToString());
        }
    }
}
