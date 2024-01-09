using System.Drawing;
using System.Windows.Forms;

namespace TicketBook
{
    partial class LoginControl
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
            this.button_login = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.linkLabel_register = new System.Windows.Forms.LinkLabel();
            this.label_login = new System.Windows.Forms.Label();
            this.groupBox_role = new System.Windows.Forms.GroupBox();
            this.radioButton_admin = new System.Windows.Forms.RadioButton();
            this.radioButton_user = new System.Windows.Forms.RadioButton();
            this.groupBox_role.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_username
            // 
            this.label_username.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_username.Location = new System.Drawing.Point(133, 51);
            this.label_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(101, 28);
            this.label_username.TabIndex = 1;
            this.label_username.Text = "用户名:";
            // 
            // label_password
            // 
            this.label_password.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_password.Location = new System.Drawing.Point(133, 101);
            this.label_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(139, 33);
            this.label_password.TabIndex = 2;
            this.label_password.Text = "密码:";
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
            // button_login
            // 
            this.button_login.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_login.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_login.Location = new System.Drawing.Point(133, 207);
            this.button_login.Margin = new System.Windows.Forms.Padding(2);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(200, 50);
            this.button_login.TabIndex = 6;
            this.button_login.Text = "登录";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
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
            // linkLabel_register
            // 
            this.linkLabel_register.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel_register.LinkColor = System.Drawing.Color.Black;
            this.linkLabel_register.Location = new System.Drawing.Point(0, 271);
            this.linkLabel_register.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel_register.Name = "linkLabel_register";
            this.linkLabel_register.Size = new System.Drawing.Size(700, 37);
            this.linkLabel_register.TabIndex = 8;
            this.linkLabel_register.TabStop = true;
            this.linkLabel_register.Text = "没有账号？立即注册！";
            this.linkLabel_register.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel_register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_register_LinkClicked);
            // 
            // label_login
            // 
            this.label_login.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_login.Location = new System.Drawing.Point(0, 0);
            this.label_login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(700, 35);
            this.label_login.TabIndex = 0;
            this.label_login.Text = "登录";
            this.label_login.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox_role
            // 
            this.groupBox_role.Controls.Add(this.radioButton_admin);
            this.groupBox_role.Controls.Add(this.radioButton_user);
            this.groupBox_role.Location = new System.Drawing.Point(133, 138);
            this.groupBox_role.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_role.Name = "groupBox_role";
            this.groupBox_role.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_role.Size = new System.Drawing.Size(440, 65);
            this.groupBox_role.TabIndex = 9;
            this.groupBox_role.TabStop = false;
            // 
            // radioButton_admin
            // 
            this.radioButton_admin.AutoSize = true;
            this.radioButton_admin.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_admin.Location = new System.Drawing.Point(240, 25);
            this.radioButton_admin.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_admin.Name = "radioButton_admin";
            this.radioButton_admin.Size = new System.Drawing.Size(89, 28);
            this.radioButton_admin.TabIndex = 1;
            this.radioButton_admin.TabStop = true;
            this.radioButton_admin.Text = "管理员";
            this.radioButton_admin.UseVisualStyleBackColor = true;
            // 
            // radioButton_user
            // 
            this.radioButton_user.AutoSize = true;
            this.radioButton_user.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_user.Location = new System.Drawing.Point(22, 25);
            this.radioButton_user.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_user.Name = "radioButton_user";
            this.radioButton_user.Size = new System.Drawing.Size(71, 28);
            this.radioButton_user.TabIndex = 0;
            this.radioButton_user.TabStop = true;
            this.radioButton_user.Text = "用户";
            this.radioButton_user.UseVisualStyleBackColor = true;
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_role);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.linkLabel_register);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(700, 320);
            this.groupBox_role.ResumeLayout(false);
            this.groupBox_role.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label_username;
        private Label label_password;
        private TextBox textBox_username;
        private TextBox textBox_password;
        private Button button_login;
        private Button button_exit;
        private LinkLabel linkLabel_register;
        private Label label_login;
        private GroupBox groupBox_role;
        private RadioButton radioButton_admin;
        private RadioButton radioButton_user;
    }
}
