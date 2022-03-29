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
    public partial class UC_searchclassform : UserControl
    {
        public UC_searchclassform()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*重复查询时，删除上一次查询信息*/
            dataGridView1.Rows.Clear();
            string select_term = comboBoxterm.Text;
            string select_course = textBoxclass.Text.Trim();
            SqlConnection conn = new SqlConnection(Form1.connectionString);
            string sql = "SELECT cno,tname,credit,time,classroom,maxnum FROM course,teacher WHERE course.term='" + select_term + "' AND teacher.tno=course.tno AND course.cname='" + select_course + "'";
            SqlCommand command = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                int index = this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[index].Cells[0].Value = dataReader["cno"].ToString();
                this.dataGridView1.Rows[index].Cells[1].Value = (string)dataReader["tname"];
                this.dataGridView1.Rows[index].Cells[2].Value = dataReader["credit"].ToString();
                this.dataGridView1.Rows[index].Cells[3].Value = (string)dataReader["time"];
                this.dataGridView1.Rows[index].Cells[4].Value = (string)dataReader["classroom"];
                this.dataGridView1.Rows[index].Cells[5].Value = dataReader["maxnum"].ToString();
            }
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}        
          

