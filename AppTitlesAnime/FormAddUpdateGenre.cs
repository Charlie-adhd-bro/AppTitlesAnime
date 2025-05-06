using System.ComponentModel;
using AppContext = AppTitlesAnime.Modules.AppContext;

namespace AppTitlesAnime
{
    public partial class FormAddUpdateGenre : Form
    {
        private AppContext db;

        public FormAddUpdateGenre()
        {
            InitializeComponent();
            db = new AppContext(); 
        }

        private void TextBoxGenreName_TextChanged(object sender, EventArgs e)
        {
            ValidateGenreName();
        }

        private void textBoxGenreName_Validating(object sender, CancelEventArgs e)
        {
            ValidateGenreName();
        }

        private void ValidateGenreName()
        {
            if (String.IsNullOrEmpty(textBoxGenreName.Text))
            {
                errorProvider.SetError(textBoxGenreName, "Поле не может быть пустым");
                btnSaveChanges.Enabled = false;
                return;
            }

            string userGenre = textBoxGenreName.Text.Trim();

            try
            {
                bool genreExists = db.Genres.Any(g => g.GenreName.ToLower() == userGenre.ToLower());

                if (genreExists)
                {
                    errorProvider.SetError(textBoxGenreName, "Такой объект уже существует");
                    btnSaveChanges.Enabled = false;
                }
                else
                {
                    errorProvider.SetError(textBoxGenreName, string.Empty);
                    btnSaveChanges.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            db?.Dispose(); 
        }
    }
}