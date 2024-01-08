using System.Drawing;
using System.Windows.Forms;

namespace TicketBook
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.form_container = new System.Windows.Forms.Panel();
            this.label_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // form_container
            // 
            this.form_container.Location = new System.Drawing.Point(40, 50);
            this.form_container.Margin = new System.Windows.Forms.Padding(2);
            this.form_container.Name = "form_container";
            this.form_container.Size = new System.Drawing.Size(700, 320);
            this.form_container.TabIndex = 0;
            // 
            // label_title
            // 
            this.label_title.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_title.Location = new System.Drawing.Point(-2, 7);
            this.label_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(780, 39);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "欢迎使用电影订票系统！";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(778, 394);
            this.Controls.Add(this.form_container);
            this.Controls.Add(this.label_title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "电影订票系统";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel form_container;
        private Label label_title;
    }
}