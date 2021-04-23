using System;
using System.Windows.Forms;
using AutoOnDuty.Common;

namespace AutoOnDuty
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     界面加载，进行相关的初始化操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            ListenerThread.GetInstance().SetProcess(AddResult);
        }

        /// <summary>
        ///     往界面输出信息
        /// </summary>
        /// <param name="res"></param>
        private void AddResult(string res)
        {
            if (txtResult.InvokeRequired)
            {
                txtResult.BeginInvoke(new Action(() =>
                {
                    txtResult.AppendText(string.Format("【{0}】 {1}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), res));
                    txtResult.AppendText(Environment.NewLine);
                }));
            }
            else
            {
                txtResult.AppendText(string.Format("【{0}】 {1}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), res));
                txtResult.AppendText(Environment.NewLine);
            }

            LogHelp.Log(res);
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
        }


        /// <summary>
        ///     开始监听窗口的程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            var windowName = TxtWindowName.Text;
            var span = (int)txtSpan.Value;

            ListenerThread.GetInstance().SetCheckParam(windowName, span * 1000);
            AddResult("启动监听线程");
            ListenerThread.GetInstance().StartBackwork();
        }

        /// <summary>
        ///     结束监听窗口的程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            ListenerThread.GetInstance().CancelBackwork();
            AddResult("关闭监听线程");
        }

        // 技术测试用：
        private void button1_Click_1(object sender, EventArgs e)
        {
            var windowName = TxtWindowName.Text;

            ListenerThread.GetInstance().SetCheckParam(windowName);
            ListenerThread.GetInstance().Check809();
        }
    }
}