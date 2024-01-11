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
using TicketBook.DAO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TicketBook.Controls.AdminControls
{
    public partial class UserManagerControl : UserControl
    {
        BaseDAO baseDAO = new BaseDAO();
        public UserManagerControl()
        {
            InitializeComponent();
        }

        private void getData()
        {
            //清除按钮绑定，在一次运行多次点击查询按钮时会导致列不断往后添加修改和删除按钮
            dataGridView_user.Columns.Clear();

            string sql = "SELECT UserID AS 用户ID,Username AS 用户名,CASE WHEN Role = 0 THEN '用户' ELSE '管理员' END AS 角色 FROM Users";//以升序排列
            // string sql = "SELECT * FROM Users";//以升序排列
            DataSet dataSet = baseDAO.getDataSet(sql);
            dataGridView_user.DataSource = dataSet.Tables[0];

            dataGridView_user.Columns["用户ID"].ReadOnly = true;
            dataGridView_user.Columns["用户ID"].Width = 70;

            dataGridView_user.Columns["用户名"].Width = 200;

            dataGridView_user.Columns["角色"].Width = 60;

            DataGridViewButtonColumn btn_mod = new DataGridViewButtonColumn();
            btn_mod.Name = "btn_mod";
            btn_mod.HeaderText = "操作";
            btn_mod.DefaultCellStyle.NullValue = "修改";
            btn_mod.Width = 50;
            dataGridView_user.Columns.Add(btn_mod);//添加修改按钮

            /*
            DataGridViewButtonColumn btn_mod_pwd = new DataGridViewButtonColumn();
            btn_mod_pwd.Name = "btn_mod_pwd";
            btn_mod_pwd.HeaderText = "";
            btn_mod_pwd.DefaultCellStyle.NullValue = "修改密码";
            btn_mod_pwd.Width = 50;
            dataGridView_user.Columns.Add(btn_mod_pwd);//添加删除按钮
            */

            DataGridViewButtonColumn btn_delete = new DataGridViewButtonColumn();
            btn_delete.Name = "btn_delete";
            btn_delete.HeaderText = "";
            btn_delete.DefaultCellStyle.NullValue = "删除";
            btn_delete.Width = 50;
            dataGridView_user.Columns.Add(btn_delete);//添加删除按钮
        }

        private void dataGridView_user_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_user_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewButtonColumn btnCol = dataGridView_user.Columns[e.ColumnIndex] as DataGridViewButtonColumn;
            // MessageBox.Show("当前点击的列索引为："+ e.ColumnIndex.ToString() + "列表头为" + dataGridView_user.Columns[e.ColumnIndex].HeaderText);

            BaseDAO baseDAO = new BaseDAO();
            if (btnCol != null)
            {
                int rowindex = e.RowIndex; // 获取行索引
                int userid = Convert.ToInt32(dataGridView_user.Rows[rowindex].Cells["用户ID"].Value); //获取userid
                // MessageBox.Show(userid.ToString());
                String username = dataGridView_user.Rows[rowindex].Cells["用户名"].Value.ToString();
                String role = dataGridView_user.Rows[rowindex].Cells["角色"].Value.ToString();

                // MessageBox.Show("当前点击的列是：" + btnCol.HeaderText);
                string statusbtn = btnCol.Name;//获取当前点击的按钮Text
                if (statusbtn == "btn_delete")
                {
                    //删除
                    this.dataGridView_user.Rows.RemoveAt(e.RowIndex);//删除当前行
                    // MessageBox.Show("0:" + value0 + ",1:" + value1 + ",2:" + value2);//查看在点击按钮时能不能获取到该行的所有数据；如果不想写多余代码也可以用debug查看。
                    string sqldel = "delete from Users where UserID = " + userid;//删除选中行数据
                    MessageBox.Show(sqldel);
                    baseDAO.dosqlcom(sqldel);
                    getData();
                }
                else if (statusbtn == "btn_mod")
                {
                    //修改和插入
                    if (dataGridView_user.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex > -1)
                    {
                        // MessageBox.Show(role);
                        int role_num = 0;
                        if (role == "管理员") { role_num = 1; }
                        else if(role == "用户") { role_num = 0; }
                        else {
                            MessageBox.Show("角色输入错误，请检查后重试！");
                            return;
                        }
                        string sql = "update Users set Username ='" +username + "',Role='" + role_num + "' where UserID = " + userid;
                        // MessageBox.Show(sql);
                        baseDAO.dosqlcom(sql);
                        getData();
                    }
                }
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            this.comboBox_role.Visible = true;
            this.label_role.Visible = true;
            this.label_password.Visible = true;
            this.textBox_password.Visible = true;
            this.textBox_username.Visible = true;
            this.label_username.Visible = true;
            button_cancel.Visible = true;
            button_confirm.Visible = true;
        }

        private void UserManagerControl_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void clearInput()
        {
            comboBox_role.Visible = false;
            label_role.Visible = false;
            label_password.Visible = false;
            textBox_password.Visible = false;
            textBox_username.Visible = false;
            label_username.Visible = false;
            button_cancel.Visible = false;
            button_confirm.Visible = false;

            textBox_password.Clear();
            textBox_username.Clear();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            clearInput();
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            String username = textBox_username.Text;
            String password = textBox_password.Text;
            int role = comboBox_role.SelectedIndex;
            if (username == null || password == null)
            {
                MessageBox.Show("用户名或密码不能为空！");
                return;
            }
            if (role == -1)
            {
                role = 0;
            }
            String sql2 = "select * from Users where username = '" + username + "'";
            // MessageBox.Show(sql2);
            DataTable dse = baseDAO.getDataSet(sql2).Tables[0];
            //如果在数据库表中没有找到id为value0的数据那么就默认它是新增的，进入插入数数代码块
            if (dse.Rows.Count <= 1)
            {
                BaseDAO baseDAO = new BaseDAO();
                //插入数据
                string insertsql = "insert into Users ( Username,Password,Role ) values ('" + username + "','" + password + "'," + role + ")";
                MessageBox.Show(insertsql);
                baseDAO.dosqlcom(insertsql);
                getData();
                clearInput();
            }
            else
            {
                MessageBox.Show("用户名已存在！");
            }
        }
    }
}
