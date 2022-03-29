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
    public partial class UC_PersonInfo : UserControl
    {
        public UC_PersonInfo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void UC_PersonInfo_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Form1.connectionString);
            string sql = "SELECT * FROM student WHERE userid='" + Form1.userid + "'";
            SqlCommand command = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                label11.Text = dataReader["sno"].ToString();
                label12.Text = (string)dataReader["sname"];
                label14.Text = (string)dataReader["sclass"];
                label13.Text = (string)dataReader["major"];
                //注意判空
                if (dataReader["sbirthday"] is System.DBNull)
                {
                    label15.Text = "NULL";
                }
                else
                {
                    label15.Text = (string)dataReader["sbirthday"];
                }
                label16.Text = (string)dataReader["grade"];
                label17.Text = (string)dataReader["ssex"];

                if (dataReader["hometown"] is System.DBNull)
                {
                    label18.Text = "NULL";
                }
                else
                {
                    label18.Text = (string)dataReader["hometown"];
                }
            }
            conn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
