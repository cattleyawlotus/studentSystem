using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentSystemUI
{
    public partial class UC_selectClass : UserControl
    {
        public UC_selectClass()
        {
            InitializeComponent();
        }

        private void UC_selectClass_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Form1.connectionString);
            string sql = "SELECT cno,cname,tname,credit,time,classroom,maxnum FROM course,teacher WHERE course.term='21年春'AND teacher.tno=course.tno ORDER BY cname";
            SqlCommand command = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader dataReader = command.ExecuteReader();
           /*按课程名排序 显示所有课程*/
            while (dataReader.Read())
            {
                int index = this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[index].Cells[0].Value = dataReader["cno"].ToString();
                this.dataGridView1.Rows[index].Cells[1].Value = (string)dataReader["cname"];
                this.dataGridView1.Rows[index].Cells[2].Value = (string)dataReader["tname"];
                this.dataGridView1.Rows[index].Cells[3].Value = dataReader["credit"].ToString();
                this.dataGridView1.Rows[index].Cells[4].Value = (string)dataReader["time"];
                this.dataGridView1.Rows[index].Cells[5].Value = (string)dataReader["classroom"];
                this.dataGridView1.Rows[index].Cells[6].Value = (string)dataReader["maxnum"].ToString();
            }
            conn.Close();
            /*更新是否选课栏*/
            is_select();
            /*自动填入学号，用于选课，且只读*/
            string sql_sno = "SELECT sno FROM student WHERE userid='" + Form1.userid + "'";
            SqlCommand command_sno = new SqlCommand(sql_sno, conn);
            conn.Open();
            SqlDataReader dataReader_sno = command_sno.ExecuteReader();
            while (dataReader_sno.Read())
            {
                textBox1.Text = dataReader_sno["sno"].ToString();
            }
            conn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*如果点击每一行的第一个单元格，可自动填入选课信息*/
            if(e.ColumnIndex== -1)
            {
                textBoxid.Text = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(); 
                textBoxclass.Text = this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(); 
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxclass.Text = "";
            textBoxid.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string select_sno = textBox1.Text.Trim();
            string select_cno = textBoxid.Text.Trim();
            /*判断所选课是否已在自己的选课表中，若存在则不执行插入操作*/
            string sql_select = "SELECT cno FROM selectclass,student WHERE selectclass.sno=student.sno AND student.userid='" + Form1.userid + "' AND selectclass.cno='"+select_cno+"'";
            SqlConnection conn = new SqlConnection(Form1.connectionString);
            SqlCommand command = new SqlCommand(sql_select, conn);
            conn.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            bool selected = dataReader.Read();
            conn.Close();
            if(selected)
            {
                MessageBox.Show("已经选过此课！");
            }
            else if (select_sno != "" && select_cno != ""&&!selected)
            {
                MessageBox.Show("选课成功！");
                string sql = "INSERT INTO selectclass(sno,cno) VALUES (" + select_sno + "," + select_cno + ") ";
                SqlDataAdapter adp = new SqlDataAdapter(sql, conn);
                conn.Open();
                DataSet ds = new DataSet();
                adp.Fill(ds);
            }
            is_select();
        }
        /*更新是否选课栏*/
        private void is_select()
        {
            SqlConnection conn = new SqlConnection(Form1.connectionString);
            string sql = "SELECT cno FROM selectclass,student WHERE selectclass.sno=student.sno AND student.userid='"+Form1.userid+"'";
            SqlCommand command = new SqlCommand(sql, conn);
           
            
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                this.dataGridView1.Rows[i].Cells[7].Value = "否";
                conn.Open();
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    if (this.dataGridView1.Rows[i].Cells[0].Value.Equals(dataReader["cno"].ToString()))
                    {
                        this.dataGridView1.Rows[i].Cells[7].Value = "是";
                    } 
                }
                dataReader.Close();
                conn.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string delete_sno = textBox1.Text.Trim();
            string delete_cno = textBoxid.Text.Trim();
           
            /*删除选课信息*/
            if (delete_sno != "" && delete_cno != "" )
            {

                SqlConnection conn = new SqlConnection(Form1.connectionString);
                conn.Open();

                string sql_select = "SELECT * FROM selectclass WHERE cno='" + delete_cno + "'AND sno='" + delete_sno + "'";
                SqlCommand command = new SqlCommand(sql_select, conn);
                SqlDataReader dataReader = command.ExecuteReader();
                if (!dataReader.Read())
                {
                    MessageBox.Show("未选此课程！");
                    dataReader.Close();
                }
                else
                {
                    dataReader.Close();
                    string sql = "DELETE FROM selectclass WHERE cno='" + delete_cno + "' AND sno='" + delete_sno + "'";
                    SqlDataAdapter adp = new SqlDataAdapter(sql, conn);
                    try
                    {
                        DataSet ds = new DataSet();
                        adp.Fill(ds);
                        MessageBox.Show("退课成功！");
                    }
                    catch (Exception sql_deleteclass)
                    {
                        MessageBox.Show(sql_deleteclass.Message);
                    }
                }
                conn.Close();
            }
            is_select();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
