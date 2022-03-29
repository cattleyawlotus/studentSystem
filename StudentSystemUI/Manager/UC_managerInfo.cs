using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagerUI;

namespace StudentSystemUI
{
    public partial class UC_managerInfo : UserControl
    {
        public UC_managerInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            UC_addadmin fn = new UC_addadmin();
            fn.Dock = DockStyle.Fill;
            panel2.Controls.Add(fn);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            UC_admininfo fn = new UC_admininfo();
            fn.Dock = DockStyle.Fill;
            panel2.Controls.Add(fn);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            UC_person fn = new UC_person();
            fn.Dock = DockStyle.Fill;
            panel2.Controls.Add(fn);
        }
    }
}
