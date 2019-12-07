using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace EncryptFile
{
    partial class 公告 : Form
    {
        public 公告()
        {
            InitializeComponent();
        }

        private void 公告_Load(object sender, EventArgs e)
        {
            textBox1.SelectionStart = 0;
            textBox1.SelectionLength = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
