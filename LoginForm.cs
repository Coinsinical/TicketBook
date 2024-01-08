using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TicketBook
{
    public partial class LoginForm : Form
    {
        // 声明一个私有的静态实例变量(单例模式)
        private static LoginForm instance;

        public LoginForm()
        {
            InitializeComponent();
        }

        // 公共属性用于访问 form_container 控件
        public Panel FormContainer
        {
            get { return form_container; }
            set { form_container = value; }
        }

        // 公共的静态方法，用于获取或创建 LoginForm 的实例
        public static LoginForm Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoginForm();
                }
                return instance;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // LoginForm.Instance.SetPanelForm(new LoginControl());
            SetPanelForm(new LoginControl());
        }
        public void SetPanelForm(Control control)
        {
            // 使用 FormContainer 属性来访问 form_container 控件
            // FormContainer.Controls.Clear();
            // FormContainer.Controls.Add(control);
            // System.Diagnostics.Debug.WriteLine(FormContainer.Name);

            form_container.Controls.Clear();
            form_container.Controls.Add(control);
        }
    }
}