using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketBook.Controls.AdminControls;
using TicketBook.DAO;

namespace TicketBook.Views.Admin
{
    public partial class FilmAddForm : Form
    {
        private FilmManagerControl f = null;
        public FilmAddForm()
        {
            InitializeComponent();
        }

        public FilmAddForm(FilmManagerControl fc)
        {
            InitializeComponent();
            f = fc;
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            BaseDAO baseDAO = new BaseDAO();
            string movieName = textBox_moviename.Text;
            string genre = textBox_genre.Text;
            string director = textBox_directors.Text;
            string actors = textBox_actors.Text;
            string duration = textBox_durations.Text;
            string rating = textBox_rating.Text;
            DateTime releaseDate = dateTimePicker1.Value;

            string sql = $"INSERT INTO Movies (MovieName, Genre, Director, Actors, DurationMinutes, MovieRating, ReleaseDate) VALUES ('{movieName}', '{genre}', '{director}', '{actors}', '{duration}', '{rating}', '{releaseDate.ToString("yyyy-MM-dd")}')";
            baseDAO.dosqlcom(sql);

            f.getData();
            this.Close();
        }
    }
}
