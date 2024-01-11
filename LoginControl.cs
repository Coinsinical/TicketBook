using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using TicketBook.Properties;

namespace TicketBook
{
    public partial class LoginControl : UserControl

    {
        public int RoleChoice { get; private set; }
        public int Userid { get; private set; }

        public LoginControl()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // LoginForm loginForm = LoginForm.Instance;
            // loginForm.SetPanelForm(new RegisterControl());
            LoginForm parentForm = this.ParentForm as LoginForm;
            if (parentForm != null)
            {
                parentForm.SetPanelForm(new RegisterControl());
            }
        }


        private void button_login_Click(object sender, EventArgs e)
        {
            DAO.BaseDAO sqlcont = new DAO.BaseDAO();
            string username = textBox_username.Text.ToString();
            string password = textBox_password.Text.ToString();
            if (username != "" & password != "")
            {
                string cmd = "select * from Users where Username='" + username + "' and Password='" + password + "'";
                SqlDataReader temdr = sqlcont.getDataReader(cmd);
                bool ifcom = temdr.Read();
                if (ifcom)
                {
                    // 根据 RadioButton 决定要打开的新窗体

                    // 通过列名获取 UserId 列的索引
                    int userIdIndex = temdr.GetOrdinal("UserId");

                    // 从读取器中获取 UserId 列的整数值
                    Userid = temdr.GetInt32(userIdIndex);
                    // MessageBox.Show(Userid.ToString());
                    if (radioButton_user.Checked)
                    {
                        RoleChoice = 0;
                    }
                    else if (radioButton_admin.Checked)
                    {
                        RoleChoice = 1;
                    }

                    // 关闭用户控件所在的窗体
                    Form parentForm = this.ParentForm;
                    if (parentForm != null)
                    {
                        parentForm.Close();
                    }
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！");
                }
                sqlcont.conn_close();
            }
            else
                MessageBox.Show("请填写用户名和密码！");

        }
    }
}
