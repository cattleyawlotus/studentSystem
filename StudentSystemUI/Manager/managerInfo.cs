using StudentSystemUI;
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
    public partial class managerInfo : Form
    {
        public managerInfo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            UC_course un = new UC_course();
            un.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(un);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            UC_grade f = new UC_grade();
            f.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(f);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            UC_managerInfo fn = new UC_managerInfo();
            fn.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(fn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            UC_manage fn = new UC_manage();
            fn.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(fn);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
