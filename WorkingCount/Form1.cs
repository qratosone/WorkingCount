using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkingCount
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private int read=0, choice=0, code=0;

        private void btnAccess_Click(object sender, EventArgs e)
        {
            Analysis judge = new Analysis();
            analysis = judge;
            judge.input = txtInput.Text;
            judge.GetCount();
            read = judge.count_read;
            choice = judge.count_choice;
            code = judge.count_code;
            UpdateLabel();
        }
        public void UpdateLabel()
        {
            lblCount.Text = "本章计数：阅读 " + read.ToString() + " 选择 " + choice.ToString() + " 代码 " + code.ToString();
        }
        private Analysis analysis = null;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
