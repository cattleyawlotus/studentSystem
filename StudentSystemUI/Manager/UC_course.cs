using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerUI
{
    public partial class UC_course : UserControl
    {
        public UC_course()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            UC_courseinformation fn = new UC_courseinformation();
            fn.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(fn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            UC_searchclassform fn = new UC_searchclassform();
            fn.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(fn);
        }
    }
}
