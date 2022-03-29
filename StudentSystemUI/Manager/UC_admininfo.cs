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
    public partial class UC_admininfo : UserControl
    {
        public UC_admininfo()
        {
            InitializeComponent();
        }
       
        private void UC_modifyadmininfo_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Form1.connectionString);
            string sql = "SELECT * FROM [user] WHERE role='管理员'";
            SqlCommand command = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                int index = this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[index].Cells[0].Value = (string)dataReader["userid"];
                this.dataGridView1.Rows[index].Cells[1].Value = show_password((string)dataReader["password"]);
            }
            conn.Close();
        }
        /*隐藏密码的一部分*/
        private string show_password(string s)
        {
            if (s.Length == 1)
            {
                return "*";
            }
            else if (s.Length == 2)
            {
                return s[0] + "*";
            }
            int length = s.Length;
            string res = s.Substring(0, s.Length / 3) + "***" + s.Substring(s.Length -s.Length/2+1);
            return res;
        }

    }
}
