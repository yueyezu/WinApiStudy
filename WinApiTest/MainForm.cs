using System;
using System.Text;
using System.Windows.Forms;
using WinApiTest.Core;

namespace WinApiTest
{
    public partial class MainForm : Form
    {
        private IntPtr winPtr;
        private IntPtr txtPtr;


        public MainForm()
        {
            InitializeComponent();
        }

        #region 内部方法

        private void AddResult(string res)
        {
            txtResult.AppendText(res);
            txtResult.AppendText(Environment.NewLine);
        }

        #endregion


        private void btnGetWindow_Click(object sender, EventArgs e)
        {
            winPtr = WinApi.FindWindow(null, txtWinName.Text);
            if (winPtr == IntPtr.Zero)
            {
                AddResult("findWindow error!");
                return;
            }
            AddResult("findWindow:" + winPtr + Environment.NewLine);


            txtPtr = WinApi.FindWindowEx(winPtr, IntPtr.Zero, txtClassName.Text, null);

            while (txtPtr != IntPtr.Zero)
            {
                AddResult("findWindowEx:" + txtPtr);

                int len = WinApi.GetWindowTextLength(txtPtr);
                AddResult("读取到文本长度：" + len);

                StringBuilder text = new StringBuilder(256);
                WinApi.GetWindowText(txtPtr, text, text.Capacity);
                AddResult("读取到文本：" + text);

                string text2 = WinApi.GetWindowText(txtPtr);
                AddResult("读取到文本：" + text2);

                if (text2.Contains("我就是测试"))
                {
                    break;
                }
                else
                {
                    WinApi.SetWindowText1(txtPtr, "我试试可以不可以");
                }

                txtPtr = WinApi.FindWindowEx(winPtr, txtPtr, txtClassName.Text, null);
            }
        }

        private void btnGetByxy_Click(object sender, EventArgs e)
        {

        }

        private void btnClearResult_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
        }
    }
}
