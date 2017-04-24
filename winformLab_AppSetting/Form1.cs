using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformLab_AppSetting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //# 取得參數
            textBox1.Text = Properties.Settings.Default.Setting1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //# 變更參數
            // 注意：Properties scope(範圍）需是：user (使用者)才能變更。
            Properties.Settings.Default.Setting1 = textBox1.Text;
            //# 儲存參數
            Properties.Settings.Default.Save();
        }

    }
}
