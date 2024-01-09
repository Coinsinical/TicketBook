using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TicketBook
{
    public partial class RegisterControl : UserControl
    {
        public RegisterControl()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // LoginForm loginForm = LoginForm.Instance;
            // loginForm.SetPanelForm(new RegisterControl());
            LoginForm parentForm = this.ParentForm as LoginForm;
            if (parentForm != null)
            {
                parentForm.SetPanelForm(new LoginControl());
            }
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            DAO.BaseDAO sqlcont = new DAO.BaseDAO();
            String username = textBox_username.Text.ToString();
            String password = textBox_password.Text.ToString();
            if (password == textBox_confirm_password.Text.ToString())
                try
                {
                    // 在 SQL 查询中，单引号（'）用于表示文本字符串值。它的作用是告诉数据库引号之间的内容应被视为字符串，而不是 SQL 语句的一部分。
                    string cmd = "INSERT INTO Users(Username, Password, Role) VALUES ('" + username + "', '" + password + "', 0)";
                    sqlcont.dosqlcom(cmd);
                    MessageBox.Show("注册成功！");
                    //切换用户，或返回登录窗口
                    Application.Restart();
                }
                catch (DataException data)
                {
                    Console.Write(data.Message);
                }
            else
            {
                MessageBox.Show("两次密码输入不一致！请检查后再次尝试");
            }

        }
    }
}
