using AppTitlesAnime.Modules;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using AppContext = AppTitlesAnime.Modules.AppContext;
using Type = AppTitlesAnime.Modules.Type;

namespace AppTitlesAnime
{
    public partial class FormListTittles : Form
    {
        private AppContext db;
        public FormListTittles()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            base.OnLoad(e);
            this.db = new AppContext();
            this.db.Types.Load();
            this.dataGridViewTittles.DataSource = this.db.AnimeTitles.
                Include(i => i.Type).
                Select(i => new
                {
                    i.Id,
                    i.Type.TypeName,
                    i.OriginalName,
                    i.Name,
                    i.CountSeries,
                    i.Duration,
                    i.Studio
                }).
                OrderBy(i => i.TypeName).
                ThenBy(i => i.OriginalName).ToList();

            //скрытие столбцов
            dataGridViewTittles.Columns["Id"].Visible = false;

            //изменение названий заголовков столбцов
            dataGridViewTittles.Columns["TypeName"].HeaderText = "Тип";
            dataGridViewTittles.Columns["OriginalName"].HeaderText = "Оригинальное название";
            dataGridViewTittles.Columns["Name"].HeaderText = "Название";
            dataGridViewTittles.Columns["CountSeries"].HeaderText = "Количество серий";
            dataGridViewTittles.Columns["Duration"].HeaderText = "Продолжительность";
            dataGridViewTittles.Columns["Studio"].HeaderText = "Студия";
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this.db?.Dispose();
            this.db = null;
        }

        private void btnAddTittles_Click(object sender, EventArgs e)
        {
            FormAddUpdateTiitle formAddUpdateTittle = new FormAddUpdateTiitle();

            List<Type> types= this.db.Types.Local.OrderBy(i => i.TypeName).ToList();
            formAddUpdateTittle.comboBoxType.DataSource = types;
            formAddUpdateTittle.comboBoxType.DisplayMember = "TypeName";
            formAddUpdateTittle.comboBoxType.ValueMember = "Id";

            DialogResult result = formAddUpdateTittle.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            AnimeTitle animeTitle = new ();
            animeTitle.OriginalName = formAddUpdateTittle.textBoxOriginalName.Text;
            animeTitle.Name = formAddUpdateTittle.textBoxName.Text;
            animeTitle.CountSeries = Convert.ToInt16(formAddUpdateTittle.numericUpDownCountSeries.Value);
            animeTitle.Duration = Convert.ToInt16(formAddUpdateTittle.numericUpDownDuration.Value);
            animeTitle.Studio = formAddUpdateTittle.textBoxStudio.Text;
            animeTitle.Description = formAddUpdateTittle.richTextBoxDescription.Text;

            Type type = (Type)formAddUpdateTittle.comboBoxType.SelectedItem;
            animeTitle.IdType = type.Id;

            db.AnimeTitles.Add(animeTitle);
            db.SaveChanges();

            MessageBox.Show("Новый объект добавлен", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            this.dataGridViewTittles.DataSource = db.AnimeTitles.
                Include (i => i.Type).
                Select(i => new
                {
                    i.Id,
                    i.Type.TypeName,
                    i.OriginalName,
                    i.Name,
                    i.CountSeries,
                    i.Duration,
                    i.Studio
                }).
                OrderBy(i => i.TypeName).ThenBy(i => i.OriginalName).ToList();


        }

        private void btnUpdateTittles_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteTittles_Click(object sender, EventArgs e)
        {

        }
    }
}
