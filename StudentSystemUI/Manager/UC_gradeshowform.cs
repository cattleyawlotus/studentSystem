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
    public partial class UC_gradeshowform : UserControl
    {
        public UC_gradeshowform()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*重复查询时，删除上一次查询信息*/
            dataGridView1.Rows.Clear();
            string select_term = comboBox1.Text;
            string select_course = textBoxclass.Text.Trim();
            string min = textBox1.Text.Trim();
            string max = textBox2.Text.Trim();

            int max_int = int.Parse(max);
            int min_int = int.Parse(min);
            if (min_int < 0 || max_int > 100 || (min_int > max_int))
            {
                MessageBox.Show("成绩范围不正确！");
            }
            else
            {
                SqlConnection conn = new SqlConnection(Form1.connectionString);
                string sql = "SELECT course.cno,student.sno,tname,credit,score,sname FROM selectclass,teacher,course,student WHERE score>=" + min + " AND　score<=" + max + " AND student.sno=selectclass.sno AND selectclass.cno=course.cno AND course.term='" + select_term + "' AND teacher.tno=course.tno AND course.cname='" + select_course + "'";
                SqlCommand command = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    int index = this.dataGridView1.Rows.Add();
                    this.dataGridView1.Rows[index].Cells[0].Value = dataReader["cno"].ToString();
                    this.dataGridView1.Rows[index].Cells[1].Value = (string)dataReader["tname"];
                    this.dataGridView1.Rows[index].Cells[2].Value = dataReader["sno"].ToString();
                    this.dataGridView1.Rows[index].Cells[3].Value = (string)dataReader["sname"];
                    this.dataGridView1.Rows[index].Cells[4].Value = dataReader["credit"].ToString();
                    if (dataReader["score"] is System.DBNull)
                    {
                        this.dataGridView1.Rows[index].Cells[5].Value = "null";
                    }
                    else
                    {
                        this.dataGridView1.Rows[index].Cells[5].Value = dataReader["score"].ToString();
                    }
                }
                conn.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }
    }
 } 


