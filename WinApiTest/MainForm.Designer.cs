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
            this.btnGetByTitle = new System.Windows.Forms.Button();
            this.btnGetByxy = new System.Windows.Forms.Button();
            this.btnGetTitle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.btnClearResult = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnListAllChild = new System.Windows.Forms.Button();
            this.btnSetContent = new System.Windows.Forms.Button();
            this.btnGetContent = new System.Windows.Forms.Button();
            this.btnGetByClass = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGetSubByTitle = new System.Windows.Forms.Button();
            this.btnGetSubByxy = new System.Windows.Forms.Button();
            this.btnGetSubByClass = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnButtonClick = new System.Windows.Forms.Button();
            this.btnGetTextbox = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGetButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "窗口标题";
            // 
            // txtWinName
            // 
            this.txtWinName.Location = new System.Drawing.Point(104, 15);
            this.txtWinName.Name = "txtWinName";
            this.txtWinName.Size = new System.Drawing.Size(203, 21);
            this.txtWinName.TabIndex = 1;
            this.txtWinName.Text = "测试窗口";
            // 
            // label2
            // 
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
            this.txtWinX.Size = new System.Drawing.Size(94, 21);
            this.txtWinX.TabIndex = 1;
            // 
            // txtWinY
            // 
            this.txtWinY.Location = new System.Drawing.Point(216, 42);
            this.txtWinY.Name = "txtWinY";
            this.txtWinY.Size = new System.Drawing.Size(91, 21);
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
            this.txtResult.Size = new System.Drawing.Size(453, 117);
            this.txtResult.TabIndex = 2;
            this.txtResult.WordWrap = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtResult);
            this.groupBox1.Location = new System.Drawing.Point(12, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 143);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "结果";
            // 
            // btnGetByTitle
            // 
            this.btnGetByTitle.Location = new System.Drawing.Point(313, 14);
            this.btnGetByTitle.Name = "btnGetByTitle";
            this.btnGetByTitle.Size = new System.Drawing.Size(75, 23);
            this.btnGetByTitle.TabIndex = 4;
            this.btnGetByTitle.Text = "获取窗口";
            this.btnGetByTitle.UseVisualStyleBackColor = true;
            this.btnGetByTitle.Click += new System.EventHandler(this.btnGetWindow_Click);
            // 
            // btnGetByxy
            // 
            this.btnGetByxy.Location = new System.Drawing.Point(313, 42);
            this.btnGetByxy.Name = "btnGetByxy";
            this.btnGetByxy.Size = new System.Drawing.Size(75, 23);
            this.btnGetByxy.TabIndex = 4;
            this.btnGetByxy.Text = "获取窗口";
            this.btnGetByxy.UseVisualStyleBackColor = true;
            this.btnGetByxy.Click += new System.EventHandler(this.btnGetByxy_Click);
            // 
            // btnGetTitle
            // 
            this.btnGetTitle.Location = new System.Drawing.Point(3, 7);
            this.btnGetTitle.Name = "btnGetTitle";
            this.btnGetTitle.Size = new System.Drawing.Size(75, 23);
            this.btnGetTitle.TabIndex = 4;
            this.btnGetTitle.Text = "获取标题";
            this.btnGetTitle.UseVisualStyleBackColor = true;
            this.btnGetTitle.Click += new System.EventHandler(this.btnGetTitle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "类名";
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(104, 73);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(203, 21);
            this.txtClassName.TabIndex = 1;
            // 
            // btnClearResult
            // 
            this.btnClearResult.Location = new System.Drawing.Point(402, 370);
            this.btnClearResult.Name = "btnClearResult";
            this.btnClearResult.Size = new System.Drawing.Size(75, 23);
            this.btnClearResult.TabIndex = 6;
            this.btnClearResult.Text = "清空信息";
            this.btnClearResult.UseVisualStyleBackColor = true;
            this.btnClearResult.Click += new System.EventHandler(this.btnClearResult_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnListAllChild);
            this.panel1.Controls.Add(this.btnGetTitle);
            this.panel1.Location = new System.Drawing.Point(90, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 35);
            this.panel1.TabIndex = 7;
            // 
            // btnListAllChild
            // 
            this.btnListAllChild.Location = new System.Drawing.Point(103, 7);
            this.btnListAllChild.Name = "btnListAllChild";
            this.btnListAllChild.Size = new System.Drawing.Size(75, 23);
            this.btnListAllChild.TabIndex = 4;
            this.btnListAllChild.Text = "列举子窗口";
            this.btnListAllChild.UseVisualStyleBackColor = true;
            this.btnListAllChild.Click += new System.EventHandler(this.btnListAllChild_Click);
            // 
            // btnSetContent
            // 
            this.btnSetContent.Location = new System.Drawing.Point(293, 162);
            this.btnSetContent.Name = "btnSetContent";
            this.btnSetContent.Size = new System.Drawing.Size(75, 23);
            this.btnSetContent.TabIndex = 4;
            this.btnSetContent.Text = "设置内容";
            this.btnSetContent.UseVisualStyleBackColor = true;
            this.btnSetContent.Click += new System.EventHandler(this.btnSetContent_Click);
            // 
            // btnGetContent
            // 
            this.btnGetContent.Location = new System.Drawing.Point(193, 162);
            this.btnGetContent.Name = "btnGetContent";
            this.btnGetContent.Size = new System.Drawing.Size(75, 23);
            this.btnGetContent.TabIndex = 4;
            this.btnGetContent.Text = "获取内容";
            this.btnGetContent.UseVisualStyleBackColor = true;
            this.btnGetContent.Click += new System.EventHandler(this.btnGetContent_Click);
            // 
            // btnGetByClass
            // 
            this.btnGetByClass.Location = new System.Drawing.Point(313, 73);
            this.btnGetByClass.Name = "btnGetByClass";
            this.btnGetByClass.Size = new System.Drawing.Size(75, 23);
            this.btnGetByClass.TabIndex = 4;
            this.btnGetByClass.Text = "获取窗口";
            this.btnGetByClass.UseVisualStyleBackColor = true;
            this.btnGetByClass.Click += new System.EventHandler(this.btnGetByClass_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "窗口操作：";
            // 
            // btnGetSubByTitle
            // 
            this.btnGetSubByTitle.Location = new System.Drawing.Point(394, 14);
            this.btnGetSubByTitle.Name = "btnGetSubByTitle";
            this.btnGetSubByTitle.Size = new System.Drawing.Size(75, 23);
            this.btnGetSubByTitle.TabIndex = 4;
            this.btnGetSubByTitle.Text = "获取子窗口";
            this.btnGetSubByTitle.UseVisualStyleBackColor = true;
            this.btnGetSubByTitle.Click += new System.EventHandler(this.btnGetWindow_Click);
            // 
            // btnGetSubByxy
            // 
            this.btnGetSubByxy.Location = new System.Drawing.Point(394, 42);
            this.btnGetSubByxy.Name = "btnGetSubByxy";
            this.btnGetSubByxy.Size = new System.Drawing.Size(75, 23);
            this.btnGetSubByxy.TabIndex = 4;
            this.btnGetSubByxy.Text = "获取子窗口";
            this.btnGetSubByxy.UseVisualStyleBackColor = true;
            this.btnGetSubByxy.Click += new System.EventHandler(this.btnGetByxy_Click);
            // 
            // btnGetSubByClass
            // 
            this.btnGetSubByClass.Location = new System.Drawing.Point(394, 73);
            this.btnGetSubByClass.Name = "btnGetSubByClass";
            this.btnGetSubByClass.Size = new System.Drawing.Size(75, 23);
            this.btnGetSubByClass.TabIndex = 4;
            this.btnGetSubByClass.Text = "获取子窗口";
            this.btnGetSubByClass.UseVisualStyleBackColor = true;
            this.btnGetSubByClass.Click += new System.EventHandler(this.btnGetSubByClass_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "按钮操作";
            // 
            // btnButtonClick
            // 
            this.btnButtonClick.Location = new System.Drawing.Point(193, 197);
            this.btnButtonClick.Name = "btnButtonClick";
            this.btnButtonClick.Size = new System.Drawing.Size(75, 23);
            this.btnButtonClick.TabIndex = 9;
            this.btnButtonClick.Text = "触发点击";
            this.btnButtonClick.UseVisualStyleBackColor = true;
            this.btnButtonClick.Click += new System.EventHandler(this.btnButtonClick_Click);
            // 
            // btnGetTextbox
            // 
            this.btnGetTextbox.Location = new System.Drawing.Point(93, 162);
            this.btnGetTextbox.Name = "btnGetTextbox";
            this.btnGetTextbox.Size = new System.Drawing.Size(75, 23);
            this.btnGetTextbox.TabIndex = 4;
            this.btnGetTextbox.Text = "获取文本框";
            this.btnGetTextbox.UseVisualStyleBackColor = true;
            this.btnGetTextbox.Click += new System.EventHandler(this.btnGetTextbox_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "文本操作";
            // 
            // btnGetButton
            // 
            this.btnGetButton.Location = new System.Drawing.Point(93, 197);
            this.btnGetButton.Name = "btnGetButton";
            this.btnGetButton.Size = new System.Drawing.Size(75, 23);
            this.btnGetButton.TabIndex = 4;
            this.btnGetButton.Text = "获取按钮";
            this.btnGetButton.UseVisualStyleBackColor = true;
            this.btnGetButton.Click += new System.EventHandler(this.btnGetButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 403);
            this.Controls.Add(this.btnButtonClick);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGetButton);
            this.Controls.Add(this.btnGetTextbox);
            this.Controls.Add(this.btnGetContent);
            this.Controls.Add(this.btnSetContent);
            this.Controls.Add(this.btnClearResult);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGetSubByClass);
            this.Controls.Add(this.btnGetSubByxy);
            this.Controls.Add(this.btnGetByClass);
            this.Controls.Add(this.btnGetSubByTitle);
            this.Controls.Add(this.btnGetByxy);
            this.Controls.Add(this.btnGetByTitle);
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
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnGetByTitle;
        private System.Windows.Forms.Button btnGetByxy;
        private System.Windows.Forms.Button btnGetTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Button btnClearResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnListAllChild;
        private System.Windows.Forms.Button btnGetByClass;
        private System.Windows.Forms.Button btnGetContent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGetSubByTitle;
        private System.Windows.Forms.Button btnGetSubByxy;
        private System.Windows.Forms.Button btnGetSubByClass;
        private System.Windows.Forms.Button btnSetContent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnButtonClick;
        private System.Windows.Forms.Button btnGetTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGetButton;
    }
}

