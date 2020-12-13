using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinApiTest.Core;

namespace WinApiTest
{
    public partial class MainForm : Form
    {

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

        private void btnClearResult_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
        }

        #region 窗口
        private IntPtr winPtr;
        private IntPtr childPtr;

        private void btnGetWindow_Click(object sender, EventArgs e)
        {
            winPtr = WinApi.FindWindow(null, txtWinName.Text);
            if (winPtr == IntPtr.Zero)
            {
                AddResult("findWindow error!");
                return;
            }
            AddResult("findWindow:" + winPtr);
        }

        private void btnGetByxy_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(txtWinX.Text);
            int y = Int32.Parse(txtWinY.Text);

            Point point = new Point(x, y);
            winPtr = WinApi.WindowFromPoint(point);

            if (winPtr == IntPtr.Zero)
            {
                AddResult("findWindow error!");
                return;
            }
            AddResult("findWindow:" + winPtr);
        }

        private void btnGetByClass_Click(object sender, EventArgs e)
        {

        }

        private void btnGetSubByClass_Click(object sender, EventArgs e)
        {
            childPtr = WinApi.FindWindowEx(winPtr, IntPtr.Zero, txtClassName.Text, null);
            while (childPtr != IntPtr.Zero)
            {
                AddResult("findWindowEx:" + childPtr);

                childPtr = WinApi.FindWindowEx(winPtr, childPtr, txtClassName.Text, null);
            }
        }


        private void btnListAllChild_Click(object sender, EventArgs e)
        {
            WinApi.EnumChildWindows(winPtr, (h, l) =>
            {
                if (h == IntPtr.Zero)
                    return false;

                StringBuilder text = new StringBuilder(256);
                WinApi.GetWindowText(h, text, text.Capacity);
                AddResult("列举子窗口：" + h + "， 文本：" + text);
                return true;
            }, 0);
        }

        private void btnGetPosition_Click(object sender, EventArgs e)
        {

        }

        private void btnGetTitle_Click(object sender, EventArgs e)
        {
            int len = WinApi.GetWindowTextLength(childPtr);
            AddResult("读取到文本长度：" + len);

            StringBuilder text = new StringBuilder(256);
            WinApi.GetWindowText(childPtr, text, text.Capacity);
            AddResult("读取到文本：" + text);
        }

        #endregion

        #region 文本框

        private IntPtr textPtr;
        private string textBoxClass = "WindowsForms10.EDIT.app.0.378734a";

        private void btnGetTextbox_Click(object sender, EventArgs e)
        {
            textPtr = WinApi.FindWindowEx(winPtr, IntPtr.Zero, textBoxClass, null);
            while (textPtr != IntPtr.Zero)
            {
                string text = WinApi.GetWindowText(textPtr);
                AddResult("findTextBoxEx:" + textPtr + ",文本：" + text);

                // TODO 需要完善获取最终文本的条件
                if (text.Contains("公式"))
                {
                    break;
                }

                textPtr = WinApi.FindWindowEx(winPtr, textPtr, textBoxClass, null);
            }
        }

        private void btnGetContent_Click(object sender, EventArgs e)
        {
            string text = WinApi.GetWindowText(textPtr);
            AddResult("读取到文本：" + text);
        }

        private void btnSetContent_Click(object sender, EventArgs e)
        {
            WinApi.SetWindowTextSend(textPtr, "我试试可以不可以");
        }

        #endregion


        #region 按钮

        private IntPtr btnPtr;
        private string buttonClass = "WindowsForms10.BUTTON.app.0.378734a";

        private void btnGetButton_Click(object sender, EventArgs e)
        {
            btnPtr = WinApi.FindWindowEx(winPtr, IntPtr.Zero, buttonClass, null);
            while (btnPtr != IntPtr.Zero)
            {
                string text = WinApi.GetWindowText(btnPtr);
                AddResult("findButtonEx:" + btnPtr + ",文本：" + text);

                // TODO 需要完善获取最终文本的条件
                if (text == "确定")
                {
                    break;
                }
                btnPtr = WinApi.FindWindowEx(winPtr, btnPtr, buttonClass, null);
            }
        }

        private void btnButtonClick_Click(object sender, EventArgs e)
        {
            WinApi.SendMessage(btnPtr, ApiCode.WM_CLICK, 0, 0);
        }

        #endregion


    }
}
