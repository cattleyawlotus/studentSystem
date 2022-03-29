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
    public partial class UC_addgradeform : UserControl
    {
        public UC_addgradeform()
        {
            InitializeComponent();
        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            string select_sno = textBoxstudent.Text;
            string select_cno = textBoxclass.Text.Split()[0];
            string new_score = textBoxgrade.Text.Trim();
           
            SqlConnection conn = new SqlConnection(Form1.connectionString);
            string sql = "UPDATE selectclass SET score=" + new_score + "WHERE cno='" + select_cno + "' AND sno='" + select_sno + "'";
            SqlDataAdapter adp = new SqlDataAdapter(sql, conn);
            try
            {
                conn.Open();
                DataSet ds = new DataSet();
                adp.Fill(ds);
                MessageBox.Show("已经录入成绩！");
            }
            catch (Exception sql_score_in)
            {
                MessageBox.Show("成绩不正确，应为0-100的整数！");
            }
            finally
            {
                conn.Close();
            }
        }

        private void UC_addgradeform_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Form1.connectionString);
            string sql = "SELECT DISTINCT selectclass.cno,cname FROM selectclass,course WHERE selectclass.cno=course.cno";
            SqlCommand command = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                string course = dataReader["cno"].ToString() + " "+(string)dataReader["cname"];
                listBox1.Items.Add(course); 
            }
            conn.Close();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            string cno = listBox1.SelectedItem.ToString().Split()[0];
            textBoxclass.Text = listBox1.SelectedItem.ToString();
            SqlConnection conn = new SqlConnection(Form1.connectionString);
            string sql = "SELECT DISTINCT student.sno,sname,term FROM selectclass,student,course WHERE selectclass.cno=course.cno AND selectclass.sno=student.sno AND selectclass.cno=" + cno + "";
            SqlCommand command = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                string course = dataReader["sno"].ToString() + " " + (string)dataReader["sname"];
                listBox2.Items.Add(course);
                textBox1.Text = (string)dataReader["term"];
            }
            conn.Close();
        }

        private void listBox2_Click(object sender, EventArgs e)
        {
            textBoxstudent.Text = listBox2.SelectedItem.ToString().Split()[0];
        }
    }
}
