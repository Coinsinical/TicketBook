using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketBook.Controls.AdminControls;
using TicketBook.Views.User;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TicketBook
{
    public partial class UserForm : Form
    {
        private int userid;
        public UserForm()
        {
            InitializeComponent();
        }

        public UserForm(int Userid)
        {
            InitializeComponent();
            userid = Userid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void treeView_admin_menu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = treeView_admin_menu.SelectedNode;

            if (selectedNode != null)
            {
                // 在这里使用 selectedNode 来访问选中的项的信息
                string nodeName = selectedNode.Name; // 获取选中项的文本

                if (nodeName == "FilmView")
                {
                    SetPanelForm(new FilmViewControl(userid));
                }
            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // LoginForm.Instance.SetPanelForm(new LoginControl());
            SetPanelForm(new UserManagerControl());
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
