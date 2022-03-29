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
    public partial class UC_searchClass : UserControl
    {
        public UC_searchClass()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*重复查询时，删除上一次查询信息*/
            dataGridView1.Rows.Clear();
            string select_term = comboBox1.Text;
            string select_course = textBoxclass.Text.Trim();
            SqlConnection conn = new SqlConnection(Form1.connectionString);
            string sql;
            if(select_course.Equals("")) 
            {
                sql = "SELECT tname,credit,time,classroom,cname,cno FROM course,teacher WHERE course.term='" + select_term + "' AND teacher.tno=course.tno";
            }
            else
            {
                sql = "SELECT tname,credit,time,classroom,cname,cno FROM course,teacher WHERE course.term='" + select_term + "' AND teacher.tno=course.tno AND course.cname LIKE '%" + select_course + "%'";
            }
            SqlCommand command = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                int index = this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[index].Cells[0].Value =dataReader["cno"].ToString()+" "+(string)dataReader["cname"];
                this.dataGridView1.Rows[index].Cells[1].Value = (string)dataReader["tname"];
                this.dataGridView1.Rows[index].Cells[2].Value = dataReader["credit"].ToString();
                this.dataGridView1.Rows[index].Cells[3].Value = (string)dataReader["time"];
                this.dataGridView1.Rows[index].Cells[4].Value = (string)dataReader["classroom"];
            }
            conn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
