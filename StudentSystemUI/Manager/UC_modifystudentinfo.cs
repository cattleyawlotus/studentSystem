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
    public partial class UC_modifystudentinfo : UserControl
    {
        public UC_modifystudentinfo()
        {
            InitializeComponent();
        }

        private void UC_modifystudentinfo_Load(object sender, EventArgs e)
        {
            show_students();
        }

        private void button_select_Click(object sender, EventArgs e)
        {
            string sno = textBox_select_sno.Text.Trim();
            SqlConnection conn = new SqlConnection(Form1.connectionString);
            
            string sql = "SELECT * FROM student,[user] WHERE student.userid=[user].userid AND student.sno="+sno+"";
            SqlCommand command = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    textBoxid.Text = dataReader["sno"].ToString();
                    textBoxname.Text = (string)dataReader["sname"];
                    comboBoxmajor.Text = (string)dataReader["major"];
                    comboBoxgrade.Text = (string)dataReader["grade"];
                    textBoxpasswd.Text = (string)dataReader["password"]; ;
                    textBoxsclass.Text = (string)dataReader["sclass"];
                    if (dataReader["hometown"] is System.DBNull)
                    {
                        textBoxhometown.Text = "NULL";
                    }
                    else
                    {
                        textBoxhometown.Text = (string)dataReader["hometown"];
                    }
                    if (dataReader["hometown"] is System.DBNull)
                    {
                        dateTimePicker1.Text = "1949-10-01";
                    }
                    else
                    {
                        dateTimePicker1.Text = (string)dataReader["sbirthday"];
                    }
                    if (((string)dataReader["ssex"]).Equals("男"))
                    {
                        radioButton1.Checked = true;
                        radioButton2.Checked = false;
                    }
                    else
                    {
                        radioButton2.Checked = true;
                        radioButton1.Checked = false;
                    }
                }
            }
            catch (Exception sql_select)
            {
                MessageBox.Show(sql_select.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*如果点击每一行的第一个单元格,可自动填入信息。*/
            if (e.ColumnIndex == -1)
            {
                textBoxid.Text = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(); ;
                textBoxname.Text = this.dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                comboBoxmajor.Text = this.dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBoxhometown.Text = this.dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                if(this.dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString().Equals("NULL"))
                {
                    dateTimePicker1.Text = "1949-10-01";
                }
                else
                {
                    dateTimePicker1.Text = this.dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                }
                comboBoxgrade.Text = this.dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                textBoxpasswd.Text= this.dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                textBoxsclass.Text= this.dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                if (this.dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString().Equals("男"))
                {
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                }
                else
                {
                    radioButton2.Checked = true;
                    radioButton1.Checked = false;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sname = textBoxname.Text.Trim();
            string sno = textBoxid.Text.Trim();
            string pw = textBoxpasswd.Text.Trim();
            string grade = comboBoxgrade.Text.Trim();
            string sclass = textBoxsclass.Text.Trim();
            string major = comboBoxmajor.Text.Trim();
            string sbirthday = dateTimePicker1.Text;
            /*如果生日为显示的默认值，则把生日修改为null*/
            if (dateTimePicker1.Text.Equals("1949-10-01"))
            {
                sbirthday = null;
            }
          
            string hometown = textBoxhometown.Text.Trim();
            string ssex = "男";
            if (radioButton2.Checked&& !radioButton1.Checked)
            {
                ssex = "女";
            }

            SqlConnection conn = new SqlConnection(Form1.connectionString);
           
            string sql = "UPDATE student SET hometown='"+hometown+"',sbirthday='"+sbirthday+"',sclass='"+sclass+"',grade='"+grade+"',major='"+major+"',ssex='"+ssex+"',sname='"+sname+"' WHERE sno=" + sno + "";
            SqlDataAdapter adp = new SqlDataAdapter(sql, conn);
            try
            {
                conn.Open();
                DataSet ds = new DataSet();
                adp.Fill(ds);
                MessageBox.Show("修改成功！");
            }catch(Exception e_sql)
            {
                MessageBox.Show(e_sql.Message);
            }
            finally
            {
                conn.Close();

            }
            show_students();
        }
        private void show_students()
        {
            dataGridView1.Rows.Clear();
            SqlConnection conn = new SqlConnection(Form1.connectionString);
            string sql = "SELECT * FROM student,[user] WHERE student.userid=[user].userid";
            SqlCommand command = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    int index = this.dataGridView1.Rows.Add();
                    this.dataGridView1.Rows[index].Cells[0].Value = dataReader["sno"].ToString();
                    this.dataGridView1.Rows[index].Cells[1].Value = (string)dataReader["userid"];
                    this.dataGridView1.Rows[index].Cells[2].Value = (string)dataReader["sname"];
                    this.dataGridView1.Rows[index].Cells[3].Value = (string)dataReader["ssex"];
                    this.dataGridView1.Rows[index].Cells[4].Value = (string)dataReader["major"];
                    this.dataGridView1.Rows[index].Cells[5].Value = (string)dataReader["grade"];
                    this.dataGridView1.Rows[index].Cells[6].Value = (string)dataReader["sclass"];
                    //注意判空
                    if (dataReader["sbirthday"] is System.DBNull)
                    {
                        this.dataGridView1.Rows[index].Cells[7].Value = "NULL";
                    }
                    else
                    {
                        this.dataGridView1.Rows[index].Cells[7].Value = (string)dataReader["sbirthday"];
                    }
                    if (dataReader["hometown"] is System.DBNull)
                    {
                        this.dataGridView1.Rows[index].Cells[8].Value = "NULL";
                    }
                    else
                    {
                        this.dataGridView1.Rows[index].Cells[8].Value = (string)dataReader["hometown"];
                    }
                    this.dataGridView1.Rows[index].Cells[9].Value = (string)dataReader["password"];
                }
            }catch(Exception e_sql)
            {
                MessageBox.Show(e_sql.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        /*删除学生以及账户信息*/
        private void button2_Click(object sender, EventArgs e)
        {
            string sno = textBoxid.Text.Trim();
            SqlConnection conn = new SqlConnection(Form1.connectionString);
            string sql = "DELETE FROM student WHERE student.sno="+sno+" ";
            SqlDataAdapter adp = new SqlDataAdapter(sql, conn);
            try
            {
                conn.Open();
                DataSet ds = new DataSet();
                adp.Fill(ds);
            }
            catch(Exception e_sql)
            {
                MessageBox.Show(e_sql.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
