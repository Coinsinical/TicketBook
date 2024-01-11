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
using TicketBook.Views.Admin;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TicketBook.Views.User
{
    public partial class OrderViewControl : UserControl
    {
        BaseDAO baseDAO = new BaseDAO();
        private int userid;
        public OrderViewControl()
        {
            InitializeComponent();
        }

        public OrderViewControl(int Userid)
        {
            InitializeComponent();
            userid = Userid;
        }

        public void getData()
        {
            //清除按钮绑定，在一次运行多次点击查询按钮时会导致列不断往后添加修改和删除按钮
            dataGridView_order.Columns.Clear();

            string sql = "SELECT OrderID AS 订单ID,MovieName AS 电影名,ShowTime AS 开场时间,SeatInfo AS 座位,OrderStatus AS 订单状态,TotalAmount AS 总价 FROM Orders,Movies WHERE Orders.MovieID = Movies.MovieID AND UserID = " + userid;//以升序排列
            // string sql = "SELECT * FROM Users";//以升序排列
            DataSet dataSet = baseDAO.getDataSet(sql);
            dataGridView_order.DataSource = dataSet.Tables[0];

            // dataGridView_film.Columns["电影ID"].ReadOnly = true;

            DataGridViewButtonColumn btn_del = new DataGridViewButtonColumn();
            btn_del.Name = "btn_delete";
            btn_del.HeaderText = "操作";
            btn_del.DefaultCellStyle.NullValue = "删除";
            btn_del.Width = 50;
            dataGridView_order.Columns.Add(btn_del);//添加修改按钮
        }

        private void dataGridView_user_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_film_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewButtonColumn btnCol = dataGridView_order.Columns[e.ColumnIndex] as DataGridViewButtonColumn;
            // MessageBox.Show("当前点击的列索引为："+ e.ColumnIndex.ToString() + "列表头为" + dataGridView_user.Columns[e.ColumnIndex].HeaderText);

            BaseDAO baseDAO = new BaseDAO();
            if (btnCol != null)
            {
                int rowindex = e.RowIndex; // 获取行索引
                int movieID = Convert.ToInt32(dataGridView_order.Rows[rowindex].Cells["电影ID"].Value);

                // MessageBox.Show("当前点击的列是：" + btnCol.HeaderText);
                string statusbtn = btnCol.Name;//获取当前点击的按钮Text
                if (statusbtn == "btn_del")
                {
                    //删除
                    this.dataGridView_order.Rows.RemoveAt(e.RowIndex);//删除当前行
                    // MessageBox.Show("0:" + value0 + ",1:" + value1 + ",2:" + value2);//查看在点击按钮时能不能获取到该行的所有数据；如果不想写多余代码也可以用debug查看。
                    string sqldel = "delete from Movies where MovieID = " + movieID;//删除选中行数据
                    // MessageBox.Show(sqldel);
                    baseDAO.dosqlcom(sqldel);
                    getData();
                }
            }
        }

        private void FilmManagerControl_Load(object sender, EventArgs e)
        {
            getData();
        }
    }
}
