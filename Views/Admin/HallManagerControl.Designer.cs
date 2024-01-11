namespace TicketBook.Controls.AdminControls
{
    partial class HallManagerControl
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
            this.dataGridView_hall = new System.Windows.Forms.DataGridView();
            this.btn_insert = new System.Windows.Forms.Button();
            this.label_hallname = new System.Windows.Forms.Label();
            this.textBox_hallname = new System.Windows.Forms.TextBox();
            this.textBox_seats_num = new System.Windows.Forms.TextBox();
            this.label_seats_num = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_confirm = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hall)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_hall
            // 
            this.dataGridView_hall.AllowDrop = true;
            this.dataGridView_hall.AllowUserToAddRows = false;
            this.dataGridView_hall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_hall.Location = new System.Drawing.Point(30, 173);
            this.dataGridView_hall.Name = "dataGridView_hall";
            this.dataGridView_hall.RowHeadersWidth = 62;
            this.dataGridView_hall.RowTemplate.Height = 30;
            this.dataGridView_hall.Size = new System.Drawing.Size(735, 472);
            this.dataGridView_hall.TabIndex = 0;
            this.dataGridView_hall.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_user_CellClick);
            this.dataGridView_hall.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_hall_CellContentClick);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(612, 38);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(153, 42);
            this.btn_insert.TabIndex = 1;
            this.btn_insert.Text = "新增影厅";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // label_hallname
            // 
            this.label_hallname.AutoSize = true;
            this.label_hallname.Location = new System.Drawing.Point(27, 117);
            this.label_hallname.Name = "label_hallname";
            this.label_hallname.Size = new System.Drawing.Size(62, 18);
            this.label_hallname.TabIndex = 2;
            this.label_hallname.Text = "影厅名";
            this.label_hallname.Visible = false;
            // 
            // textBox_hallname
            // 
            this.textBox_hallname.Location = new System.Drawing.Point(95, 112);
            this.textBox_hallname.Name = "textBox_hallname";
            this.textBox_hallname.Size = new System.Drawing.Size(100, 28);
            this.textBox_hallname.TabIndex = 3;
            this.textBox_hallname.Visible = false;
            // 
            // textBox_seats_num
            // 
            this.textBox_seats_num.Location = new System.Drawing.Point(306, 112);
            this.textBox_seats_num.Name = "textBox_seats_num";
            this.textBox_seats_num.Size = new System.Drawing.Size(100, 28);
            this.textBox_seats_num.TabIndex = 5;
            this.textBox_seats_num.Visible = false;
            // 
            // label_seats_num
            // 
            this.label_seats_num.AutoSize = true;
            this.label_seats_num.Location = new System.Drawing.Point(220, 117);
            this.label_seats_num.Name = "label_seats_num";
            this.label_seats_num.Size = new System.Drawing.Size(80, 18);
            this.label_seats_num.TabIndex = 4;
            this.label_seats_num.Text = "座位数量";
            this.label_seats_num.Visible = false;
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
            this.label_title.Text = "影厅列表";
            // 
            // HallManagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.textBox_seats_num);
            this.Controls.Add(this.label_seats_num);
            this.Controls.Add(this.textBox_hallname);
            this.Controls.Add(this.label_hallname);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.dataGridView_hall);
            this.Name = "HallManagerControl";
            this.Size = new System.Drawing.Size(795, 680);
            this.Load += new System.EventHandler(this.UserManagerControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_hall;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Label label_hallname;
        private System.Windows.Forms.TextBox textBox_hallname;
        private System.Windows.Forms.TextBox textBox_seats_num;
        private System.Windows.Forms.Label label_seats_num;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Label label_title;
    }
}
