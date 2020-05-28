namespace FormatConverterTool
{
    partial class Main
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.browserSaveFilePathBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.saveConvertedFilePath = new System.Windows.Forms.TextBox();
            this.saveFilePathDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.singleFileConverter = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fileSrcPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.multiFilesConverter = new System.Windows.Forms.TabPage();
            this.aboutMe = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.startToConvertBtn = new System.Windows.Forms.Button();
            this.multiFileSrcPathTxb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.formatName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.multiFileSrcPathBtn = new System.Windows.Forms.Button();
            this.multiFileTarPathBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.multiFileTarPathTxb = new System.Windows.Forms.TextBox();
            this.convertResult = new System.Windows.Forms.TextBox();
            this.multiConvertBtn = new System.Windows.Forms.Button();
            this.multiFileFormat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.singleFileConverter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.multiFilesConverter.SuspendLayout();
            this.aboutMe.SuspendLayout();
            this.SuspendLayout();
            // 
            // browserSaveFilePathBtn
            // 
            this.browserSaveFilePathBtn.Location = new System.Drawing.Point(284, 24);
            this.browserSaveFilePathBtn.Name = "browserSaveFilePathBtn";
            this.browserSaveFilePathBtn.Size = new System.Drawing.Size(75, 23);
            this.browserSaveFilePathBtn.TabIndex = 0;
            this.browserSaveFilePathBtn.Text = "浏览...";
            this.browserSaveFilePathBtn.UseVisualStyleBackColor = true;
            this.browserSaveFilePathBtn.Click += new System.EventHandler(this.browserSaveFilePathBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "转换后视频保存位置：";
            // 
            // saveConvertedFilePath
            // 
            this.saveConvertedFilePath.Location = new System.Drawing.Point(15, 25);
            this.saveConvertedFilePath.Name = "saveConvertedFilePath";
            this.saveConvertedFilePath.Size = new System.Drawing.Size(271, 21);
            this.saveConvertedFilePath.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.singleFileConverter);
            this.tabControl1.Controls.Add(this.multiFilesConverter);
            this.tabControl1.Controls.Add(this.aboutMe);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 2;
            // 
            // singleFileConverter
            // 
            this.singleFileConverter.AllowDrop = true;
            this.singleFileConverter.Controls.Add(this.formatName);
            this.singleFileConverter.Controls.Add(this.label6);
            this.singleFileConverter.Controls.Add(this.startToConvertBtn);
            this.singleFileConverter.Controls.Add(this.panel1);
            this.singleFileConverter.Controls.Add(this.label1);
            this.singleFileConverter.Controls.Add(this.saveConvertedFilePath);
            this.singleFileConverter.Controls.Add(this.browserSaveFilePathBtn);
            this.singleFileConverter.Location = new System.Drawing.Point(4, 22);
            this.singleFileConverter.Name = "singleFileConverter";
            this.singleFileConverter.Padding = new System.Windows.Forms.Padding(10);
            this.singleFileConverter.Size = new System.Drawing.Size(768, 400);
            this.singleFileConverter.TabIndex = 0;
            this.singleFileConverter.Text = "单文件转换";
            this.singleFileConverter.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.fileSrcPath);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(15, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 334);
            this.panel1.TabIndex = 2;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            this.panel1.DragOver += new System.Windows.Forms.DragEventHandler(this.panel1_DragOver);
            // 
            // fileSrcPath
            // 
            this.fileSrcPath.BackColor = System.Drawing.Color.White;
            this.fileSrcPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fileSrcPath.ForeColor = System.Drawing.SystemColors.GrayText;
            this.fileSrcPath.Location = new System.Drawing.Point(42, 160);
            this.fileSrcPath.Name = "fileSrcPath";
            this.fileSrcPath.ReadOnly = true;
            this.fileSrcPath.Size = new System.Drawing.Size(655, 14);
            this.fileSrcPath.TabIndex = 1;
            this.fileSrcPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(282, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "拖拽FLV视频文件到此处";
            // 
            // multiFilesConverter
            // 
            this.multiFilesConverter.Controls.Add(this.multiFileFormat);
            this.multiFilesConverter.Controls.Add(this.label9);
            this.multiFilesConverter.Controls.Add(this.multiConvertBtn);
            this.multiFilesConverter.Controls.Add(this.convertResult);
            this.multiFilesConverter.Controls.Add(this.multiFileTarPathBtn);
            this.multiFilesConverter.Controls.Add(this.label8);
            this.multiFilesConverter.Controls.Add(this.multiFileTarPathTxb);
            this.multiFilesConverter.Controls.Add(this.multiFileSrcPathBtn);
            this.multiFilesConverter.Controls.Add(this.label7);
            this.multiFilesConverter.Controls.Add(this.multiFileSrcPathTxb);
            this.multiFilesConverter.Location = new System.Drawing.Point(4, 22);
            this.multiFilesConverter.Name = "multiFilesConverter";
            this.multiFilesConverter.Padding = new System.Windows.Forms.Padding(10);
            this.multiFilesConverter.Size = new System.Drawing.Size(768, 400);
            this.multiFilesConverter.TabIndex = 1;
            this.multiFilesConverter.Text = "批量转换";
            this.multiFilesConverter.UseVisualStyleBackColor = true;
            // 
            // aboutMe
            // 
            this.aboutMe.Controls.Add(this.label5);
            this.aboutMe.Controls.Add(this.label4);
            this.aboutMe.Controls.Add(this.label3);
            this.aboutMe.Location = new System.Drawing.Point(4, 22);
            this.aboutMe.Name = "aboutMe";
            this.aboutMe.Size = new System.Drawing.Size(768, 400);
            this.aboutMe.TabIndex = 2;
            this.aboutMe.Text = "关于";
            this.aboutMe.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "感谢开源软件FFmpeg提供视频转换技术";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(323, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "关于工具问题，可联系微博：@innerpeaceGuan（点击复制）";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "@GDY 2020";
            // 
            // startToConvertBtn
            // 
            this.startToConvertBtn.Location = new System.Drawing.Point(646, 10);
            this.startToConvertBtn.Name = "startToConvertBtn";
            this.startToConvertBtn.Size = new System.Drawing.Size(108, 37);
            this.startToConvertBtn.TabIndex = 3;
            this.startToConvertBtn.Text = "开始转换";
            this.startToConvertBtn.UseVisualStyleBackColor = true;
            this.startToConvertBtn.Click += new System.EventHandler(this.startToConvertBtn_Click);
            // 
            // multiFileSrcPathTxb
            // 
            this.multiFileSrcPathTxb.Location = new System.Drawing.Point(15, 25);
            this.multiFileSrcPathTxb.Name = "multiFileSrcPathTxb";
            this.multiFileSrcPathTxb.Size = new System.Drawing.Size(171, 21);
            this.multiFileSrcPathTxb.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(393, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "要转换的格式";
            // 
            // formatName
            // 
            this.formatName.Enabled = false;
            this.formatName.Location = new System.Drawing.Point(395, 24);
            this.formatName.Name = "formatName";
            this.formatName.Size = new System.Drawing.Size(100, 21);
            this.formatName.TabIndex = 6;
            this.formatName.Text = ".mp4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(15, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "要转换的视频位置：";
            // 
            // multiFileSrcPathBtn
            // 
            this.multiFileSrcPathBtn.Location = new System.Drawing.Point(185, 24);
            this.multiFileSrcPathBtn.Name = "multiFileSrcPathBtn";
            this.multiFileSrcPathBtn.Size = new System.Drawing.Size(75, 23);
            this.multiFileSrcPathBtn.TabIndex = 2;
            this.multiFileSrcPathBtn.Text = "浏览...";
            this.multiFileSrcPathBtn.UseVisualStyleBackColor = true;
            this.multiFileSrcPathBtn.Click += new System.EventHandler(this.multiFileSrcPathBtn_Click);
            // 
            // multiFileTarPathBtn
            // 
            this.multiFileTarPathBtn.Location = new System.Drawing.Point(436, 23);
            this.multiFileTarPathBtn.Name = "multiFileTarPathBtn";
            this.multiFileTarPathBtn.Size = new System.Drawing.Size(75, 23);
            this.multiFileTarPathBtn.TabIndex = 4;
            this.multiFileTarPathBtn.Text = "浏览...";
            this.multiFileTarPathBtn.UseVisualStyleBackColor = true;
            this.multiFileTarPathBtn.Click += new System.EventHandler(this.multiFileTarPathBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(266, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "转换后视频保存位置：";
            // 
            // multiFileTarPathTxb
            // 
            this.multiFileTarPathTxb.Location = new System.Drawing.Point(266, 24);
            this.multiFileTarPathTxb.Name = "multiFileTarPathTxb";
            this.multiFileTarPathTxb.Size = new System.Drawing.Size(171, 21);
            this.multiFileTarPathTxb.TabIndex = 3;
            // 
            // convertResult
            // 
            this.convertResult.Location = new System.Drawing.Point(14, 53);
            this.convertResult.Multiline = true;
            this.convertResult.Name = "convertResult";
            this.convertResult.ReadOnly = true;
            this.convertResult.Size = new System.Drawing.Size(741, 334);
            this.convertResult.TabIndex = 6;
            // 
            // multiConvertBtn
            // 
            this.multiConvertBtn.Location = new System.Drawing.Point(647, 9);
            this.multiConvertBtn.Name = "multiConvertBtn";
            this.multiConvertBtn.Size = new System.Drawing.Size(108, 37);
            this.multiConvertBtn.TabIndex = 5;
            this.multiConvertBtn.Text = "开始批量转换";
            this.multiConvertBtn.UseVisualStyleBackColor = true;
            this.multiConvertBtn.Click += new System.EventHandler(this.multiConvertBtn_Click);
            // 
            // multiFileFormat
            // 
            this.multiFileFormat.Enabled = false;
            this.multiFileFormat.Location = new System.Drawing.Point(528, 24);
            this.multiFileFormat.Name = "multiFileFormat";
            this.multiFileFormat.Size = new System.Drawing.Size(100, 21);
            this.multiFileFormat.TabIndex = 8;
            this.multiFileFormat.Text = ".mp4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(526, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "要转换的格式";
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "格式转换工具 @GDY（基于开源软件FFmpeg基础开发）";
            this.tabControl1.ResumeLayout(false);
            this.singleFileConverter.ResumeLayout(false);
            this.singleFileConverter.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.multiFilesConverter.ResumeLayout(false);
            this.multiFilesConverter.PerformLayout();
            this.aboutMe.ResumeLayout(false);
            this.aboutMe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button browserSaveFilePathBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox saveConvertedFilePath;
        private System.Windows.Forms.FolderBrowserDialog saveFilePathDialog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage singleFileConverter;
        private System.Windows.Forms.TabPage multiFilesConverter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fileSrcPath;
        private System.Windows.Forms.TabPage aboutMe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button startToConvertBtn;
        private System.Windows.Forms.TextBox multiFileSrcPathTxb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox formatName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button multiFileSrcPathBtn;
        private System.Windows.Forms.Button multiFileTarPathBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox multiFileTarPathTxb;
        private System.Windows.Forms.TextBox convertResult;
        private System.Windows.Forms.Button multiConvertBtn;
        private System.Windows.Forms.TextBox multiFileFormat;
        private System.Windows.Forms.Label label9;
    }
}

