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
    public partial class UC_modifyPassword : UserControl
    {
        public UC_modifyPassword()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UC_stuInfo un = new UC_stuInfo();
            un.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(un);
            this.Parent.Controls.Remove(this);
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string new_id = textBox1.Text.Trim();
            string new_pw = textBox2.Text.Trim();
            string re_pw = textBox3.Text.Trim();
            if(new_id == "" || new_pw == "")
            {
                MessageBox.Show("请输入完整信息！");
            }
            else if(!new_id.Equals(re_pw))
            {
                MessageBox.Show("两次密码不一致！");
            }
            else if (new_id != "" && new_pw != "" && re_pw.Equals(new_pw))
            {
                
                SqlConnection conn = new SqlConnection(Form1.connectionString);
                string sql = "UPDATE [user] SET userid='" + new_id + "',password='" + new_pw + "' WHERE userid='" + Form1.userid + "'";
                Form1.userid = new_id;
                SqlDataAdapter adp = new SqlDataAdapter(sql, conn);
                conn.Open();
                DataSet ds = new DataSet();
                adp.Fill(ds);
                conn.Close();
                MessageBox.Show("修改成功！");
                UC_stuInfo un = new UC_stuInfo();
                un.Dock = DockStyle.Fill;
                this.Parent.Controls.Add(un);
                this.Parent.Controls.Remove(this);
                this.Dispose();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void UC_modifyPassword_Load(object sender, EventArgs e)
        {
            textBox1.Text = Form1.userid;
        }
    }
}
