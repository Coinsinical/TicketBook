using System.Drawing;
using System.Windows.Forms;

namespace TicketBook
{
    partial class RegisterControl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_register = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.linkLabel_login = new System.Windows.Forms.LinkLabel();
            this.label_register = new System.Windows.Forms.Label();
            this.textBox_confirm_password = new System.Windows.Forms.TextBox();
            this.label_confirm_password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_username
            // 
            this.label_username.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_username.Location = new System.Drawing.Point(133, 51);
            this.label_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(200, 28);
            this.label_username.TabIndex = 1;
            this.label_username.Text = "请输入用户名:";
            // 
            // label_password
            // 
            this.label_password.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_password.Location = new System.Drawing.Point(133, 101);
            this.label_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(200, 33);
            this.label_password.TabIndex = 2;
            this.label_password.Text = "请输入密码:";
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(373, 51);
            this.textBox_username.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(200, 28);
            this.textBox_username.TabIndex = 4;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(373, 106);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(200, 28);
            this.textBox_password.TabIndex = 5;
            // 
            // button_register
            // 
            this.button_register.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_register.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_register.Location = new System.Drawing.Point(133, 207);
            this.button_register.Margin = new System.Windows.Forms.Padding(2);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(200, 50);
            this.button_register.TabIndex = 6;
            this.button_register.Text = "注册";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // button_exit
            // 
            this.button_exit.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_exit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_exit.Location = new System.Drawing.Point(373, 207);
            this.button_exit.Margin = new System.Windows.Forms.Padding(2);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(200, 50);
            this.button_exit.TabIndex = 7;
            this.button_exit.Text = "退出";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // linkLabel_login
            // 
            this.linkLabel_login.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel_login.LinkColor = System.Drawing.Color.Black;
            this.linkLabel_login.Location = new System.Drawing.Point(0, 271);
            this.linkLabel_login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel_login.Name = "linkLabel_login";
            this.linkLabel_login.Size = new System.Drawing.Size(700, 37);
            this.linkLabel_login.TabIndex = 8;
            this.linkLabel_login.TabStop = true;
            this.linkLabel_login.Text = "已有账号？点此登录！";
            this.linkLabel_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel_login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_login_LinkClicked);
            // 
            // label_register
            // 
            this.label_register.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_register.Location = new System.Drawing.Point(0, 0);
            this.label_register.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_register.Name = "label_register";
            this.label_register.Size = new System.Drawing.Size(700, 35);
            this.label_register.TabIndex = 0;
            this.label_register.Text = "注册";
            this.label_register.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox_confirm_password
            // 
            this.textBox_confirm_password.Location = new System.Drawing.Point(373, 160);
            this.textBox_confirm_password.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_confirm_password.Name = "textBox_confirm_password";
            this.textBox_confirm_password.Size = new System.Drawing.Size(200, 28);
            this.textBox_confirm_password.TabIndex = 10;
            // 
            // label_confirm_password
            // 
            this.label_confirm_password.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_confirm_password.Location = new System.Drawing.Point(133, 155);
            this.label_confirm_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_confirm_password.Name = "label_confirm_password";
            this.label_confirm_password.Size = new System.Drawing.Size(200, 33);
            this.label_confirm_password.TabIndex = 9;
            this.label_confirm_password.Text = "请确认密码:";
            // 
            // RegisterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox_confirm_password);
            this.Controls.Add(this.label_confirm_password);
            this.Controls.Add(this.label_register);
            this.Controls.Add(this.linkLabel_login);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegisterControl";
            this.Size = new System.Drawing.Size(700, 320);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label_username;
        private Label label_password;
        private TextBox textBox_username;
        private TextBox textBox_password;
        private Button button_register;
        private Button button_exit;
        private LinkLabel linkLabel_login;
        private Label label_register;
        private TextBox textBox_confirm_password;
        private Label label_confirm_password;
    }
}
