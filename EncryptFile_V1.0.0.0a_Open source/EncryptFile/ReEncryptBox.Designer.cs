namespace EncryptFile
{
    partial class ReEncryptBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReEncrypt = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReEncrypt
            // 
            this.btnReEncrypt.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReEncrypt.Location = new System.Drawing.Point(53, 37);
            this.btnReEncrypt.Name = "btnReEncrypt";
            this.btnReEncrypt.Size = new System.Drawing.Size(170, 50);
            this.btnReEncrypt.TabIndex = 0;
            this.btnReEncrypt.Text = "恢复加密状态";
            this.btnReEncrypt.UseVisualStyleBackColor = true;
            this.btnReEncrypt.Click += new System.EventHandler(this.btnReEncrypt_Click);
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn.Location = new System.Drawing.Point(53, 135);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(170, 50);
            this.btn.TabIndex = 1;
            this.btn.Text = "取消文件加密";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // ReEncryptBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 234);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnReEncrypt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReEncryptBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "重新加密";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReEncrypt;
        private System.Windows.Forms.Button btn;
    }
}