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
using StudentSystemUI;
namespace ManagerUI
{
    public partial class UC_addstudent : UserControl
    {
        public UC_addstudent()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sname = textBoxname.Text.Trim();
            string sno = textBoxpname.Text.Trim();
            string userid = textBox1.Text.Trim();
            string pw = textBoxpasswd.Text.Trim();
            string grade = comboBoxgrade.Text;
            string sclass = textBox2.Text.Trim();
            string major = comboBoxmajor.Text;
            string sbirthday = dateTimePicker1.Text;
            string hometown = textBoxhometown.Text.Trim();
            string ssex = "男";
            if (radioButton2.Checked && !radioButton1.Checked)
            {
                ssex = "女";
            }

            //插入用户表
            bool add_to_usertable = false;
            SqlConnection conn = new SqlConnection(Form1.connectionString);
            string sql = "INSERT INTO [user] VALUES (" + userid + "," + pw + ",'学生')";
            SqlDataAdapter adp = new SqlDataAdapter(sql, conn);
            try
            {
                conn.Open();
                DataSet ds = new DataSet();
                adp.Fill(ds);
                add_to_usertable = true;
            }
            catch (Exception sql_adduser)
            {
                MessageBox.Show("已存在属于该用户名的学生！");
            }
            finally
            {
                conn.Close();
            }

            //插入学生表
            if (add_to_usertable)
            {
               
                string sql_st = "INSERT INTO student VALUES (" + sno + ",'" + userid + "','" + sname + "','" + ssex + "','" + major + "','" + grade + "','" + sclass + "','" + sbirthday + "','" + hometown + "')";
                SqlDataAdapter adp_st = new SqlDataAdapter(sql_st, conn);
                try
                {
                    conn.Open();
                    DataSet ds_st = new DataSet();
                    adp_st.Fill(ds_st);
                    MessageBox.Show("添加成功！");
                }
                catch (Exception sql_addstudent)
                {
                    string error_message = sql_addstudent.ToString();
                    if (error_message.Contains("PRIMARY KEY"))
                    {
                        MessageBox.Show("已存在属于该学号的学生！");
                    }
                    else if (error_message.Contains("sno"))
                    {
                        MessageBox.Show("学号不在正确范围！");
                    }
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
           
        }
    }
}
