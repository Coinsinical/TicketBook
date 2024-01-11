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
    public partial class FilmViewControl : UserControl
    {
        BaseDAO baseDAO = new BaseDAO();
        private int userid;
        public FilmViewControl()
        {
            InitializeComponent();
        }

        public FilmViewControl(int Userid)
        {
            InitializeComponent();
            userid = Userid;
        }

        public void getData()
        {
            //清除按钮绑定，在一次运行多次点击查询按钮时会导致列不断往后添加修改和删除按钮
            dataGridView_film.Columns.Clear();

            string sql = "SELECT MovieID AS 电影ID,MovieName AS 电影名, Director AS 导演,Actors AS 演员,Genre AS 种类,DurationMinutes AS 时长,ReleaseDate AS 上映时间,MovieRating AS 评分 FROM Movies";//以升序排列
            // string sql = "SELECT * FROM Users";//以升序排列
            DataSet dataSet = baseDAO.getDataSet(sql);
            dataGridView_film.DataSource = dataSet.Tables[0];

            dataGridView_film.Columns["电影ID"].ReadOnly = true;

            DataGridViewButtonColumn btn_mod = new DataGridViewButtonColumn();
            btn_mod.Name = "btn_buy";
            btn_mod.HeaderText = "操作";
            btn_mod.DefaultCellStyle.NullValue = "购票";
            btn_mod.Width = 50;
            dataGridView_film.Columns.Add(btn_mod);//添加修改按钮
        }

        private void dataGridView_user_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_film_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewButtonColumn btnCol = dataGridView_film.Columns[e.ColumnIndex] as DataGridViewButtonColumn;
            // MessageBox.Show("当前点击的列索引为："+ e.ColumnIndex.ToString() + "列表头为" + dataGridView_user.Columns[e.ColumnIndex].HeaderText);

            BaseDAO baseDAO = new BaseDAO();
            if (btnCol != null)
            {
                int rowindex = e.RowIndex; // 获取行索引
                int movieID = Convert.ToInt32(dataGridView_film.Rows[rowindex].Cells["电影ID"].Value);

                // MessageBox.Show("当前点击的列是：" + btnCol.HeaderText);
                string statusbtn = btnCol.Name;//获取当前点击的按钮Text
                if (statusbtn == "btn_buy")
                {
                    new TicketBuyForm(movieID,userid).ShowDialog();
                }
            }
        }

        private void FilmManagerControl_Load(object sender, EventArgs e)
        {
            getData();
        }
    }
}
