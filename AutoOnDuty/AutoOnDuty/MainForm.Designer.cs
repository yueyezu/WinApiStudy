namespace AutoOnDuty
{
    partial class MainForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblWindowName = new System.Windows.Forms.Label();
            this.TxtWindowName = new System.Windows.Forms.TextBox();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtSpan = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSpan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtResult);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "信息显示";
            // 
            // txtResult
            // 
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Location = new System.Drawing.Point(3, 17);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(411, 155);
            this.txtResult.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(25, 94);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "开始监听";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblWindowName
            // 
            this.lblWindowName.AutoSize = true;
            this.lblWindowName.Location = new System.Drawing.Point(47, 24);
            this.lblWindowName.Name = "lblWindowName";
            this.lblWindowName.Size = new System.Drawing.Size(53, 12);
            this.lblWindowName.TabIndex = 2;
            this.lblWindowName.Text = "窗口名称";
            // 
            // TxtWindowName
            // 
            this.TxtWindowName.Location = new System.Drawing.Point(113, 20);
            this.TxtWindowName.Name = "TxtWindowName";
            this.TxtWindowName.Size = new System.Drawing.Size(182, 21);
            this.TxtWindowName.TabIndex = 3;
            this.TxtWindowName.Text = "809查岗";
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(330, 123);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(75, 23);
            this.btnClearLog.TabIndex = 1;
            this.btnClearLog.Text = "清理日志";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(122, 94);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "结束监听";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtSpan
            // 
            this.txtSpan.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txtSpan.Location = new System.Drawing.Point(113, 61);
            this.txtSpan.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtSpan.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txtSpan.Name = "txtSpan";
            this.txtSpan.Size = new System.Drawing.Size(182, 21);
            this.txtSpan.TabIndex = 4;
            this.txtSpan.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "检测间隔(秒)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "测试处理";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 310);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSpan);
            this.Controls.Add(this.TxtWindowName);
            this.Controls.Add(this.lblWindowName);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "查岗回复";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSpan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblWindowName;
        private System.Windows.Forms.TextBox TxtWindowName;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.NumericUpDown txtSpan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

