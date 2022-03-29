using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentSystemUI
{
    public partial class UC_stuInfo : UserControl
    {

        public UC_stuInfo()
        {
            InitializeComponent();

        }

  

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            //UC_stuInfo.Controls.Clear();
            UC_PersonInfo un = new UC_PersonInfo();
            un.Dock = DockStyle.Fill;
            panel2.Controls.Add(un);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            UC_modifyPassword un = new UC_modifyPassword();
            un.Dock = DockStyle.Fill;
            panel2.Controls.Add(un);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Dispose();
            System.Environment.Exit(0);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
