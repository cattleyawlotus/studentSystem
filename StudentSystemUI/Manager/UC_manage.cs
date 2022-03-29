using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerUI
{
    public partial class UC_manage : UserControl
    {
        public UC_manage()
        {
            InitializeComponent();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            UC_addstudent fn = new UC_addstudent();
            fn.Dock = DockStyle.Fill;
            panel2.Controls.Add(fn);
            // this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            UC_modifystudentinfo fn = new UC_modifystudentinfo();
            fn.Dock = DockStyle.Fill;
            panel2.Controls.Add(fn);

        }
    }
}
