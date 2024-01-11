using System.Drawing;
using System;
using System.Windows.Forms;

namespace TicketBook.Views.Admin
{
    partial class FilmAddForm
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
            this.label_moviename = new System.Windows.Forms.Label();
            this.textBox_moviename = new System.Windows.Forms.TextBox();
            this.label_genre = new System.Windows.Forms.Label();
            this.textBox_genre = new System.Windows.Forms.TextBox();
            this.textBox_actors = new System.Windows.Forms.TextBox();
            this.label_actors = new System.Windows.Forms.Label();
            this.textBox_directors = new System.Windows.Forms.TextBox();
            this.label_director = new System.Windows.Forms.Label();
            this.textBox_rating = new System.Windows.Forms.TextBox();
            this.label_rating = new System.Windows.Forms.Label();
            this.textBox_durations = new System.Windows.Forms.TextBox();
            this.label_duration = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_confirm = new System.Windows.Forms.Button();
            this.label_releasedate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label_moviename
            // 
            this.label_moviename.AutoSize = true;
            this.label_moviename.Location = new System.Drawing.Point(13, 39);
            this.label_moviename.Name = "label_moviename";
            this.label_moviename.Size = new System.Drawing.Size(62, 18);
            this.label_moviename.TabIndex = 0;
            this.label_moviename.Text = "电影名";
            // 
            // textBox_moviename
            // 
            this.textBox_moviename.Location = new System.Drawing.Point(112, 36);
            this.textBox_moviename.Name = "textBox_moviename";
            this.textBox_moviename.Size = new System.Drawing.Size(261, 28);
            this.textBox_moviename.TabIndex = 1;
            // 
            // label_genre
            // 
            this.label_genre.AutoSize = true;
            this.label_genre.Location = new System.Drawing.Point(410, 39);
            this.label_genre.Name = "label_genre";
            this.label_genre.Size = new System.Drawing.Size(80, 18);
            this.label_genre.TabIndex = 2;
            this.label_genre.Text = "电影种类";
            // 
            // textBox_genre
            // 
            this.textBox_genre.Location = new System.Drawing.Point(513, 36);
            this.textBox_genre.Name = "textBox_genre";
            this.textBox_genre.Size = new System.Drawing.Size(261, 28);
            this.textBox_genre.TabIndex = 3;
            // 
            // textBox_actors
            // 
            this.textBox_actors.Location = new System.Drawing.Point(513, 105);
            this.textBox_actors.Name = "textBox_actors";
            this.textBox_actors.Size = new System.Drawing.Size(261, 28);
            this.textBox_actors.TabIndex = 7;
            // 
            // label_actors
            // 
            this.label_actors.AutoSize = true;
            this.label_actors.Location = new System.Drawing.Point(410, 108);
            this.label_actors.Name = "label_actors";
            this.label_actors.Size = new System.Drawing.Size(44, 18);
            this.label_actors.TabIndex = 6;
            this.label_actors.Text = "演员";
            this.label_actors.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox_directors
            // 
            this.textBox_directors.Location = new System.Drawing.Point(112, 105);
            this.textBox_directors.Name = "textBox_directors";
            this.textBox_directors.Size = new System.Drawing.Size(261, 28);
            this.textBox_directors.TabIndex = 5;
            // 
            // label_director
            // 
            this.label_director.AutoSize = true;
            this.label_director.Location = new System.Drawing.Point(13, 108);
            this.label_director.Name = "label_director";
            this.label_director.Size = new System.Drawing.Size(44, 18);
            this.label_director.TabIndex = 4;
            this.label_director.Text = "导演";
            // 
            // textBox_rating
            // 
            this.textBox_rating.Location = new System.Drawing.Point(513, 178);
            this.textBox_rating.Name = "textBox_rating";
            this.textBox_rating.Size = new System.Drawing.Size(261, 28);
            this.textBox_rating.TabIndex = 11;
            // 
            // label_rating
            // 
            this.label_rating.AutoSize = true;
            this.label_rating.Location = new System.Drawing.Point(410, 181);
            this.label_rating.Name = "label_rating";
            this.label_rating.Size = new System.Drawing.Size(44, 18);
            this.label_rating.TabIndex = 10;
            this.label_rating.Text = "评分";
            // 
            // textBox_durations
            // 
            this.textBox_durations.Location = new System.Drawing.Point(112, 178);
            this.textBox_durations.Name = "textBox_durations";
            this.textBox_durations.Size = new System.Drawing.Size(261, 28);
            this.textBox_durations.TabIndex = 9;
            // 
            // label_duration
            // 
            this.label_duration.AutoSize = true;
            this.label_duration.Location = new System.Drawing.Point(13, 181);
            this.label_duration.Name = "label_duration";
            this.label_duration.Size = new System.Drawing.Size(44, 18);
            this.label_duration.TabIndex = 8;
            this.label_duration.Text = "时长";
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(440, 315);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(94, 45);
            this.button_cancel.TabIndex = 13;
            this.button_cancel.Text = "取消";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // button_confirm
            // 
            this.button_confirm.Location = new System.Drawing.Point(279, 315);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(94, 45);
            this.button_confirm.TabIndex = 14;
            this.button_confirm.Text = "确定";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // label_releasedate
            // 
            this.label_releasedate.AutoSize = true;
            this.label_releasedate.Location = new System.Drawing.Point(13, 252);
            this.label_releasedate.Name = "label_releasedate";
            this.label_releasedate.Size = new System.Drawing.Size(80, 18);
            this.label_releasedate.TabIndex = 15;
            this.label_releasedate.Text = "上映时间";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(112, 245);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(261, 28);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // FilmAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label_releasedate);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.textBox_rating);
            this.Controls.Add(this.label_rating);
            this.Controls.Add(this.textBox_durations);
            this.Controls.Add(this.label_duration);
            this.Controls.Add(this.textBox_actors);
            this.Controls.Add(this.label_actors);
            this.Controls.Add(this.textBox_directors);
            this.Controls.Add(this.label_director);
            this.Controls.Add(this.textBox_genre);
            this.Controls.Add(this.label_genre);
            this.Controls.Add(this.textBox_moviename);
            this.Controls.Add(this.label_moviename);
            this.Name = "FilmAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FilmAddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private Label label_moviename;
        private TextBox textBox_moviename;
        private Label label_genre;
        private TextBox textBox_genre;
        private TextBox textBox_actors;
        private Label label_actors;
        private TextBox textBox_directors;
        private Label label_director;
        private TextBox textBox_rating;
        private Label label_rating;
        private TextBox textBox_durations;
        private Label label_duration;
        private Button button_cancel;
        private Button button_confirm;
        private Label label_releasedate;
        private DateTimePicker dateTimePicker1;
    }
}