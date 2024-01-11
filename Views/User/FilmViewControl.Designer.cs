namespace TicketBook.Views.User
{
    partial class FilmViewControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_film = new System.Windows.Forms.DataGridView();
            this.label_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_film)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_film
            // 
            this.dataGridView_film.AllowDrop = true;
            this.dataGridView_film.AllowUserToAddRows = false;
            this.dataGridView_film.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_film.Location = new System.Drawing.Point(30, 173);
            this.dataGridView_film.Name = "dataGridView_film";
            this.dataGridView_film.RowHeadersWidth = 62;
            this.dataGridView_film.RowTemplate.Height = 30;
            this.dataGridView_film.Size = new System.Drawing.Size(735, 472);
            this.dataGridView_film.TabIndex = 0;
            this.dataGridView_film.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_user_CellClick);
            this.dataGridView_film.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_film_CellContentClick);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_title.Location = new System.Drawing.Point(23, 38);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(146, 41);
            this.label_title.TabIndex = 10;
            this.label_title.Text = "电影列表";
            // 
            // FilmViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.dataGridView_film);
            this.Name = "FilmViewControl";
            this.Size = new System.Drawing.Size(795, 680);
            this.Load += new System.EventHandler(this.FilmManagerControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_film)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_film;
        private System.Windows.Forms.Label label_title;
    }
}
