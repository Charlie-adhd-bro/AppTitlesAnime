using System.ComponentModel;
using AppContext = AppTitlesAnime.Modules.AppContext;

namespace AppTitlesAnime
{
    public partial class FormAddStatuses : Form
    {
        private AppContext db;

        public FormAddStatuses()
        {
            InitializeComponent();
            db = new AppContext(); 
        }

        private void textBoxStatusName_TextChanged(object sender, EventArgs e)
        {
            ValidateStatusName();
        }

        private void textBoxStatusName_Validating(object sender, CancelEventArgs e)
        {
            ValidateStatusName();
        }

        private void ValidateStatusName()
        {
            if (String.IsNullOrEmpty(textBoxStatusName.Text))
            {
                errorProvider.SetError(textBoxStatusName, "Поле не может быть пустым");
                btnSaveChanges.Enabled = false;
                return;
            }

            string userStatus = textBoxStatusName.Text.Trim();

            try
            {
                bool statusExists = db.Statuses.Any(g => g.StatusName.ToLower() == userStatus.ToLower());

                if (statusExists)
                {
                    errorProvider.SetError(textBoxStatusName, "Такой объект уже существует");
                    btnSaveChanges.Enabled = false;
                }
                else
                {
                    errorProvider.SetError(textBoxStatusName, string.Empty);
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