﻿namespace RunCopy
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.button1 = new System.Windows.Forms.Button();
			this.progressBarX1 = new DevComponents.DotNetBar.Controls.ProgressBarX();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
			this.folderBrowserDialog1 = new FileBorserDialog.FolderBrowserDialog();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(336, 25);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "選擇目錄";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.ctrlCopy_Click);
			// 
			// progressBarX1
			// 
			// 
			// 
			// 
			this.progressBarX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.progressBarX1.Location = new System.Drawing.Point(27, 135);
			this.progressBarX1.Name = "progressBarX1";
			this.progressBarX1.Size = new System.Drawing.Size(465, 23);
			this.progressBarX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.progressBarX1.TabIndex = 2;
			this.progressBarX1.Text = "0%";
			this.progressBarX1.TextVisible = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(96, 26);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(234, 23);
			this.textBox1.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 16);
			this.label1.TabIndex = 4;
			this.label1.Text = "還原路徑：";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(417, 26);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "開始";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// backgroundWorker1
			// 
			this.backgroundWorker1.WorkerReportsProgress = true;
			this.backgroundWorker1.WorkerSupportsCancellation = true;
			this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
			this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(27, 111);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(346, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "等待...";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(27, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 16);
			this.label3.TabIndex = 7;
			this.label3.Text = "備份路徑：";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(96, 69);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(234, 23);
			this.textBox2.TabIndex = 8;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(336, 69);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 9;
			this.button3.Text = "選擇目錄";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(419, 70);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 10;
			this.button4.Text = "開始";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// backgroundWorker2
			// 
			this.backgroundWorker2.WorkerReportsProgress = true;
			this.backgroundWorker2.WorkerSupportsCancellation = true;
			this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
			this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
			this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
			// 
			// folderBrowserDialog1
			// 
			this.folderBrowserDialog1.DirectoryPath = null;
			// 
			// Form1
			// 
			this.ClientSize = new System.Drawing.Size(506, 173);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.progressBarX1);
			this.Controls.Add(this.button1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Activated += new System.EventHandler(this.Form1_Activated);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ctrlCopy_;
        private System.Windows.Forms.Button button1;
        private DevComponents.DotNetBar.Controls.ProgressBarX progressBarX1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private FileBorserDialog.FolderBrowserDialog folderBrowserDialog1;
    }
}

