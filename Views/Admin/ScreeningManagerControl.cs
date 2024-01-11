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
    public partial class ScreeningManagerControl : UserControl
    {
        BaseDAO baseDAO = new BaseDAO();
        public ScreeningManagerControl()
        {
            InitializeComponent();
        }

        private void getData()
        {
            //清除按钮绑定，在一次运行多次点击查询按钮时会导致列不断往后添加修改和删除按钮
            dataGridView_screening.Columns.Clear();

            string sql = "SELECT MovieName AS 电影名,ScreeningID AS 场次ID,StartTime AS 开场时间, HallName AS 影厅名,Price AS 票价 FROM MovieScreeningView";//以升序排列
            // string sql = "SELECT * FROM Users";//以升序排列
            DataSet dataSet = baseDAO.getDataSet(sql);
            dataGridView_screening.DataSource = dataSet.Tables[0];

            dataGridView_screening.Columns["场次ID"].ReadOnly = true;

            DataGridViewButtonColumn btn_mod = new DataGridViewButtonColumn();
            btn_mod.Name = "btn_mod";
            btn_mod.HeaderText = "操作";
            btn_mod.DefaultCellStyle.NullValue = "修改";
            btn_mod.Width = 50;
            dataGridView_screening.Columns.Add(btn_mod);//添加修改按钮

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
            dataGridView_screening.Columns.Add(btn_delete);//添加删除按钮

            sql = "SELECT MovieName,MovieID FROM Movies";
            DataSet dataSet_movie = baseDAO.getDataSet(sql);
            comboBox_moviename.DataSource = dataSet_movie.Tables[0];
            comboBox_moviename.DisplayMember = "MovieName"; // 设置要显示的字段
            comboBox_moviename.ValueMember = "MovieID"; // 设置关联的值字段

            sql = "SELECT HallName,HallID FROM Halls";
            DataSet dataSet_hallname = baseDAO.getDataSet(sql);
            comboBox_hallname.DataSource = dataSet_hallname.Tables[0];
            comboBox_hallname.DisplayMember = "HallName"; // 设置要显示的字段
            comboBox_hallname.ValueMember = "HallID"; // 设置关联的值字段

            comboBox_hour.SelectedIndex = 0;
            comboBox_minute.SelectedIndex = 0;
            // comboBox_hallname.SelectedIndex = 0;
            // comboBox_moviename.SelectedIndex = 0;
        }

        private void dataGridView_user_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_user_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewButtonColumn btnCol = dataGridView_screening.Columns[e.ColumnIndex] as DataGridViewButtonColumn;
            // MessageBox.Show("当前点击的列索引为："+ e.ColumnIndex.ToString() + "列表头为" + dataGridView_user.Columns[e.ColumnIndex].HeaderText);

            BaseDAO baseDAO = new BaseDAO();
            if (btnCol != null)
            {
                int rowindex = e.RowIndex; // 获取行索引
                int screeningid = Convert.ToInt32(dataGridView_screening.Rows[rowindex].Cells["场次ID"].Value); //获取userid
                int price = Convert.ToInt32(dataGridView_screening.Rows[rowindex].Cells["票价"].Value); //获取userid
                // MessageBox.Show(userid.ToString());
                String moviename = dataGridView_screening.Rows[rowindex].Cells["电影名"].Value.ToString();
                String hallname = dataGridView_screening.Rows[rowindex].Cells["影厅名"].Value.ToString();

                // MessageBox.Show("当前点击的列是：" + btnCol.HeaderText);
                string statusbtn = btnCol.Name;//获取当前点击的按钮Text
                if (statusbtn == "btn_delete")
                {
                    //删除
                    this.dataGridView_screening.Rows.RemoveAt(e.RowIndex);//删除当前行
                    // MessageBox.Show("0:" + value0 + ",1:" + value1 + ",2:" + value2);//查看在点击按钮时能不能获取到该行的所有数据；如果不想写多余代码也可以用debug查看。
                    string sqldel = "delete from Screenings where ScreeningID = " + screeningid;//删除选中行数据
                    // MessageBox.Show(sqldel);
                    baseDAO.dosqlcom(sqldel);
                    getData();
                }
                else if (statusbtn == "btn_mod")
                {
                    //修改和插入
                    if (dataGridView_screening.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex > -1)
                    {
                        // MessageBox.Show(role);
                        string sql = "update Screenings set Movie ='" + moviename + "',HallName='" + hallname + "',Price="+ price + "' where ScreeningID = " + screeningid;
                        // MessageBox.Show(sql);
                        baseDAO.dosqlcom(sql);
                        getData();
                    }
                }
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            this.textBox_price.Visible = true;

            comboBox_moviename.Visible = true;
            comboBox_minute.Visible = true;
            comboBox_hour.Visible = true;
            comboBox_hallname.Visible = true;

            dateTimePicker1.Visible = true;

            this.label_time.Visible = true;
            this.label_hallname.Visible = true;
            label_moviename.Visible = true;
            label_price.Visible = true;

            textBox_price.Visible = true;

            button_cancel.Visible = true;
            button_confirm.Visible = true;
        }

        private void UserManagerControl_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void clearInput()
        {
            comboBox_hallname.Visible = false;
            comboBox_moviename.Visible = false;
            comboBox_hour.Visible = false;
            comboBox_minute.Visible = false;

            dateTimePicker1.Visible = false;
            comboBox_hour.SelectedIndex = 0;
            comboBox_minute.SelectedIndex = 0;
            //comboBox_hallname.SelectedIndex = 0;
            //comboBox_moviename.SelectedIndex = 0;

            label_hallname.Visible = false;
            label_price.Visible = false;
            label_moviename.Visible = false;
            label_time.Visible = false;

            textBox_price.Visible = false;

            button_cancel.Visible = false;
            button_confirm.Visible = false;

            textBox_price.Clear();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            clearInput();
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            String price = textBox_price.Text;
            int movieid = Convert.ToInt32(comboBox_moviename.SelectedValue);
            // MessageBox.Show(movieid.ToString());
            int hallid = Convert.ToInt32(comboBox_hallname.SelectedValue);

            // 获取日期和时间部分
            DateTime selectedDate = dateTimePicker1.Value.Date;
            int selectedHour = int.Parse(comboBox_hour.SelectedItem.ToString());
            int selectedMinute = int.Parse(comboBox_minute.SelectedItem.ToString());

            // 构建完整的日期时间
            DateTime selectedDateTime = selectedDate.AddHours(selectedHour).AddMinutes(selectedMinute);

            // 显示结果
            // MessageBox.Show("选择的日期和时间是：" + selectedDateTime.ToString("yyyy-MM-dd HH:mm:ss"));

            if (price == null)
            {
                MessageBox.Show("票价不能为空！");
                return;
            }
            BaseDAO baseDAO = new BaseDAO();
            //插入数据
            string insertSql = "INSERT INTO Screenings (MovieID, HallID, StartTime, Price) VALUES ('" + movieid + "','" + hallid + "','" + selectedDateTime.ToString("yyyy-MM-dd HH:mm:ss") +  "'," + price + ")";
            // MessageBox.Show(insertsql);
            baseDAO.dosqlcom(insertSql);
            getData();
            clearInput();
        }
    }
}
