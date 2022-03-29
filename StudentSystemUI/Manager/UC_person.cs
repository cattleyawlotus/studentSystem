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
    public partial class UC_person : UserControl
    {
        public UC_person()
        {
            InitializeComponent();
        }

    


        private void button2_Click(object sender, EventArgs e)
        {
            //mangaerInfo-->UC_mamagerInfo-->UC_mamagerInfo.panel2-->person
            UC_managerInfo un = new UC_managerInfo();
            un.Dock = DockStyle.Fill;
            //重新开启UC_managerInfo窗体
            this.Parent.Parent.Parent.Controls.Add(un);
            //删除旧的UC_managerInfo窗体并释放资源
            this.Parent.Parent.Parent.Controls.Remove(this.Parent.Parent);
            this.Parent.Parent.Dispose();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            string new_id = textBox1.Text.Trim();
            string new_pw = textBox2.Text.Trim();
            string re_pw = textBox3.Text.Trim();
            if (new_id == "" || new_pw == "")
            {
                MessageBox.Show("请输入完整信息！");
            }
            else if (!re_pw.Equals(new_pw))
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
                MessageBox.Show("已修改成功！");

                //mangaerInfo-->UC_mamagerInfo-->UC_mamagerInfo.panel2-->person
                UC_managerInfo un = new UC_managerInfo();
                un.Dock = DockStyle.Fill;
                //重新开启UC_managerInfo窗体
                this.Parent.Parent.Parent.Controls.Add(un);
                //删除旧的UC_managerInfo窗体并释放资源
                this.Parent.Parent.Parent.Controls.Remove(this.Parent.Parent);
                this.Parent.Parent.Dispose();
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void UC_person_Load(object sender, EventArgs e)
        {
            textBox1.Text = Form1.userid;
        }
    }
}
