using System;
using System.ComponentModel;
using System.Linq;
using AppContext = AppTitlesAnime.Modules.AppContext;

namespace AppTitlesAnime
{
    public partial class FormAddType : Form
    {
        private AppContext db;

        public FormAddType()
        {
            InitializeComponent();
            db = new AppContext(); 
        }

        private void TextBoxTypeName_TextChanged(object sender, EventArgs e)
        {
            ValidateTypeName();
        }

        private void TextBoxTypeName_Validating(object sender, CancelEventArgs e)
        {
            ValidateTypeName();
        }

        private void ValidateTypeName()
        {
            if (String.IsNullOrEmpty(textBoxTypeName.Text))
            {
                errorProvider.SetError(textBoxTypeName, "Поле не может быть пустым");
                btnSaveChanges.Enabled = false;
                return;
            }

            string typeName = textBoxTypeName.Text.Trim();

            try
            {
                bool typeExists = db.Types.Any(t => t.TypeName.ToLower() == typeName.ToLower());

                if (typeExists)
                {
                    errorProvider.SetError(textBoxTypeName, "Такой объект уже существует");
                    btnSaveChanges.Enabled = false;
                }
                else
                {
                    errorProvider.SetError(textBoxTypeName, string.Empty);
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