using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagerUI;
using System.Data.SqlClient;

namespace StudentSystemUI
{
    public partial class Form1: Form
    {
        public static string connectionString = "Data Source=.;Initial Catalog=教务管理系统;Integrated Security=True";
        public static string userid = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        /*学生登录*/
        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text.Trim();
            string pw = textBox2.Text.Trim();

            SqlConnection conn = new SqlConnection(Form1.connectionString);
            string sql = "SELECT * FROM [user] WHERE userid='"+id+"' AND password='"+pw+"' AND role='学生'"; /*ADO.net读SQLServer数据库时，数据库表的名字不能用一些关键字建立，如“User”，“Table”等。如果用这些字段可以在关键字两边加上中括号"[ ]"*/
            SqlCommand command = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                userid = id;
                studentInfo stu = new studentInfo();
                stu.Show();
                this.Hide();
            }
            conn.Close();

        }
        /*管理员登录*/
        private void button2_Click(object sender, EventArgs e)
        {
            string id = textBox3.Text.Trim();
            string pw = textBox4.Text.Trim();

            SqlConnection conn = new SqlConnection(Form1.connectionString);
            string sql = "SELECT * FROM [user] WHERE userid='" + id + "' AND password='" + pw + "' AND role='管理员'";
            SqlCommand command = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                userid = id;
                managerInfo stu = new managerInfo();
                stu.Show();
                this.Hide();
            }
            conn.Close();
        }
    }
}
