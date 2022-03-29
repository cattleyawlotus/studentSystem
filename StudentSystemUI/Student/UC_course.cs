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
    public partial class UC_course : UserControl
    {
        public UC_course()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            UC_searchClass un = new UC_searchClass();
            un.Dock = DockStyle.Fill;
            panel2.Controls.Add(un);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            UC_selectClass un = new UC_selectClass();
            un.Dock = DockStyle.Fill;
            panel2.Controls.Add(un);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
