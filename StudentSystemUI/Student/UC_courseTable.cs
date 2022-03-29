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
    public partial class UC_courseTable : UserControl
    {
        private DataTable dt = new DataTable("subject");
        public UC_courseTable()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
        private void UC_courseTable_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //int num, week;                                                       // 周数节数，第二步的时候用得到。
            dt.Columns.Add("周数/节数", typeof(string));                           //添加列集，下面都是
            dt.Columns.Add("周一", typeof(string));
            dt.Columns.Add("周二", typeof(string));
            dt.Columns.Add("周三", typeof(string));
            dt.Columns.Add("周四", typeof(string));
            dt.Columns.Add("周五", typeof(string));
            dt.Columns.Add("周六", typeof(string));
            dt.Columns.Add("周日", typeof(string));

            for (int i = 0; i < 4; i++)                                                      //用循环添加5个行集~
            {
                DataRow dr = dt.NewRow();
                
                dt.Rows.Add(dr);
            }

            dt.Rows[0][0] = "第1-2节";                                                      //向第一行里的第一个格中添加一个“第1节”
            dt.Rows[1][0] = "第3-5节";                                                      //向第二行里的第一个格中添加一个“第 2 节”
            dt.Rows[2][0] = "第7-9节";                                                      //向第三行里的第一个格中添加一个“第3节”
            dt.Rows[3][0] = "第11-13节";                                                      //向第四行里的第一个格中添加一个“第4节”
            this.dataGridView1.DataSource = dt;  
            
        }
        private void button1_Click(object sender, EventArgs e)
        {

            string term = comboBox1.Text;
            SqlConnection conn = new SqlConnection(Form1.connectionString);
            string sql = "SELECT course.cname,course.classroom,course.time FROM selectclass,course,student WHERE course.term='" + term + "' AND student.userid='" + Form1.userid + "' AND student.sno=selectclass.sno AND selectclass.cno=course.cno";
            SqlCommand command = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                string text = (string)dataReader["cname"] + "\n" + (string)dataReader["time"] + "\n" + (string)dataReader["classroom"];
                /*分析课程时间，获得课表中的位置坐标*/
                int day = 0;
                int class_num = 0;
                switch (dataReader["time"].ToString().Substring(0, 2))
                {
                    case "周一": day = 1; break;
                    case "周二": day = 2; break;
                    case "周三": day = 3; break;
                    case "周四": day = 4; break;
                    case "周五": day = 5; break;
                    case "周六": day = 6; break;
                    case "周日": day = 7; break;
                }
                switch (dataReader["time"].ToString().Substring(2))
                {
                    case "第1-2节": class_num = 1; break;
                    case "第3-5节": class_num = 2; break;
                    case "第7-9节": class_num = 3; break;
                    case "第11-13节": class_num = 4; break;
                }
                /*添加数据*/
                dt.Rows[class_num-1][day] = text;
            }
            this.dataGridView1.DataSource = dt;

        }

    }
}
