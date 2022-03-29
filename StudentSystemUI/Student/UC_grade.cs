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
    public partial class UC_grade : UserControl
    {
        public UC_grade()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*重复查询时，删除上一次查询信息*/
            dataGridView1.Rows.Clear();

            string select_term = comboBox1.Text;
            SqlConnection conn = new SqlConnection(Form1.connectionString);
            string sql = "SELECT cname,credit,score,term,tname FROM course,selectclass,student,teacher WHERE course.term='" + select_term + "' AND teacher.tno=course.tno AND course.cno=selectclass.cno AND selectclass.sno=student.sno AND student.userid='" + Form1.userid + "'";
            SqlCommand command = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                int index = this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[index].Cells[0].Value = (string)dataReader["cname"];
                this.dataGridView1.Rows[index].Cells[1].Value = (string)dataReader["tname"];
                this.dataGridView1.Rows[index].Cells[2].Value = (string)dataReader["term"];
                this.dataGridView1.Rows[index].Cells[3].Value = dataReader["credit"].ToString();
                if (dataReader["score"] is System.DBNull)
                {
                    this.dataGridView1.Rows[index].Cells[4].Value = "";
                    this.dataGridView1.Rows[index].Cells[5].Value = "";
                }
                else
                {
                    this.dataGridView1.Rows[index].Cells[4].Value = dataReader["score"].ToString();
                    int score = (int)dataReader["score"];
                    if(score >= 90)
                    {
                        this.dataGridView1.Rows[index].Cells[5].Value = 4.0;
                    }
                    else if(score>= 85 && score<=89)
                    {
                        this.dataGridView1.Rows[index].Cells[5].Value = 3.7;
                    }
                    else if(score >= 82 && score <= 84)
                    {
                        this.dataGridView1.Rows[index].Cells[5].Value = 3.3;
                    }
                    else if(score >= 78 && score <= 81)
                    {
                        this.dataGridView1.Rows[index].Cells[5].Value = 3.0;
                    }
                    else if (score >= 75 && score <= 77)
                    {
                        this.dataGridView1.Rows[index].Cells[5].Value = 2.7;
                    }
                    else if (score >= 72 && score <= 74)
                    {
                        this.dataGridView1.Rows[index].Cells[5].Value = 2.3;
                    }
                    else if (score >= 68 && score <= 71)
                    {
                        this.dataGridView1.Rows[index].Cells[5].Value = 2.0;
                    }
                    else if (score >= 64 && score <= 67)
                    {
                        this.dataGridView1.Rows[index].Cells[5].Value = 1.5;
                    }
                    else if (score >= 60 && score <= 63)
                    {
                        this.dataGridView1.Rows[index].Cells[5].Value = 1.0;
                    }
                    else
                    {
                        this.dataGridView1.Rows[index].Cells[5].Value = 0.0;
                    }
                }
            }
            conn.Close();
        }
    }
}
