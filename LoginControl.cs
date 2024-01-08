using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketBook
{
    public partial class LoginControl : UserControl
    {
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

        private void label_username_Click(object sender, EventArgs e)
        {

        }
    }
}
