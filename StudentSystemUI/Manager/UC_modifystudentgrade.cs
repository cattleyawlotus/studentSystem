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
    public partial class UC_modifystudentgrade : UserControl
    {
        public UC_modifystudentgrade()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            search();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string select_sno =textBoxxuehao.Text.Trim();
            string select_cno =textBoxkecheng.Text.Trim();
            string new_score =textBoxgrade.Text.Trim();
            SqlConnection conn = new SqlConnection(Form1.connectionString);
            string sql = "UPDATE selectclass SET score=" + new_score+ "WHERE cno='" + select_cno + "' AND sno='"+select_sno+"'";
            SqlDataAdapter adp = new SqlDataAdapter(sql, conn);
            try
            {
                conn.Open();
                DataSet ds = new DataSet();
                adp.Fill(ds);
                MessageBox.Show("已修改成功！");
            }
            catch (Exception sql_modify_grade)
            {
                MessageBox.Show("成绩不正确，应为0-100之间的整数！");
            }
            finally
            {
                conn.Close();
                search();
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        { /*如果点击每一行的第一个单元格，可自动填入信息*/
            if (e.ColumnIndex == -1&& e.RowIndex>-1)
            {
                textBoxteacher.Text = this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxgrade.Text = this.dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                textBoxkecheng.Text = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxxuehao.Text = this.dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }
        private void search()
        {
            /*重复查询时，删除上一次查询信息*/
            dataGridView1.Rows.Clear();
            string select_term = comboBoxterm.Text;
            string select_course = textBoxclass.Text.Trim();
            SqlConnection conn = new SqlConnection(Form1.connectionString);
            string sql = "SELECT course.cno,student.sno,tname,credit,score,sname FROM selectclass,teacher,course,student WHERE student.sno=selectclass.sno AND selectclass.cno=course.cno AND course.term='" + select_term + "' AND teacher.tno=course.tno AND course.cname='" + select_course + "'";
            SqlCommand command = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                int index = this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[index].Cells[0].Value = dataReader["cno"].ToString();
                this.dataGridView1.Rows[index].Cells[1].Value = (string)dataReader["tname"];
                this.dataGridView1.Rows[index].Cells[2].Value = dataReader["sno"].ToString();
                this.dataGridView1.Rows[index].Cells[3].Value = dataReader["sname"].ToString();
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
}
