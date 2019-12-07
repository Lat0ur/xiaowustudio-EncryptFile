using System;
using System.Threading;
using System.Windows.Forms;
using Utils;

namespace EncryptFile
{
    public partial class Form1 : Form
    {
        #region 变量
        public int tryCount = 0;
        public readonly int maxTryCount = 3;
        #endregion

        #region xwuser查询的变量
        static public string xwuser;//xwuser，用于保存
        #endregion

        #region 构造函数
        public Form1()
        {
            InitializeComponent();
        }
        #endregion


        #region 窗体加载事件
        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.NotifyUse)
            {
                解密后最小化到托盘ToolStripMenuItem.Checked = true;
            }
        }
        #endregion

        #region 加密文件
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            #region 验证
            if (txtPwd.Text == "")
            {
                MessageBox.Show("密码不能为空", "提示");
                return;
            }

            if (txtPwdCfm.Text == "")
            {
                MessageBox.Show("xwuser密码不能为空", "提示");
                return;
            }

            #endregion

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Thread thread = new Thread(new ParameterizedThreadStart(delegate(object obj)
                {
                    try
                    {
                        InvokeDelegate invokeDelegate = delegate()
                        {
                            pbFile.Value = 0;
                            lblProgressFile.Text = "0%";
                            pbDir.Visible = false;
                            lblProgressDir.Visible = false;
                            pbFile.Visible = false;
                            lblProgressFile.Visible = false;
                            lblShowPath.Text = "加密文件：" + openFileDialog1.FileName;
                            lblShowPath.Visible = true;
                            DisableBtns();
                        };
                        InvokeUtil.Invoke(this, invokeDelegate);
                        DateTime t1 = DateTime.Now;
                        FileEncrypt.EncryptFile(openFileDialog1.FileName, txtPwd.Text, RefreshFileProgress);
                        DateTime t2 = DateTime.Now;
                        string t = t2.Subtract(t1).TotalSeconds.ToString("0.00");
                        if (MessageBox.Show("加密成功，耗时" + t + "秒", "提示") == DialogResult.OK)
                        {
                            invokeDelegate = delegate()
                            {
                                EnableBtns();
                            };
                            InvokeUtil.Invoke(this, invokeDelegate);
                        }
                    }
                    catch (Exception ex)
                    {
                        if (MessageBox.Show("加密失败：" + ex.Message, "提示") == DialogResult.OK)
                        {
                            InvokeDelegate invokeDelegate = delegate()
                            {
                                EnableBtns();
                            };
                            InvokeUtil.Invoke(this, invokeDelegate);
                        }
                    }
                }));
                thread.Start();
            }
        }
        #endregion

        #region 解密文件
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            #region 验证
            if (txtPwd.Text == "")
            {
                MessageBox.Show("密码不能为空", "提示");
                return;
            }
            #endregion

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Thread thread = new Thread(new ParameterizedThreadStart(delegate(object obj)
                {
                    try
                    {
                        InvokeDelegate invokeDelegate = delegate()
                        {
                            pbFile.Value = 0;
                            lblProgressFile.Text = "0%";
                            pbDir.Visible = false;
                            lblProgressDir.Visible = false;
                            pbFile.Visible = false;
                            lblProgressFile.Visible = false;
                            lblShowPath.Text = "解密文件：" + openFileDialog1.FileName;
                            lblShowPath.Visible = true;
                            DisableBtns();
                        };
                        InvokeUtil.Invoke(this, invokeDelegate);
                        DateTime t1 = DateTime.Now;
                        FileEncrypt.DecryptFile(openFileDialog1.FileName, txtPwd.Text, RefreshFileProgress);
                        DateTime t2 = DateTime.Now;
                        string t = t2.Subtract(t1).TotalSeconds.ToString("0.00");
                        if (MessageBox.Show("解密成功，耗时" + t + "秒", "提示") == DialogResult.OK)
                        {
                            invokeDelegate = delegate()
                            {
                                EnableBtns();
                            };
                            InvokeUtil.Invoke(this, invokeDelegate);
                        }
                    }
                    catch (Exception ex)
                    {
                        if (MessageBox.Show("解密失败：" + ex.Message, "提示") == DialogResult.OK)
                        {
                            InvokeDelegate invokeDelegate = delegate()
                            {
                                EnableBtns();
                                tryCount++;
                                if (tryCount == maxTryCount)
                                {
                                    this.Close();
                                }
                            };
                            InvokeUtil.Invoke(this, invokeDelegate);
                        }
                    }
                }));
                thread.Start();
            }
        }
        #endregion

        #region 文件夹加密
        private void btnEncryptDir_Click(object sender, EventArgs e)
        {
            #region 验证
            if (txtPwd.Text == "")
            {
                MessageBox.Show("密码不能为空", "提示");
                return;
            }

            if (txtPwdCfm.Text == "")
            {
                MessageBox.Show("xwuser密码不能为空", "提示");
                return;
            }
            #endregion

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if (MessageBox.Show(string.Format("确定加密文件夹{0}？", folderBrowserDialog1.SelectedPath),
                    "提示", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    return;
                }

                Thread thread = new Thread(new ParameterizedThreadStart(delegate(object obj)
                {
                    try
                    {
                        InvokeDelegate invokeDelegate = delegate()
                        {
                            pbDir.Value = 0;
                            lblProgressDir.Text = "0%";
                            pbFile.Value = 0;
                            lblProgressFile.Text = "0%";
                            pbDir.Visible = true;
                            lblProgressDir.Visible = true;
                            pbFile.Visible = false;
                            lblProgressFile.Visible = false;
                            lblShowPath.Text = "加密文件夹：" + folderBrowserDialog1.SelectedPath;
                            lblShowPath.Visible = true;
                            DisableBtns();
                        };
                        InvokeUtil.Invoke(this, invokeDelegate);
                        DateTime t1 = DateTime.Now;
                        DirectoryEncrypt.EncryptDirectory(folderBrowserDialog1.SelectedPath, txtPwd.Text, RefreshDirProgress, RefreshFileProgress);
                        DateTime t2 = DateTime.Now;
                        string t = t2.Subtract(t1).TotalSeconds.ToString("0.00");
                        if (MessageBox.Show("加密成功，耗时" + t + "秒", "提示") == DialogResult.OK)
                        {
                            invokeDelegate = delegate()
                            {
                                EnableBtns();
                            };
                            InvokeUtil.Invoke(this, invokeDelegate);
                        }
                    }
                    catch (Exception ex)
                    {
                        if (MessageBox.Show("加密失败:" + ex.Message, "提示") == DialogResult.OK)
                        {
                            InvokeDelegate invokeDelegate = delegate()
                            {
                                EnableBtns();
                            };
                            InvokeUtil.Invoke(this, invokeDelegate);
                        }
                    }
                }));
                thread.Start();
            }
        }
        #endregion

        #region 文件夹解密
        private void btnDecryptDir_Click(object sender, EventArgs e)
        {
            #region 验证
            if (txtPwd.Text == "")
            {
                MessageBox.Show("密码不能为空", "提示");
                return;
            }
            #endregion

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if (MessageBox.Show(string.Format("确定解密文件夹{0}？", folderBrowserDialog1.SelectedPath),
                    "提示", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    return;
                }

                Thread thread = new Thread(new ParameterizedThreadStart(delegate(object obj)
                {
                    try
                    {
                        InvokeDelegate invokeDelegate = delegate()
                        {
                            pbDir.Value = 0;
                            lblProgressDir.Text = "0%";
                            pbFile.Value = 0;
                            lblProgressFile.Text = "0%";
                            pbDir.Visible = true;
                            lblProgressFile.Visible = true;
                            pbFile.Visible = false;
                            lblProgressFile.Visible = false;
                            lblShowPath.Text = "解密文件夹：" + folderBrowserDialog1.SelectedPath;
                            lblShowPath.Visible = true;
                            DisableBtns();
                        };
                        InvokeUtil.Invoke(this, invokeDelegate);
                        DateTime t1 = DateTime.Now;
                        DirectoryEncrypt.DecryptDirectory(folderBrowserDialog1.SelectedPath, txtPwd.Text, RefreshDirProgress, RefreshFileProgress);
                        DateTime t2 = DateTime.Now;
                        string t = t2.Subtract(t1).TotalSeconds.ToString("0.00");
                        if (MessageBox.Show("解密成功，耗时" + t + "秒", "提示") == DialogResult.OK)
                        {
                            invokeDelegate = delegate()
                            {
                                EnableBtns();
                            };
                            InvokeUtil.Invoke(this, invokeDelegate);
                        }
                    }
                    catch (Exception ex)
                    {
                        if (MessageBox.Show("解密失败：" + ex.Message, "提示") == DialogResult.OK)
                        {
                            InvokeDelegate invokeDelegate = delegate()
                            {
                                EnableBtns();
                                tryCount++;
                                if (tryCount == maxTryCount)
                                {
                                    this.Close();
                                }
                            };
                            InvokeUtil.Invoke(this, invokeDelegate);
                        }
                    }
                }));
                thread.Start();
            }
        }
        #endregion

        #region 加密当前文件夹
        private void btnEncryptThis_Click(object sender, EventArgs e)
        {
            #region 验证
            if (txtPwd.Text == "")
            {
                MessageBox.Show("密码不能为空", "提示");
                return;
            }

            if (txtPwdCfm.Text == "")
            {
                MessageBox.Show("xwuser密码不能为空", "提示");
                return;
            }
            #endregion

            if (MessageBox.Show(string.Format("确定加密当前文件夹？"),
                "提示", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }

            Thread thread = new Thread(new ParameterizedThreadStart(delegate(object obj)
            {
                try
                {
                    InvokeDelegate invokeDelegate = delegate()
                    {
                        pbDir.Value = 0;
                        lblProgressDir.Text = "0%";
                        pbFile.Value = 0;
                        lblProgressFile.Text = "0%";
                        pbDir.Visible = true;
                        lblProgressDir.Visible = true;
                        pbFile.Visible = false;
                        lblProgressFile.Visible = false;
                        lblShowPath.Text = "加密文件夹：" + Application.StartupPath;
                        lblShowPath.Visible = true;
                        DisableBtns();
                    };
                    InvokeUtil.Invoke(this, invokeDelegate);
                    DateTime t1 = DateTime.Now;
                    DirectoryEncrypt.EncryptCurrentDirectory(Application.StartupPath, txtPwd.Text, RefreshDirProgress, RefreshFileProgress);
                    DateTime t2 = DateTime.Now;
                    string t = t2.Subtract(t1).TotalSeconds.ToString("0.00");
                    if (MessageBox.Show("加密成功，耗时" + t + "秒", "提示") == DialogResult.OK)
                    {
                        invokeDelegate = delegate()
                        {
                            EnableBtns();
                            Application.Exit(); //加密成功后关闭程序
                        };
                        InvokeUtil.Invoke(this, invokeDelegate);
                    }
                }
                catch (Exception ex)
                {
                    if (MessageBox.Show("加密失败:" + ex.Message, "提示") == DialogResult.OK)
                    {
                        InvokeDelegate invokeDelegate = delegate()
                        {
                            EnableBtns();
                        };
                        InvokeUtil.Invoke(this, invokeDelegate);
                    }
                }
            }));
            thread.Start();
        }
        #endregion

        #region 解密当前文件夹
        private void btnDecryptThis_Click(object sender, EventArgs e)
        {
            #region 验证
            if (txtPwd.Text == "")
            {
                MessageBox.Show("密码不能为空", "提示");
                return;
            }
            #endregion

            if (MessageBox.Show(string.Format("确定解密当前文件夹？"),
                "提示", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }

            Thread thread = new Thread(new ParameterizedThreadStart(delegate(object obj)
            {
                try
                {
                    InvokeDelegate invokeDelegate = delegate()
                    {
                        pbDir.Value = 0;
                        lblProgressDir.Text = "0%";
                        pbFile.Value = 0;
                        lblProgressFile.Text = "0%";
                        pbDir.Visible = true;
                        lblProgressFile.Visible = true;
                        pbFile.Visible = false;
                        lblProgressFile.Visible = false;
                        lblShowPath.Text = "解密文件夹：" + Application.StartupPath;
                        lblShowPath.Visible = true;
                        DisableBtns();
                    };
                    InvokeUtil.Invoke(this, invokeDelegate);
                    DateTime t1 = DateTime.Now;
                    DirectoryEncrypt.DecryptCurrentDirectory(Application.StartupPath, txtPwd.Text, RefreshDirProgress, RefreshFileProgress);
                    DateTime t2 = DateTime.Now;
                    string t = t2.Subtract(t1).TotalSeconds.ToString("0.00");
                    if (MessageBox.Show("解密成功，耗时" + t + "秒", "提示") == DialogResult.OK)
                    {
                        invokeDelegate = delegate()
                        {
                            EnableBtns();
                            if (Properties.Settings.Default.NotifyUse)
                            {
                                //解密成功后最小化程序
                                txtPwdCfm.Text = txtPwd.Text;
                                this.WindowState = FormWindowState.Minimized;
                                this.Visible = false;
                                notifyIcon1.Visible = true;
                            }
                            else
                            {
                                Application.Exit();
                            }
                        };
                        InvokeUtil.Invoke(this, invokeDelegate);
                    }
                }
                catch (Exception ex)
                {
                    if (MessageBox.Show("解密失败：" + ex.Message, "提示") == DialogResult.OK)
                    {
                        InvokeDelegate invokeDelegate = delegate()
                        {
                            EnableBtns();
                            tryCount++;
                            if (tryCount == maxTryCount)
                            {
                                this.Close();
                            }
                        };
                        InvokeUtil.Invoke(this, invokeDelegate);
                    }
                }
            }));
            thread.Start();
        }
        #endregion

        #region 重新加密
        /// <summary>
        /// 重新加密
        /// </summary>
        public void ReEncrypt()
        {
            Thread thread = new Thread(new ParameterizedThreadStart(delegate(object obj)
            {
                try
                {
                    InvokeDelegate invokeDelegate = delegate()
                    {
                        pbDir.Value = 0;
                        lblProgressDir.Text = "0%";
                        pbFile.Value = 0;
                        lblProgressFile.Text = "0%";
                        pbDir.Visible = true;
                        lblProgressDir.Visible = true;
                        pbFile.Visible = false;
                        lblProgressFile.Visible = false;
                        lblShowPath.Text = "加密文件夹：" + Application.StartupPath;
                        lblShowPath.Visible = true;
                        DisableBtns();
                    };
                    InvokeUtil.Invoke(this, invokeDelegate);
                    DateTime t1 = DateTime.Now;
                    DirectoryEncrypt.EncryptCurrentDirectory(Application.StartupPath, txtPwd.Text, RefreshDirProgress, RefreshFileProgress);
                    DateTime t2 = DateTime.Now;
                    string t = t2.Subtract(t1).TotalSeconds.ToString("0.00");
                    if (MessageBox.Show("加密成功，耗时" + t + "秒", "提示") == DialogResult.OK)
                    {
                        invokeDelegate = delegate()
                        {
                            EnableBtns();
                            Application.Exit(); //加密成功后关闭程序
                        };
                        InvokeUtil.Invoke(this, invokeDelegate);
                    }
                }
                catch (Exception ex)
                {
                    if (MessageBox.Show("加密失败:" + ex.Message, "提示") == DialogResult.OK)
                    {
                        InvokeDelegate invokeDelegate = delegate()
                        {
                            EnableBtns();
                        };
                        InvokeUtil.Invoke(this, invokeDelegate);
                    }
                }
            }));
            thread.Start();
        }
        #endregion

        #region 更新文件加密进度
        /// <summary>
        /// 更新文件加密进度
        /// </summary>
        public void RefreshFileProgress(int max, int value)
        {
            InvokeDelegate invokeDelegate = delegate()
            {
                if (max > 1)
                {
                    pbFile.Visible = true;
                    lblProgressFile.Visible = true;
                }
                else
                {
                    pbFile.Visible = false;
                    lblProgressFile.Visible = false;
                }
                pbFile.Maximum = max;
                pbFile.Value = value;
                lblProgressFile.Text = value * 100 / max + "%";
            };
            InvokeUtil.Invoke(this, invokeDelegate);
        }
        #endregion

        #region 更新文件夹加密进度
        /// <summary>
        /// 更新文件夹加密进度
        /// </summary>
        public void RefreshDirProgress(int max, int value)
        {
            InvokeDelegate invokeDelegate = delegate()
            {
                pbDir.Maximum = max;
                pbDir.Value = value;
                lblProgressDir.Text = value * 100 / max + "%";
            };
            InvokeUtil.Invoke(this, invokeDelegate);
        }
        #endregion

        #region 显示密码
        private void cbxShowPwd_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxShowPwd.Checked)
            {
                txtPwd.PasswordChar = default(char);
                txtPwdCfm.PasswordChar = default(char);
            }
            else
            {
                txtPwd.PasswordChar = '*';
                txtPwdCfm.PasswordChar = '*';
            }
        }
        #endregion

        #region 关闭窗体事件
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (progressPanel.Visible)
            {
                MessageBox.Show("正在处理文件，请等待…", "提示");
                e.Cancel = true;
            }
        }
        #endregion

        #region 控制按钮状态
        /// <summary>
        /// 禁用按钮
        /// </summary>
        public void DisableBtns()
        {
            progressPanel.Visible = true;
            btnEncrypt.Enabled = false;
            btnDecrypt.Enabled = false;
            btnEncryptDir.Enabled = false;
            btnDecryptDir.Enabled = false;
            btnEncryptThis.Enabled = false;
            btnDecryptThis.Enabled = false;
            txtPwd.Enabled = false;
            txtPwdCfm.Enabled = false;
        }
        /// <summary>
        /// 启用按钮
        /// </summary>
        public void EnableBtns()
        {
            lblShowPath.Visible = false;
            progressPanel.Visible = false;
            btnEncrypt.Enabled = true;
            btnDecrypt.Enabled = true;
            btnEncryptDir.Enabled = true;
            btnDecryptDir.Enabled = true;
            btnEncryptThis.Enabled = true;
            btnDecryptThis.Enabled = true;
            txtPwd.Enabled = true;
            txtPwdCfm.Enabled = true;
        }
        #endregion

        #region 帮助
        private void 帮助ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HelpBox helpBox = new HelpBox();
            helpBox.ShowDialog();
        }
        #endregion

        #region 关于
        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }
        #endregion

        #region 点击托盘
        private ReEncryptBox rebox = null;
        private void notifyIcon1_MouseDown(object sender, MouseEventArgs e)
        {
            if (rebox == null || rebox.IsDisposed) rebox = new ReEncryptBox();
            rebox.form1 = this;
            rebox.Visible = true;
            rebox.Show();
            rebox.WindowState = FormWindowState.Normal;
            rebox.TopMost = true;
            rebox.Focus();
        }
        #endregion

        #region 是否解密后最小化到托盘
        private void 解密后最小化到托盘ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.NotifyUse)
            {
                解密后最小化到托盘ToolStripMenuItem.Checked = false;
                Properties.Settings.Default.NotifyUse = false;
                Properties.Settings.Default.Save();
            }
            else
            {
                解密后最小化到托盘ToolStripMenuItem.Checked = true;
                Properties.Settings.Default.NotifyUse = true;
                Properties.Settings.Default.Save();
            }
        }

        #endregion


    }
}
