using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoForm
{
    public partial class DemoForm : Form
    {
        public DemoForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("点击了确定", "提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
