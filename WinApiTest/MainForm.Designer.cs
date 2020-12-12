namespace WinApiTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtWinName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWinX = new System.Windows.Forms.TextBox();
            this.txtWinY = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGetWindow = new System.Windows.Forms.Button();
            this.btnGetByxy = new System.Windows.Forms.Button();
            this.btnGetTitle = new System.Windows.Forms.Button();
            this.btnGetPosition = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClearResult = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "窗口名称";
            // 
            // txtWinName
            // 
            this.txtWinName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWinName.Location = new System.Drawing.Point(104, 15);
            this.txtWinName.Name = "txtWinName";
            this.txtWinName.Size = new System.Drawing.Size(230, 21);
            this.txtWinName.TabIndex = 1;
            this.txtWinName.Text = "测试窗口";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "窗口位置";
            // 
            // txtWinX
            // 
            this.txtWinX.Location = new System.Drawing.Point(104, 42);
            this.txtWinX.Name = "txtWinX";
            this.txtWinX.Size = new System.Drawing.Size(97, 21);
            this.txtWinX.TabIndex = 1;
            // 
            // txtWinY
            // 
            this.txtWinY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWinY.Location = new System.Drawing.Point(237, 42);
            this.txtWinY.Name = "txtWinY";
            this.txtWinY.Size = new System.Drawing.Size(97, 21);
            this.txtWinY.TabIndex = 1;
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Location = new System.Drawing.Point(6, 20);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(412, 127);
            this.txtResult.TabIndex = 2;
            this.txtResult.WordWrap = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtResult);
            this.groupBox1.Location = new System.Drawing.Point(12, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 153);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "结果";
            // 
            // btnGetWindow
            // 
            this.btnGetWindow.Location = new System.Drawing.Point(355, 15);
            this.btnGetWindow.Name = "btnGetWindow";
            this.btnGetWindow.Size = new System.Drawing.Size(75, 23);
            this.btnGetWindow.TabIndex = 4;
            this.btnGetWindow.Text = "获取窗口";
            this.btnGetWindow.UseVisualStyleBackColor = true;
            this.btnGetWindow.Click += new System.EventHandler(this.btnGetWindow_Click);
            // 
            // btnGetByxy
            // 
            this.btnGetByxy.Location = new System.Drawing.Point(355, 44);
            this.btnGetByxy.Name = "btnGetByxy";
            this.btnGetByxy.Size = new System.Drawing.Size(75, 23);
            this.btnGetByxy.TabIndex = 4;
            this.btnGetByxy.Text = "获取窗口";
            this.btnGetByxy.UseVisualStyleBackColor = true;
            this.btnGetByxy.Click += new System.EventHandler(this.btnGetByxy_Click);
            // 
            // btnGetTitle
            // 
            this.btnGetTitle.Location = new System.Drawing.Point(104, 117);
            this.btnGetTitle.Name = "btnGetTitle";
            this.btnGetTitle.Size = new System.Drawing.Size(75, 23);
            this.btnGetTitle.TabIndex = 4;
            this.btnGetTitle.Text = "获取标题";
            this.btnGetTitle.UseVisualStyleBackColor = true;
            this.btnGetTitle.Click += new System.EventHandler(this.btnGetWindow_Click);
            // 
            // btnGetPosition
            // 
            this.btnGetPosition.Location = new System.Drawing.Point(199, 117);
            this.btnGetPosition.Name = "btnGetPosition";
            this.btnGetPosition.Size = new System.Drawing.Size(75, 23);
            this.btnGetPosition.TabIndex = 4;
            this.btnGetPosition.Text = "获取位置";
            this.btnGetPosition.UseVisualStyleBackColor = true;
            this.btnGetPosition.Click += new System.EventHandler(this.btnGetWindow_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "类名";
            // 
            // txtClassName
            // 
            this.txtClassName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClassName.Location = new System.Drawing.Point(104, 79);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(230, 21);
            this.txtClassName.TabIndex = 1;
            this.txtClassName.Text = "WindowsForms10.EDIT.app.0.378734a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "窗口操作：";
            // 
            // btnClearResult
            // 
            this.btnClearResult.Location = new System.Drawing.Point(344, 371);
            this.btnClearResult.Name = "btnClearResult";
            this.btnClearResult.Size = new System.Drawing.Size(75, 23);
            this.btnClearResult.TabIndex = 6;
            this.btnClearResult.Text = "清空信息";
            this.btnClearResult.UseVisualStyleBackColor = true;
            this.btnClearResult.Click += new System.EventHandler(this.btnClearResult_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 398);
            this.Controls.Add(this.btnClearResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGetPosition);
            this.Controls.Add(this.btnGetTitle);
            this.Controls.Add(this.btnGetByxy);
            this.Controls.Add(this.btnGetWindow);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtWinY);
            this.Controls.Add(this.txtWinX);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.txtWinName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "主界面";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWinName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWinX;
        private System.Windows.Forms.TextBox txtWinY;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGetWindow;
        private System.Windows.Forms.Button btnGetByxy;
        private System.Windows.Forms.Button btnGetTitle;
        private System.Windows.Forms.Button btnGetPosition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClearResult;
    }
}

