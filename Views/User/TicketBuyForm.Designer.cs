namespace TicketBook.Views.User
{
    partial class TicketBuyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            ""}, -1);
            this.label_screening = new System.Windows.Forms.Label();
            this.comboBox_screening = new System.Windows.Forms.ComboBox();
            this.listView_seats = new System.Windows.Forms.ListView();
            this.button_confirm = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_screening
            // 
            this.label_screening.AutoSize = true;
            this.label_screening.Location = new System.Drawing.Point(32, 25);
            this.label_screening.Name = "label_screening";
            this.label_screening.Size = new System.Drawing.Size(80, 18);
            this.label_screening.TabIndex = 0;
            this.label_screening.Text = "选择场次";
            // 
            // comboBox_screening
            // 
            this.comboBox_screening.FormattingEnabled = true;
            this.comboBox_screening.Location = new System.Drawing.Point(118, 17);
            this.comboBox_screening.Name = "comboBox_screening";
            this.comboBox_screening.Size = new System.Drawing.Size(462, 26);
            this.comboBox_screening.TabIndex = 1;
            this.comboBox_screening.SelectedIndexChanged += new System.EventHandler(this.comboBox_screening_SelectedIndexChanged);
            // 
            // listView_seats
            // 
            this.listView_seats.CheckBoxes = true;
            this.listView_seats.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            this.listView_seats.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView_seats.Location = new System.Drawing.Point(118, 67);
            this.listView_seats.Name = "listView_seats";
            this.listView_seats.Size = new System.Drawing.Size(462, 345);
            this.listView_seats.TabIndex = 2;
            this.listView_seats.UseCompatibleStateImageBehavior = false;
            // 
            // button_confirm
            // 
            this.button_confirm.Location = new System.Drawing.Point(644, 304);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(110, 46);
            this.button_confirm.TabIndex = 3;
            this.button_confirm.Text = "确认";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(644, 366);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(110, 46);
            this.button_cancel.TabIndex = 4;
            this.button_cancel.Text = "取消";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // TicketBuyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.listView_seats);
            this.Controls.Add(this.comboBox_screening);
            this.Controls.Add(this.label_screening);
            this.Name = "TicketBuyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicketBuyForm";
            this.Load += new System.EventHandler(this.TicketBuyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_screening;
        private System.Windows.Forms.ComboBox comboBox_screening;
        private System.Windows.Forms.ListView listView_seats;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Button button_cancel;
    }
}