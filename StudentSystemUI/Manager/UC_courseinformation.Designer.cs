
namespace ManagerUI
{
    partial class UC_courseinformation
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxdidian = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxterm = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxclass = new System.Windows.Forms.TextBox();
            this.textBoxteacher = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxtime = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(207, 355);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(209, 35);
            this.textBox3.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("碳纤维正粗黑简体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(90, 356);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 39);
            this.label8.TabIndex = 35;
            this.label8.Text = "容量";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(695, 353);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 35);
            this.textBox2.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("碳纤维正粗黑简体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(568, 357);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 39);
            this.label2.TabIndex = 33;
            this.label2.Text = "学分";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(695, 166);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 35);
            this.textBox1.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("碳纤维正粗黑简体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(536, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 39);
            this.label1.TabIndex = 31;
            this.label1.Text = "课程号";
            // 
            // comboBoxdidian
            // 
            this.comboBoxdidian.FormattingEnabled = true;
            this.comboBoxdidian.Items.AddRange(new object[] {
            "教一101",
            "教一102",
            "教一103",
            "教一104",
            "教二102",
            "教二102",
            "教二103",
            "教二104",
            "教三101",
            "教三102",
            "教三103",
            "实验楼102",
            "实验楼101",
            "实验楼102"});
            this.comboBoxdidian.Location = new System.Drawing.Point(695, 262);
            this.comboBoxdidian.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxdidian.Name = "comboBoxdidian";
            this.comboBoxdidian.Size = new System.Drawing.Size(209, 32);
            this.comboBoxdidian.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("碳纤维正粗黑简体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(504, 264);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 39);
            this.label5.TabIndex = 28;
            this.label5.Text = "上课地点";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("碳纤维正粗黑简体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(26, 265);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 39);
            this.label4.TabIndex = 27;
            this.label4.Text = "上课时间";
            // 
            // comboBoxterm
            // 
            this.comboBoxterm.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.comboBoxterm.Font = new System.Drawing.Font("碳纤维正粗黑简体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxterm.FormattingEnabled = true;
            this.comboBoxterm.Items.AddRange(new object[] {
            "21年春",
            "20年秋",
            "20年春",
            "19年秋",
            "19年春"});
            this.comboBoxterm.Location = new System.Drawing.Point(207, 172);
            this.comboBoxterm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxterm.Name = "comboBoxterm";
            this.comboBoxterm.Size = new System.Drawing.Size(209, 37);
            this.comboBoxterm.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("碳纤维正粗黑简体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(725, 465);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 51);
            this.button2.TabIndex = 25;
            this.button2.Text = "开设课程";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxclass
            // 
            this.textBoxclass.Location = new System.Drawing.Point(695, 82);
            this.textBoxclass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxclass.Name = "textBoxclass";
            this.textBoxclass.Size = new System.Drawing.Size(209, 35);
            this.textBoxclass.TabIndex = 24;
            // 
            // textBoxteacher
            // 
            this.textBoxteacher.Location = new System.Drawing.Point(207, 82);
            this.textBoxteacher.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxteacher.Name = "textBoxteacher";
            this.textBoxteacher.Size = new System.Drawing.Size(209, 35);
            this.textBoxteacher.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("碳纤维正粗黑简体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(568, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 39);
            this.label3.TabIndex = 22;
            this.label3.Text = "课程";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("碳纤维正粗黑简体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(90, 175);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 39);
            this.label6.TabIndex = 21;
            this.label6.Text = "学期";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("碳纤维正粗黑简体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(58, 85);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 39);
            this.label7.TabIndex = 20;
            this.label7.Text = "教师号";
            // 
            // comboBoxtime
            // 
            this.comboBoxtime.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.comboBoxtime.Font = new System.Drawing.Font("碳纤维正粗黑简体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxtime.FormattingEnabled = true;
            this.comboBoxtime.Items.AddRange(new object[] {
            "周一第1-2节",
            "周一第3-5节",
            "周一第7-9节",
            "周一第11-13节",
            "周二第1-2节",
            "周二第3-5节",
            "周二第7-9节",
            "周二第11-13节",
            "周三第1-2节",
            "周三第3-5节",
            "周三第7-9节",
            "周三第11-13节",
            "周四第1-2节",
            "周四第3-5节",
            "周四第7-9节",
            "周四第11-13节",
            "周五第1-2节",
            "周五第3-5节",
            "周五第7-9节",
            "周五第11-13节"});
            this.comboBoxtime.Location = new System.Drawing.Point(207, 264);
            this.comboBoxtime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxtime.Name = "comboBoxtime";
            this.comboBoxtime.Size = new System.Drawing.Size(209, 37);
            this.comboBoxtime.TabIndex = 37;
            // 
            // UC_courseinformation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.comboBoxtime);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxdidian);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxterm);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxclass);
            this.Controls.Add(this.textBoxteacher);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Name = "UC_courseinformation";
            this.Size = new System.Drawing.Size(1006, 610);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxdidian;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxterm;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxclass;
        private System.Windows.Forms.TextBox textBoxteacher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxtime;
    }
}
