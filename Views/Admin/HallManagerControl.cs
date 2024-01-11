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
    public partial class HallManagerControl : UserControl
    {
        BaseDAO baseDAO = new BaseDAO();
        public HallManagerControl()
        {
            InitializeComponent();
        }

        private void getData()
        {
            //清除按钮绑定，在一次运行多次点击查询按钮时会导致列不断往后添加修改和删除按钮
            dataGridView_hall.Columns.Clear();

            string sql = "SELECT HallID AS 影厅ID,HallName AS 影厅名,Capacity AS 容量 FROM Halls";//以升序排列
            // string sql = "SELECT * FROM Users";//以升序排列
            DataSet dataSet = baseDAO.getDataSet(sql);
            dataGridView_hall.DataSource = dataSet.Tables[0];

            dataGridView_hall.Columns["影厅ID"].ReadOnly = true;

            DataGridViewButtonColumn btn_mod = new DataGridViewButtonColumn();
            btn_mod.Name = "btn_mod";
            btn_mod.HeaderText = "操作";
            btn_mod.DefaultCellStyle.NullValue = "修改";
            btn_mod.Width = 100;
            dataGridView_hall.Columns.Add(btn_mod);//添加修改按钮

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
            btn_delete.Width = 100;
            dataGridView_hall.Columns.Add(btn_delete);//添加删除按钮
        }

        private void dataGridView_user_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_hall_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewButtonColumn btnCol = dataGridView_hall.Columns[e.ColumnIndex] as DataGridViewButtonColumn;
            // MessageBox.Show("当前点击的列索引为："+ e.ColumnIndex.ToString() + "列表头为" + dataGridView_user.Columns[e.ColumnIndex].HeaderText);

            BaseDAO baseDAO = new BaseDAO();
            if (btnCol != null)
            {
                int rowindex = e.RowIndex; // 获取行索引
                int hallid = Convert.ToInt32(dataGridView_hall.Rows[rowindex].Cells["影厅ID"].Value); //获取userid
                // MessageBox.Show(userid.ToString());
                String hallname = dataGridView_hall.Rows[rowindex].Cells["影厅名"].Value.ToString();
                int capacity = Convert.ToInt32(dataGridView_hall.Rows[rowindex].Cells["容量"].Value);

                // MessageBox.Show("当前点击的列是：" + btnCol.HeaderText);
                string statusbtn = btnCol.Name;//获取当前点击的按钮Text
                if (statusbtn == "btn_delete")
                {
                    //删除
                    this.dataGridView_hall.Rows.RemoveAt(e.RowIndex);//删除当前行
                    // MessageBox.Show("0:" + value0 + ",1:" + value1 + ",2:" + value2);//查看在点击按钮时能不能获取到该行的所有数据；如果不想写多余代码也可以用debug查看。
                    string sqldel = "delete from Halls where HallID = " + hallid;//删除选中行数据
                    // MessageBox.Show(sqldel);
                    baseDAO.dosqlcom(sqldel);
                    getData();
                }
                else if (statusbtn == "btn_mod")
                {
                    //修改和插入
                    if (dataGridView_hall.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex > -1)
                    {
                        // MessageBox.Show(role);
                        string sql = "update Halls set HallName ='" +hallname + "',Capacity='" + capacity + "' where HallID = " + hallid;
                        // MessageBox.Show(sql);
                        baseDAO.dosqlcom(sql);
                        getData();
                    }
                }
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            this.label_seats_num.Visible = true;
            this.textBox_seats_num.Visible = true;
            this.textBox_hallname.Visible = true;
            this.label_hallname.Visible = true;
            button_cancel.Visible = true;
            button_confirm.Visible = true;
        }

        private void UserManagerControl_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void clearInput()
        {
            label_seats_num.Visible = false;
            textBox_seats_num.Visible = false;
            textBox_hallname.Visible = false;
            label_hallname.Visible = false;
            button_cancel.Visible = false;
            button_confirm.Visible = false;

            textBox_seats_num.Clear();
            textBox_hallname.Clear();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            clearInput();
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            String hallname = textBox_hallname.Text;
            String capacity = textBox_seats_num.Text;
            String sql2 = "select * from Halls where HallName = '" + hallname + "'";
            // MessageBox.Show(sql2);
            DataTable dse = baseDAO.getDataSet(sql2).Tables[0];
            //如果在数据库表中没有找到id为value0的数据那么就默认它是新增的，进入插入数数代码块
            if (dse.Rows.Count <= 1)
            {
                BaseDAO baseDAO = new BaseDAO();
                //插入数据
                string insertsql = "insert into Halls ( HallName,Capacity ) values ('" + hallname + "'," + capacity + ")";
                //MessageBox.Show(insertsql);
                baseDAO.dosqlcom(insertsql);
                getData();
                clearInput();
            }
            else
            {
                MessageBox.Show("影厅名已存在！");
            }
        }
    }
}
