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
    public partial class UC_addadmin : UserControl
    {
        public UC_addadmin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string userid = textBox1.Text.Trim();
            string pw = textBox2.Text.Trim();
            string re_pw = textBox3.Text.Trim();

            
            if(pw.Equals(re_pw))
            {
                SqlConnection conn = new SqlConnection(Form1.connectionString);
                string sql = "INSERT INTO [user] VALUES ('"+userid+"','"+pw+"','管理员')";
                SqlDataAdapter adp = new SqlDataAdapter(sql, conn);
                try
                {
                    conn.Open();
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    MessageBox.Show("添加用户成功！");
                }
                catch (Exception sql_addadmin)
                {
                    MessageBox.Show("已有该用户！");
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("已取消");
        }

    }
}
