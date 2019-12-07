using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EncryptFile
{
    public partial class ReEncryptBox : Form
    {
        #region 字段
        public Form1 form1 = null;
        #endregion

        #region 构造函数
        public ReEncryptBox()
        {
            InitializeComponent();
        }
        #endregion

        #region 恢复加密状态
        private void btnReEncrypt_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.Visible = false;
            form1.Visible = true;
            form1.WindowState = FormWindowState.Normal;
            form1.TopLevel = true;
            form1.Focus();

            form1.ReEncrypt();
        }
        #endregion

        #region 取消文件加密
        private void btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

    }
}
