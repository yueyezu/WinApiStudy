using System;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Threading;
using AutoOnDuty.Common;

namespace AutoOnDuty
{
    public delegate void AddThreadRes(string message);

    public class ListenerThread
    {
        private static BackgroundWorker listenerWorker;
        private AddThreadRes addThreadRes;
        private int checkSpan = 120 * 1000; // 默认120秒检测一次
        private string winName;

        #region 单例及初始化

        /// <summary>
        ///     私有的实现实体
        /// </summary>
        private static ListenerThread instance;

        /// <summary>
        ///     默认的构造函数
        /// </summary>
        private ListenerThread()
        {
            //初始化AGV执行检测的线程
            listenerWorker = new BackgroundWorker();
            listenerWorker.WorkerReportsProgress = true;
            listenerWorker.WorkerSupportsCancellation = true;
            listenerWorker.DoWork += listenerWorkerDoWork;
            listenerWorker.ProgressChanged += ListenerWorkerOnProgressChanged;
        }

        /// <summary>
        ///     获取单例实例
        /// </summary>
        /// <returns></returns>
        public static ListenerThread GetInstance()
        {
            if (instance == null)
            {
                instance = new ListenerThread();
            }
            return instance;
        }


        public void SetProcess(AddThreadRes addRes)
        {
            this.addThreadRes = addRes;
        }

        public void SetCheckParam(string winName, int span = 120 * 1000)
        {
            this.winName = winName;
            this.checkSpan = span;
        }

        #endregion

        #region 线程执行相关的操作

        private void listenerWorkerDoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                try
                {
                    //加入取消线程终止的点
                    if (listenerWorker.CancellationPending)
                    {
                        listenerWorker.ReportProgress(100, "检测线程执行手动停止！");
                        e.Cancel = true;
                        break;
                    }

                    // 检查并回答
                    Check809();

                    Thread.Sleep(checkSpan);
                }
                catch (Exception ex)
                {
                    listenerWorker.ReportProgress(0, "检查出现问题：" + ex.Message);
                    LogHelp.LogErrorMsg(ex.ToString(), "");
                }
            }
        }

        /// <summary>
        ///     报告线程执行状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="progressChangedEventArgs"></param>
        private void ListenerWorkerOnProgressChanged(object sender, ProgressChangedEventArgs progressChangedEventArgs)
        {
            if (addThreadRes != null)
            {
                var status = progressChangedEventArgs.UserState as string;
                addThreadRes(status);
            }
        }

        /// <summary>
        ///     启动检测的线程
        /// </summary>
        /// <returns></returns>
        public bool StartBackwork()
        {
            if (!listenerWorker.IsBusy)
            {
                listenerWorker.RunWorkerAsync();
            }
            return true;
        }

        /// <summary>
        ///     取消检测线程
        /// </summary>
        /// <returns></returns>
        public bool CancelBackwork()
        {
            if (listenerWorker.IsBusy && !listenerWorker.CancellationPending)
            {
                listenerWorker.CancelAsync();
            }
            return true;
        }

        #endregion


        #region 809查岗窗口分析

        /// <summary>
        ///  进行窗口检测
        /// </summary>
        public void Check809()
        {
            //1 查找809查岗主窗口
            IntPtr pwinPtr = WinApi.FindWindow(null, winName);
            if (pwinPtr == IntPtr.Zero)
            {
                addThreadRes("未发现‘" + winName + "’窗口");
                return;
            }
            addThreadRes("发现‘" + winName + "’窗口");

            //2 枚举所有子窗口，然后找特征控件定位需要的所有组件
            IntPtr btnPtr = IntPtr.Zero;
            WinApi.EnumChildWindows(pwinPtr, (h, l) =>
            {
                if (h == IntPtr.Zero) return false;

                StringBuilder text = new StringBuilder(256);
                WinApi.GetWindowText(h, text, text.Capacity);
                LogHelp.Log(string.Format("列举所有子控件：{0:X8}， 内容：{1}", h, text));

                if (text.ToString().Contains("确定") || text.ToString().Contains("设置"))
                {
                    btnPtr = h;
                    return false;
                }

                return true;
            }, 0);
            if (btnPtr == IntPtr.Zero)
            {
                addThreadRes("未找确定/设置按钮,检测项已不一致，请重新调整！");
                return;
            }
            addThreadRes(string.Format("找到确定/设置按钮:{0:X8}", btnPtr));

            //3 获取主要操作窗体
            IntPtr winPtr = WinApi.GetParent(btnPtr);
            addThreadRes(string.Format("获取到问题窗口:{0:X8}", winPtr));

            //4 在获取窗体上，获取问题，并标记回答
            GetQuestionAndAnswer(winPtr);

            //5 点击按钮 TODO 临时注释掉
            // WinApi.SendMessage(btnPtr, ApiCode.WM_CLICK, 0, 0);
        }

        /// <summary>
        ///  在问题窗口，获取问题，并且进行回答
        /// </summary>
        private void GetQuestionAndAnswer(IntPtr winPtr)
        {
            IntPtr rtxrPtr = IntPtr.Zero;
            string question = "";

            // 提取问题，同时查找回答的文本框
            IntPtr tempPtr = WinApi.FindWindowEx(winPtr, IntPtr.Zero, "Edit", null);
            while (tempPtr != IntPtr.Zero)
            {
                String text = WinApi.GetWindowText(tempPtr);
                LogHelp.Log(string.Format("列举查找所有文本框:{0:X8}, 内容：{1}", tempPtr, text));

                if (text.Contains("查岗"))
                {
                    question = text;
                    addThreadRes(string.Format("找到问题文本框:{0:X8}, 内容：{1}", tempPtr, text));
                }
                else
                {
                    //TODO 如何找回答文本框需要考虑下

                    rtxrPtr = tempPtr;
                    LogHelp.Log(string.Format("找到回答文本框:{0:X8}, 内容：{1}", rtxrPtr, text));
                }
                tempPtr = WinApi.FindWindowEx(winPtr, tempPtr, "Edit", null);
            }

            // 写入结果
            if (rtxrPtr == IntPtr.Zero)
            {
                LogHelp.Log("未找到回答文本框,检测项已不一致,请重新调整!");
                return;
            }

            // 问题进行提取计算
            var result = Calculate(question);

            WinApi.SetWindowTextSend(rtxrPtr, result);
            addThreadRes(string.Format("结果写入{0}完成：{1}", rtxrPtr, result));
        }

        /// <summary>
        /// 根据获取的公式文本，进行分析计算
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        public string Calculate(string question)
        {
            question = question.Replace("：", ":");
            question = question.Substring(question.LastIndexOf(":", StringComparison.Ordinal) + 1);
            question = question.Replace("=", "").Replace("?", "").Replace("？", "");

            addThreadRes("提取公式：" + question);

            object res = new DataTable().Compute(question, "");

            string calRes = res.ToString();

            addThreadRes("问题计算结果：" + calRes);
            return calRes;
        }


        #endregion
    }
}