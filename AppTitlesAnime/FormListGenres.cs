using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using AppContext = AppTitlesAnime.Modules.AppContext;
using Genre = AppTitlesAnime.Modules.Genre;

namespace AppTitlesAnime
{
    public partial class FormListGenres : Form
    {
        private AppContext db;

        public FormListGenres()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
            this.db.Genres.Load();
            this.dataGridViewGenres.DataSource = this.db.Genres.Local.OrderBy(o => o.GenreName).ToList();

            dataGridViewGenres.Columns["Id"].Visible = false;
            dataGridViewGenres.Columns["TitlesGenres"].Visible = false;
            dataGridViewGenres.Columns["GenreName"].HeaderText = "Жанр аниме";
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this.db.Dispose();
            this.db = null;
        }

        private void BtnAddGenre_Click(object sender, EventArgs e)
        {
            FormAddGenre formAddGenre = new();
            DialogResult result = formAddGenre.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            string newGenreName = formAddGenre.textBoxGenreName.Text.Trim();


            Genre genre = new Genre();
            genre.GenreName = formAddGenre.textBoxGenreName.Text;


            db.Genres.Add(genre);
            db.SaveChanges();

            MessageBox.Show("Новый объект добавлен");

            this.dataGridViewGenres.DataSource = this.db.Genres.Local.OrderBy(o => o.GenreName).ToList();
        }

        private void btnUpdateGenre_Click(object sender, EventArgs e)
        {
            if (dataGridViewGenres.SelectedRows.Count == 0)
                return;

            int index = dataGridViewGenres.SelectedRows[0].Index;
            short id = 0;

            bool converted = Int16.TryParse(dataGridViewGenres[0, index].Value.ToString(), out id);

            if (!converted)
                return;

            Genre genre = db.Genres.Find(id);
            FormAddGenre formAddGenre = new();
            formAddGenre.textBoxGenreName.Text = genre.GenreName;

            DialogResult result = formAddGenre.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            genre.GenreName = formAddGenre.textBoxGenreName.Text;
            db.Genres.Update(genre);
            db.SaveChanges();

            MessageBox.Show("Объект изменен");

            // Refresh the data grid view
            this.dataGridViewGenres.DataSource = this.db.Genres.Local.OrderBy(o => o.GenreName).ToList();
        }

        private void btnDeleteGenre_Click(object sender, EventArgs e)
        {
            if (dataGridViewGenres.SelectedRows.Count == 0)
                return;

            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите удалить объект? " +
                "\nВсе связанные данные будут удалены",
                "", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
                return;

            int index = dataGridViewGenres.SelectedRows[0].Index;
            short id = 0;

            bool converted = Int16.TryParse(dataGridViewGenres[0, index].Value.ToString(), out id);

            if (!converted)
                return;

            Genre genre = db.Genres.Find(id);

            if (genre != null)
            {
                db.Genres.Remove(genre);
                db.SaveChanges();

                MessageBox.Show("Объект удален");
                // Refresh the data grid view
                this.dataGridViewGenres.DataSource = this.db.Genres.Local.OrderBy(o => o.GenreName).ToList();
            }
            
        }
    }
}