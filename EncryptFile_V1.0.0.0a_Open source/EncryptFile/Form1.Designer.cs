namespace EncryptFile
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPwdCfm = new System.Windows.Forms.TextBox();
            this.cbxShowPwd = new System.Windows.Forms.CheckBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDecryptDir = new System.Windows.Forms.Button();
            this.btnEncryptDir = new System.Windows.Forms.Button();
            this.progressPanel = new System.Windows.Forms.Panel();
            this.lblProgressFile = new System.Windows.Forms.Label();
            this.lblProgressDir = new System.Windows.Forms.Label();
            this.pbFile = new System.Windows.Forms.ProgressBar();
            this.pbDir = new System.Windows.Forms.ProgressBar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lblShowPath = new System.Windows.Forms.Label();
            this.btnDecryptThis = new System.Windows.Forms.Button();
            this.btnEncryptThis = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.解密后最小化到托盘ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.progressPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(86, 78);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(210, 21);
            this.txtPwd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "文件密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "xwuser密码：";
            // 
            // txtPwdCfm
            // 
            this.txtPwdCfm.Location = new System.Drawing.Point(86, 118);
            this.txtPwdCfm.Name = "txtPwdCfm";
            this.txtPwdCfm.PasswordChar = '*';
            this.txtPwdCfm.Size = new System.Drawing.Size(210, 21);
            this.txtPwdCfm.TabIndex = 1;
            // 
            // cbxShowPwd
            // 
            this.cbxShowPwd.AutoSize = true;
            this.cbxShowPwd.Location = new System.Drawing.Point(319, 80);
            this.cbxShowPwd.Name = "cbxShowPwd";
            this.cbxShowPwd.Size = new System.Drawing.Size(72, 16);
            this.cbxShowPwd.TabIndex = 8;
            this.cbxShowPwd.Text = "显示密码";
            this.cbxShowPwd.UseVisualStyleBackColor = true;
            this.cbxShowPwd.CheckedChanged += new System.EventHandler(this.cbxShowPwd_CheckedChanged);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(23, 163);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(110, 30);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "选择文件加密";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(23, 207);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(110, 30);
            this.btnDecrypt.TabIndex = 3;
            this.btnDecrypt.Text = "选择文件解密";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(39, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "提醒：请务必记住密码！数据无价，谨慎操作";
            // 
            // btnDecryptDir
            // 
            this.btnDecryptDir.Location = new System.Drawing.Point(146, 207);
            this.btnDecryptDir.Name = "btnDecryptDir";
            this.btnDecryptDir.Size = new System.Drawing.Size(110, 30);
            this.btnDecryptDir.TabIndex = 5;
            this.btnDecryptDir.Text = "选择文件夹解密";
            this.btnDecryptDir.UseVisualStyleBackColor = true;
            this.btnDecryptDir.Click += new System.EventHandler(this.btnDecryptDir_Click);
            // 
            // btnEncryptDir
            // 
            this.btnEncryptDir.Location = new System.Drawing.Point(146, 163);
            this.btnEncryptDir.Name = "btnEncryptDir";
            this.btnEncryptDir.Size = new System.Drawing.Size(110, 30);
            this.btnEncryptDir.TabIndex = 4;
            this.btnEncryptDir.Text = "选择文件夹加密";
            this.btnEncryptDir.UseVisualStyleBackColor = true;
            this.btnEncryptDir.Click += new System.EventHandler(this.btnEncryptDir_Click);
            // 
            // progressPanel
            // 
            this.progressPanel.Controls.Add(this.lblProgressFile);
            this.progressPanel.Controls.Add(this.lblProgressDir);
            this.progressPanel.Controls.Add(this.pbFile);
            this.progressPanel.Controls.Add(this.pbDir);
            this.progressPanel.Location = new System.Drawing.Point(9, 268);
            this.progressPanel.Name = "progressPanel";
            this.progressPanel.Size = new System.Drawing.Size(387, 43);
            this.progressPanel.TabIndex = 15;
            this.progressPanel.Visible = false;
            // 
            // lblProgressFile
            // 
            this.lblProgressFile.AutoSize = true;
            this.lblProgressFile.Location = new System.Drawing.Point(354, 24);
            this.lblProgressFile.Name = "lblProgressFile";
            this.lblProgressFile.Size = new System.Drawing.Size(17, 12);
            this.lblProgressFile.TabIndex = 16;
            this.lblProgressFile.Text = "0%";
            this.lblProgressFile.Visible = false;
            // 
            // lblProgressDir
            // 
            this.lblProgressDir.AutoSize = true;
            this.lblProgressDir.Location = new System.Drawing.Point(354, 5);
            this.lblProgressDir.Name = "lblProgressDir";
            this.lblProgressDir.Size = new System.Drawing.Size(17, 12);
            this.lblProgressDir.TabIndex = 15;
            this.lblProgressDir.Text = "0%";
            // 
            // pbFile
            // 
            this.pbFile.Location = new System.Drawing.Point(3, 24);
            this.pbFile.Name = "pbFile";
            this.pbFile.Size = new System.Drawing.Size(345, 12);
            this.pbFile.TabIndex = 14;
            this.pbFile.Visible = false;
            // 
            // pbDir
            // 
            this.pbDir.Location = new System.Drawing.Point(3, 5);
            this.pbDir.Name = "pbDir";
            this.pbDir.Size = new System.Drawing.Size(345, 12);
            this.pbDir.TabIndex = 13;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // lblShowPath
            // 
            this.lblShowPath.AutoSize = true;
            this.lblShowPath.Location = new System.Drawing.Point(10, 254);
            this.lblShowPath.Name = "lblShowPath";
            this.lblShowPath.Size = new System.Drawing.Size(11, 12);
            this.lblShowPath.TabIndex = 16;
            this.lblShowPath.Text = "-";
            this.lblShowPath.Visible = false;
            // 
            // btnDecryptThis
            // 
            this.btnDecryptThis.Location = new System.Drawing.Point(269, 207);
            this.btnDecryptThis.Name = "btnDecryptThis";
            this.btnDecryptThis.Size = new System.Drawing.Size(110, 30);
            this.btnDecryptThis.TabIndex = 7;
            this.btnDecryptThis.Text = "解密当前文件夹";
            this.btnDecryptThis.UseVisualStyleBackColor = true;
            this.btnDecryptThis.Click += new System.EventHandler(this.btnDecryptThis_Click);
            // 
            // btnEncryptThis
            // 
            this.btnEncryptThis.Location = new System.Drawing.Point(269, 163);
            this.btnEncryptThis.Name = "btnEncryptThis";
            this.btnEncryptThis.Size = new System.Drawing.Size(110, 30);
            this.btnEncryptThis.TabIndex = 6;
            this.btnEncryptThis.Text = "加密当前文件夹";
            this.btnEncryptThis.UseVisualStyleBackColor = true;
            this.btnEncryptThis.Click += new System.EventHandler(this.btnEncryptThis_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帮助ToolStripMenuItem,
            this.设置ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(404, 25);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帮助ToolStripMenuItem1,
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 帮助ToolStripMenuItem1
            // 
            this.帮助ToolStripMenuItem1.Name = "帮助ToolStripMenuItem1";
            this.帮助ToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.帮助ToolStripMenuItem1.Text = "帮助";
            this.帮助ToolStripMenuItem1.Click += new System.EventHandler(this.帮助ToolStripMenuItem1_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.解密后最小化到托盘ToolStripMenuItem});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 解密后最小化到托盘ToolStripMenuItem
            // 
            this.解密后最小化到托盘ToolStripMenuItem.Name = "解密后最小化到托盘ToolStripMenuItem";
            this.解密后最小化到托盘ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.解密后最小化到托盘ToolStripMenuItem.Text = "解密后最小化到托盘";
            this.解密后最小化到托盘ToolStripMenuItem.ToolTipText = "解密后最小化到托盘\r\n只对解密当前文件夹有效";
            this.解密后最小化到托盘ToolStripMenuItem.Click += new System.EventHandler(this.解密后最小化到托盘ToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "文件加密";
            this.notifyIcon1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 317);
            this.Controls.Add(this.btnDecryptThis);
            this.Controls.Add(this.btnEncryptThis);
            this.Controls.Add(this.lblShowPath);
            this.Controls.Add(this.progressPanel);
            this.Controls.Add(this.btnDecryptDir);
            this.Controls.Add(this.btnEncryptDir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.cbxShowPwd);
            this.Controls.Add(this.txtPwdCfm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件加密V2.2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.progressPanel.ResumeLayout(false);
            this.progressPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPwdCfm;
        private System.Windows.Forms.CheckBox cbxShowPwd;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDecryptDir;
        private System.Windows.Forms.Button btnEncryptDir;
        private System.Windows.Forms.Panel progressPanel;
        private System.Windows.Forms.Label lblProgressFile;
        private System.Windows.Forms.Label lblProgressDir;
        private System.Windows.Forms.ProgressBar pbFile;
        private System.Windows.Forms.ProgressBar pbDir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lblShowPath;
        private System.Windows.Forms.Button btnDecryptThis;
        private System.Windows.Forms.Button btnEncryptThis;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 解密后最小化到托盘ToolStripMenuItem;
    }
}

