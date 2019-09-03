using System.IO;

namespace renamegui
{
    partial class GUI
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
            this.chooseDirBtn = new System.Windows.Forms.Button();
            this.fileList = new System.Windows.Forms.CheckedListBox();
            this.fullSelectcheckBox = new System.Windows.Forms.CheckBox();
            this.pathLable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.screenBtn = new System.Windows.Forms.Button();
            this.previewBtn = new System.Windows.Forms.Button();
            this.renameBtn = new System.Windows.Forms.Button();
            this.numtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.helpBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chooseDirBtn
            // 
            this.chooseDirBtn.Location = new System.Drawing.Point(791, 5);
            this.chooseDirBtn.Name = "chooseDirBtn";
            this.chooseDirBtn.Size = new System.Drawing.Size(75, 30);
            this.chooseDirBtn.TabIndex = 1;
            this.chooseDirBtn.Text = "浏览";
            this.chooseDirBtn.UseVisualStyleBackColor = true;
            this.chooseDirBtn.Click += new System.EventHandler(this.choose_Click);
            // 
            // fileList
            // 
            this.fileList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileList.CheckOnClick = true;
            this.fileList.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fileList.FormattingEnabled = true;
            this.fileList.HorizontalScrollbar = true;
            this.fileList.Location = new System.Drawing.Point(0, 41);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(875, 584);
            this.fileList.TabIndex = 2;
            // 
            // fullSelectcheckBox
            // 
            this.fullSelectcheckBox.AutoSize = true;
            this.fullSelectcheckBox.Location = new System.Drawing.Point(709, 12);
            this.fullSelectcheckBox.Name = "fullSelectcheckBox";
            this.fullSelectcheckBox.Size = new System.Drawing.Size(59, 19);
            this.fullSelectcheckBox.TabIndex = 3;
            this.fullSelectcheckBox.Text = "全选";
            this.fullSelectcheckBox.UseVisualStyleBackColor = true;
            this.fullSelectcheckBox.CheckedChanged += new System.EventHandler(this.FullSelectcheckBox_CheckedChanged);
            // 
            // pathLable
            // 
            this.pathLable.AutoSize = true;
            this.pathLable.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pathLable.Location = new System.Drawing.Point(51, 5);
            this.pathLable.Name = "pathLable";
            this.pathLable.Size = new System.Drawing.Size(43, 25);
            this.pathLable.TabIndex = 4;
            this.pathLable.Text = "(空)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(0, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "路径:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(123, 630);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(385, 31);
            this.textBox1.TabIndex = 6;
            // 
            // screenBtn
            // 
            this.screenBtn.Location = new System.Drawing.Point(628, 631);
            this.screenBtn.Name = "screenBtn";
            this.screenBtn.Size = new System.Drawing.Size(75, 30);
            this.screenBtn.TabIndex = 7;
            this.screenBtn.Text = "筛选";
            this.screenBtn.UseVisualStyleBackColor = true;
            this.screenBtn.Click += new System.EventHandler(this.ScreenBtn_Click);
            // 
            // previewBtn
            // 
            this.previewBtn.Location = new System.Drawing.Point(709, 631);
            this.previewBtn.Name = "previewBtn";
            this.previewBtn.Size = new System.Drawing.Size(75, 30);
            this.previewBtn.TabIndex = 8;
            this.previewBtn.Text = "预览";
            this.previewBtn.UseVisualStyleBackColor = true;
            this.previewBtn.Click += new System.EventHandler(this.PreviewBtn_Click);
            // 
            // renameBtn
            // 
            this.renameBtn.Location = new System.Drawing.Point(791, 630);
            this.renameBtn.Name = "renameBtn";
            this.renameBtn.Size = new System.Drawing.Size(75, 30);
            this.renameBtn.TabIndex = 9;
            this.renameBtn.Text = "重命名";
            this.renameBtn.UseVisualStyleBackColor = true;
            this.renameBtn.Click += new System.EventHandler(this.RenameBtn_Click);
            // 
            // numtextBox
            // 
            this.numtextBox.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numtextBox.Location = new System.Drawing.Point(123, 667);
            this.numtextBox.Name = "numtextBox";
            this.numtextBox.Size = new System.Drawing.Size(100, 31);
            this.numtextBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 639);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "筛选/重命名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 676);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "位数：";
            // 
            // helpBtn
            // 
            this.helpBtn.Location = new System.Drawing.Point(547, 630);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(75, 30);
            this.helpBtn.TabIndex = 13;
            this.helpBtn.Text = "帮助";
            this.helpBtn.UseVisualStyleBackColor = true;
            this.helpBtn.Click += new System.EventHandler(this.HelpBtn_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 710);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numtextBox);
            this.Controls.Add(this.renameBtn);
            this.Controls.Add(this.previewBtn);
            this.Controls.Add(this.screenBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pathLable);
            this.Controls.Add(this.fullSelectcheckBox);
            this.Controls.Add(this.fileList);
            this.Controls.Add(this.chooseDirBtn);
            this.Name = "GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "批量重命名工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button chooseDirBtn;
        private System.Windows.Forms.CheckedListBox fileList;
        private System.Windows.Forms.CheckBox fullSelectcheckBox;
        private DirectoryInfo theFolder;
        private System.Windows.Forms.Label pathLable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button screenBtn;
        private System.Windows.Forms.Button previewBtn;
        private System.Windows.Forms.Button renameBtn;
        private System.Windows.Forms.TextBox numtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button helpBtn;
    }
}

