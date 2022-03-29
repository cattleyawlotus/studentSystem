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
    public partial class UC_grade : UserControl
    {
        public UC_grade()
        {
            InitializeComponent();
        }

     

        private void button4_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            UC_modifystudentgrade fn = new UC_modifystudentgrade();
            fn.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(fn);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            UC_addgradeform fn = new UC_addgradeform();
            fn.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(fn);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            UC_gradeshowform fn = new UC_gradeshowform();
            fn.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(fn);
        }
    }
}
