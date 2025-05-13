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
            FormAddUpdateTittle formAddUpdateTittle = new FormAddUpdateTittle();

            List<Type> types= this.db.Types.Local.OrderBy(i => i.TypeName).ToList();
            formAddUpdateTittle.comboBoxType.DataSource = types;
            formAddUpdateTittle.comboBoxType.DisplayMember = "TypeName";
            formAddUpdateTittle.comboBoxType.ValueMember = "Id";

            DialogResult result = formAddUpdateTittle.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            AnimeTitle animeTitle = new()
            {
                OriginalName = formAddUpdateTittle.textBoxOriginalName.Text,
                Name = formAddUpdateTittle.textBoxName.Text,
                CountSeries = Convert.ToInt16(formAddUpdateTittle.numericUpDownCountSeries.Value),
                Duration = Convert.ToInt16(formAddUpdateTittle.numericUpDownDuration.Value),
                Studio = formAddUpdateTittle.textBoxStudio.Text,
                Description = formAddUpdateTittle.richTextBoxDescription.Text

            }; 
            
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
            if (dataGridViewTittles.SelectedRows.Count == 0)
                return;

            int index = dataGridViewTittles.SelectedRows[0].Index;
            int id = 0;
            bool converted = Int32.TryParse(dataGridViewTittles[0, index].Value.ToString(), out id);
            if (!converted)
                return;

            AnimeTitle animeTittle = db.AnimeTitles.Find(id);
            FormAddUpdateTittle formAddUpdateTittle = new();

            formAddUpdateTittle.textBoxOriginalName.Text = animeTittle.OriginalName;
            formAddUpdateTittle.textBoxName.Text = animeTittle.Name;
            formAddUpdateTittle.numericUpDownCountSeries.Value = animeTittle.CountSeries;
            formAddUpdateTittle.numericUpDownDuration.Value = animeTittle.Duration;
            formAddUpdateTittle.textBoxStudio.Text = animeTittle.Studio;
            formAddUpdateTittle.richTextBoxDescription.Text = animeTittle.Description;

            this.db.Types.Load();

            List<Type> types = this.db.Types.Local.OrderBy(i => i.TypeName).ToList();
            formAddUpdateTittle.comboBoxType.DataSource = types;
            formAddUpdateTittle.comboBoxType.DisplayMember = "TypeName";
            formAddUpdateTittle.comboBoxType.ValueMember = "Id";

            formAddUpdateTittle.comboBoxType.SelectedItem = animeTittle.Type;

            DialogResult result = formAddUpdateTittle.ShowDialog();

            if (result == DialogResult.Cancel)
                return;

            animeTittle.OriginalName = formAddUpdateTittle.textBoxOriginalName.Text;
            animeTittle.Name = formAddUpdateTittle.textBoxName.Text;
            animeTittle.CountSeries = Convert.ToInt16(formAddUpdateTittle.numericUpDownCountSeries.Value);
            animeTittle.Duration = Convert.ToInt16(formAddUpdateTittle.numericUpDownDuration.Value);
            animeTittle.Studio = formAddUpdateTittle.textBoxStudio.Text;
            animeTittle.Description = formAddUpdateTittle.richTextBoxDescription.Text;

            Type type = (Type)formAddUpdateTittle.comboBoxType.SelectedItem;
            animeTittle.IdType = type.Id;

            db.AnimeTitles.Update(animeTittle);
            db.SaveChanges();

            MessageBox.Show("Объект изменен", "",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.dataGridViewTittles.DataSource = db.AnimeTitles.
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
               OrderBy(i => i.TypeName).ThenBy(i => i.OriginalName).ToList();

        }

        private void btnDeleteTittles_Click(object sender, EventArgs e)
        {

        }
    }
}
