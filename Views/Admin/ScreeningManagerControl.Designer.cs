namespace TicketBook.Controls.AdminControls
{
    partial class ScreeningManagerControl
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
            this.dataGridView_screening = new System.Windows.Forms.DataGridView();
            this.btn_insert = new System.Windows.Forms.Button();
            this.label_moviename = new System.Windows.Forms.Label();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.label_hallname = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.comboBox_hallname = new System.Windows.Forms.ComboBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_confirm = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox_hour = new System.Windows.Forms.ComboBox();
            this.comboBox_minute = new System.Windows.Forms.ComboBox();
            this.label_price = new System.Windows.Forms.Label();
            this.comboBox_moviename = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_screening)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_screening
            // 
            this.dataGridView_screening.AllowDrop = true;
            this.dataGridView_screening.AllowUserToAddRows = false;
            this.dataGridView_screening.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_screening.Location = new System.Drawing.Point(30, 173);
            this.dataGridView_screening.Name = "dataGridView_screening";
            this.dataGridView_screening.RowHeadersWidth = 62;
            this.dataGridView_screening.RowTemplate.Height = 30;
            this.dataGridView_screening.Size = new System.Drawing.Size(735, 472);
            this.dataGridView_screening.TabIndex = 0;
            this.dataGridView_screening.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_user_CellClick);
            this.dataGridView_screening.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_user_CellContentClick);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(612, 38);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(153, 42);
            this.btn_insert.TabIndex = 1;
            this.btn_insert.Text = "新增场次";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // label_moviename
            // 
            this.label_moviename.AutoSize = true;
            this.label_moviename.Location = new System.Drawing.Point(27, 117);
            this.label_moviename.Name = "label_moviename";
            this.label_moviename.Size = new System.Drawing.Size(62, 18);
            this.label_moviename.TabIndex = 2;
            this.label_moviename.Text = "电影名";
            this.label_moviename.Visible = false;
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(469, 112);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(100, 28);
            this.textBox_price.TabIndex = 3;
            this.textBox_price.Visible = false;
            // 
            // label_hallname
            // 
            this.label_hallname.AutoSize = true;
            this.label_hallname.Location = new System.Drawing.Point(213, 115);
            this.label_hallname.Name = "label_hallname";
            this.label_hallname.Size = new System.Drawing.Size(62, 18);
            this.label_hallname.TabIndex = 4;
            this.label_hallname.Text = "影厅名";
            this.label_hallname.Visible = false;
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(27, 143);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(80, 18);
            this.label_time.TabIndex = 6;
            this.label_time.Text = "开场时间";
            this.label_time.Visible = false;
            // 
            // comboBox_hallname
            // 
            this.comboBox_hallname.FormattingEnabled = true;
            this.comboBox_hallname.Items.AddRange(new object[] {
            "用户",
            "管理员"});
            this.comboBox_hallname.Location = new System.Drawing.Point(281, 112);
            this.comboBox_hallname.Name = "comboBox_hallname";
            this.comboBox_hallname.Size = new System.Drawing.Size(121, 26);
            this.comboBox_hallname.TabIndex = 7;
            this.comboBox_hallname.Visible = false;
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(690, 112);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 28);
            this.button_cancel.TabIndex = 8;
            this.button_cancel.Text = "取消";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Visible = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_confirm
            // 
            this.button_confirm.Location = new System.Drawing.Point(609, 112);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(75, 28);
            this.button_confirm.TabIndex = 9;
            this.button_confirm.Text = "确认";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Visible = false;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_title.Location = new System.Drawing.Point(23, 38);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(146, 41);
            this.label_title.TabIndex = 10;
            this.label_title.Text = "场次列表";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(113, 139);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 28);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.Visible = false;
            // 
            // comboBox_hour
            // 
            this.comboBox_hour.FormattingEnabled = true;
            this.comboBox_hour.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.comboBox_hour.Location = new System.Drawing.Point(320, 140);
            this.comboBox_hour.Name = "comboBox_hour";
            this.comboBox_hour.Size = new System.Drawing.Size(121, 26);
            this.comboBox_hour.TabIndex = 12;
            this.comboBox_hour.Visible = false;
            // 
            // comboBox_minute
            // 
            this.comboBox_minute.FormattingEnabled = true;
            this.comboBox_minute.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60"});
            this.comboBox_minute.Location = new System.Drawing.Point(448, 141);
            this.comboBox_minute.Name = "comboBox_minute";
            this.comboBox_minute.Size = new System.Drawing.Size(121, 26);
            this.comboBox_minute.TabIndex = 13;
            this.comboBox_minute.Visible = false;
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(408, 115);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(44, 18);
            this.label_price.TabIndex = 14;
            this.label_price.Text = "票价";
            this.label_price.Visible = false;
            // 
            // comboBox_moviename
            // 
            this.comboBox_moviename.FormattingEnabled = true;
            this.comboBox_moviename.Items.AddRange(new object[] {
            "用户",
            "管理员"});
            this.comboBox_moviename.Location = new System.Drawing.Point(86, 109);
            this.comboBox_moviename.Name = "comboBox_moviename";
            this.comboBox_moviename.Size = new System.Drawing.Size(121, 26);
            this.comboBox_moviename.TabIndex = 15;
            this.comboBox_moviename.Visible = false;
            // 
            // ScreeningManagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox_moviename);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.comboBox_minute);
            this.Controls.Add(this.comboBox_hour);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.comboBox_hallname);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label_hallname);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.label_moviename);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.dataGridView_screening);
            this.Name = "ScreeningManagerControl";
            this.Size = new System.Drawing.Size(795, 680);
            this.Load += new System.EventHandler(this.UserManagerControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_screening)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_screening;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Label label_moviename;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.Label label_hallname;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.ComboBox comboBox_hallname;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox_hour;
        private System.Windows.Forms.ComboBox comboBox_minute;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.ComboBox comboBox_moviename;
    }
}
