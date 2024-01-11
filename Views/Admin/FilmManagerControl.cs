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

namespace TicketBook.Controls.AdminControls
{
    public partial class FilmManagerControl : UserControl
    {
        BaseDAO baseDAO = new BaseDAO();
        public FilmManagerControl()
        {
            InitializeComponent();
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
            btn_mod.Name = "btn_mod";
            btn_mod.HeaderText = "操作";
            btn_mod.DefaultCellStyle.NullValue = "修改";
            btn_mod.Width = 50;
            dataGridView_film.Columns.Add(btn_mod);//添加修改按钮

            DataGridViewButtonColumn btn_delete = new DataGridViewButtonColumn();
            btn_delete.Name = "btn_delete";
            btn_delete.HeaderText = "";
            btn_delete.DefaultCellStyle.NullValue = "删除";
            btn_delete.Width = 50;
            dataGridView_film.Columns.Add(btn_delete);//添加删除按钮
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
                string movieName = dataGridView_film.Rows[rowindex].Cells["电影名"].Value.ToString();
                string director = dataGridView_film.Rows[rowindex].Cells["导演"].Value.ToString();
                string actors = dataGridView_film.Rows[rowindex].Cells["演员"].Value.ToString();
                string genre = dataGridView_film.Rows[rowindex].Cells["种类"].Value.ToString();
                int duration = Convert.ToInt32(dataGridView_film.Rows[rowindex].Cells["时长"].Value);
                decimal rating = Convert.ToDecimal(dataGridView_film.Rows[rowindex].Cells["评分"].Value);

                // MessageBox.Show("当前点击的列是：" + btnCol.HeaderText);
                string statusbtn = btnCol.Name;//获取当前点击的按钮Text
                if (statusbtn == "btn_delete")
                {
                    //删除
                    this.dataGridView_film.Rows.RemoveAt(e.RowIndex);//删除当前行
                    // MessageBox.Show("0:" + value0 + ",1:" + value1 + ",2:" + value2);//查看在点击按钮时能不能获取到该行的所有数据；如果不想写多余代码也可以用debug查看。
                    string sqldel = "delete from Movies where MovieID = " + movieID;//删除选中行数据
                    // MessageBox.Show(sqldel);
                    baseDAO.dosqlcom(sqldel);
                    getData();
                }
                else if (statusbtn == "btn_mod")
                {
                    //修改和插入
                    if (dataGridView_film.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex > -1)
                    {
                        // MessageBox.Show(role);
                        int role_num = 0;
                        string updateSql = $"UPDATE Movies SET " +
                   $"MovieName = '{movieName}', " +
                   $"Director = '{director}', " +
                   $"Actors = '{actors}', " +
                   $"Genre = '{genre}', " +
                   $"DurationMinutes = '{duration}', " +
                   $"MovieRating = '{rating}' " +
                   $"WHERE MovieID = {movieID};";
                        // MessageBox.Show(sql);
                        baseDAO.dosqlcom(updateSql);
                        getData();
                    }
                }
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            new FilmAddForm(this).Show();
        }

        private void FilmManagerControl_Load(object sender, EventArgs e)
        {
            getData();
        }
    }
}
