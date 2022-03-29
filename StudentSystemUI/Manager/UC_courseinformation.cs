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
    public partial class UC_courseinformation : UserControl
    {
        public UC_courseinformation()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cno = textBox1.Text.Trim();
            string cname = textBoxclass.Text.Trim();
            string tno = textBoxteacher.Text.Trim();
            string term = comboBoxterm.Text;
            string time = comboBoxtime.SelectedItem.ToString();
            string classroom = comboBoxdidian.Text;
            string credit = textBox2.Text.Trim();
            string maxnum = textBox3.Text.Trim();

            SqlConnection conn = new SqlConnection(Form1.connectionString);
            string sql = "INSERT INTO course VALUES (" + cno + ",'" + cname + "',"+tno+",'"+term+"','"+time+"','"+classroom+"',"+credit+","+maxnum+")";
            SqlDataAdapter adp = new SqlDataAdapter(sql, conn);
            try
            {
                conn.Open();
                DataSet ds = new DataSet();
                adp.Fill(ds);
                MessageBox.Show("成功开设本门课程！");
            }
            catch(Exception sql_addcourse)
            {
                string error_message = sql_addcourse.ToString();
                //MessageBox.Show(sql_addcourse.Message);
                if(error_message.Contains("PRIMARY KEY"))
                {
                    MessageBox.Show("已有该课程号对应的课程！");
                }
                else if(error_message.Contains("credit") && error_message.Contains("max") && error_message.Contains("cno"))
                {
                    MessageBox.Show("课程号、学分和容量不正确！");
                }
                else if(error_message.Contains("credit"))
                {
                    MessageBox.Show("学分不正确！");
                }
                else if(error_message.Contains("max"))
                {
                    MessageBox.Show("容量不正确！");
                }
                else if(error_message.Contains("cno"))
                {
                    MessageBox.Show("课程号不正确！");
                }
            }
            finally
            {
                conn.Close();
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

