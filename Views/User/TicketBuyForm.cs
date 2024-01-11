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

namespace TicketBook.Views.User
{
    public partial class TicketBuyForm : Form
    {
        BaseDAO baseDAO = new BaseDAO();
        private int FilmId;
        private int userId;
        private int ticket_num = 0;
        public TicketBuyForm()
        {
            InitializeComponent();
        }

        public TicketBuyForm(int FilmID,int Userid)
        {
            InitializeComponent();
            this.FilmId = FilmID;
            this.userId = Userid;

            getScreening();

            // listView_seats.View = View.Details;
            listView_seats.Columns.Add("座位编号", 100);
            listView_seats.Columns.Add("状态", 100);
        }

        private void getScreening()
        {
            // comboBox_screening.Items.Clear();

            String sql = "SELECT * FROM Screenings WHERE MovieID = " + this.FilmId;
            DataSet ds = baseDAO.getDataSet(sql);
            comboBox_screening.DisplayMember = "StartTime"; // 设置要显示的字段
            comboBox_screening.ValueMember = "ScreeningID"; // 设置关联的值字段
            comboBox_screening.DataSource = ds.Tables[0];
        }

        private void TicketBuyForm_Load(object sender, EventArgs e)
        {
            getScreening();
        }

        // 根据场次ID加载座位信息到 ListView
        private void LoadSeatsForScreening(int screeningID)
        {
            // 清空现有座位信息
            listView_seats.Items.Clear();
            // 使用合适的 SQL 查询获取座位信息
            string query = "SELECT SeatNum, Status FROM Seats WHERE ScreeningID = " + screeningID;
            SqlDataReader reader = baseDAO.getDataReader(query);
            while (reader.Read())
            {
                string seatNum = reader["SeatNum"].ToString();
                string status = reader["Status"].ToString();

                // 添加座位信息到 ListView
                ListViewItem item = new ListViewItem(seatNum);
                item.SubItems.Add(status);

                // 根据座位状态设置 Checked 属性
                if (status == "True")
                {
                    item.Checked = true;  // 根据实际情况设置条件
                }

                listView_seats.Items.Add(item);
            }
        }

        private void comboBox_screening_SelectedIndexChanged(object sender, EventArgs e)
        {
            // MessageBox.Show(comboBox_screening.SelectedIndex.ToString());
            
                int currentScreeningID = Convert.ToInt32(comboBox_screening.SelectedValue);  // 假设场次ID是第一列

                // 根据场次ID加载座位信息到 ListView
                LoadSeatsForScreening(currentScreeningID);
        }

        private string ConcatenateSelectedSeats()
        {
            StringBuilder selectedSeatsStringBuilder = new StringBuilder();

            // 遍历 ListView 中的所有项
            foreach (ListViewItem item in listView_seats.Items)
            {
                // 获取座位信息列的文本
                string seatInfo = item.Text;

                // 获取 status 列的文本
                string status = item.SubItems[1].Text; // 假设 status 列是第二列

                // 检查项是否被选中且 status 值满足条件
                if (item.Checked && status == "False")
                {
                    // 将座位信息添加到 StringBuilder 中
                    selectedSeatsStringBuilder.Append(seatInfo);
                    ticket_num++;

                    // 如果有多个选中项，可以在座位信息之间添加分隔符
                    selectedSeatsStringBuilder.Append(", ");
                }
            }

            // 删除最后一个逗号和空格
            if (selectedSeatsStringBuilder.Length > 0)
            {
                selectedSeatsStringBuilder.Length -= 2;
            }

            // 获取最终拼接的字符串
            string selectedSeats = selectedSeatsStringBuilder.ToString();

            return selectedSeats;
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            String seats = ConcatenateSelectedSeats();
            if (ticket_num == 0)
            {
                MessageBox.Show("请至少选择一个座位");
                return;
            }
            DialogResult result = MessageBox.Show("确认购买吗？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // 检查用户点击的按钮
            if (result == DialogResult.Yes)
            {
                String sql = "SELECT * FROM Screenings WHERE ScreeningID = " + Convert.ToInt32(comboBox_screening.SelectedValue);
                DataTable ds = baseDAO.getDataSet(sql).Tables[0];
                int MovieID = Convert.ToInt32(ds.Rows[0]["MovieID"]);
                DateTime showtime = Convert.ToDateTime(ds.Rows[0]["StartTime"]);
                int price= Convert.ToInt32(ds.Rows[0]["Price"]);
                int total = price * ticket_num;
                // MessageBox.Show(seats);
                sql = "INSERT INTO Orders (UserID,MovieID,Showtime,SeatInfo,OrderStatus,TotalAmount) VALUES (" + userId + "," + MovieID + ",'" + showtime.ToString("yyyy-MM-dd HH:mm:ss") + "','" + seats + "','已完成'," + total + ")";
                MessageBox.Show(sql);
                baseDAO.dosqlcom(sql);
                this.Close();
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
