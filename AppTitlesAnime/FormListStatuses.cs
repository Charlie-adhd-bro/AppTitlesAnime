using AppTitlesAnime.Modules;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using AppContext = AppTitlesAnime.Modules.AppContext;
using Status = AppTitlesAnime.Modules.Status;
namespace AppTitlesAnime
{
    public partial class FormListStatuses : Form
    {
        private AppContext db;

        public FormListStatuses()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
            this.db.Statuses.Load();
            this.dataGridViewStatus.DataSource = this.db.Statuses.Local.OrderBy(o => o.StatusName).ToList();

            dataGridViewStatus.Columns["Id"].Visible = false;
            dataGridViewStatus.Columns["TitleStatuses"].Visible = false;
            dataGridViewStatus.Columns["StatusName"].HeaderText = "Статус аниме";
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this.db.Dispose();
            this.db = null;
        }



        private void BtnAddStatus_Click(object sender, EventArgs e)
        {
            FormAddStatuses formAddStatus = new();
            DialogResult result = formAddStatus.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            Status status = new Status();
            status.StatusName = formAddStatus.textBoxStatusName.Text;


            db.Statuses.Add(status);
            db.SaveChanges();

            MessageBox.Show("Новый объект добавлен");

            this.dataGridViewStatus.DataSource = this.db.Statuses.Local.OrderBy(o => o.StatusName).ToList();
        }
        private void BtnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (dataGridViewStatus.SelectedRows.Count == 0)
                return;

            int index = dataGridViewStatus.SelectedRows[0].Index;
            short id = 0;

            bool converted = Int16.TryParse(dataGridViewStatus[0, index].Value.ToString(), out id);

            if (!converted)
                return;

            Status status = db.Statuses.Find(id);
            FormAddStatuses formAddStatus = new();
            formAddStatus.textBoxStatusName.Text = status.StatusName;

            DialogResult result = formAddStatus.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            status.StatusName = formAddStatus.textBoxStatusName.Text;
            db.Statuses.Update(status);
            db.SaveChanges();

            MessageBox.Show("Объект изменен");

            this.dataGridViewStatus.DataSource = this.db.Statuses.Local.OrderBy(o => o.StatusName).ToList();
        }

        private void btnDeleteStatus_Click(object sender, EventArgs e)
        {
            if (dataGridViewStatus.SelectedRows.Count == 0)
                return;

            DialogResult result = MessageBox.Show(
                "Вы уверенны, что хотите удалить объект? " +
                "\nВсе связанные данные будут удалены",
                "", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (result == DialogResult.No)
                return;

            int index = dataGridViewStatus.SelectedRows[0].Index;
            short id = 0;

            bool converted = Int16.TryParse(dataGridViewStatus[0, index].Value.ToString(), out id);

            if (!converted)
                return;

            Status status = db.Statuses.Find(id);

            db.Statuses.Remove(status);
            db.SaveChanges();

            MessageBox.Show("Объект удален");

            this.dataGridViewStatus.DataSource = this.db.Statuses.Local.OrderBy(o => o.StatusName).ToList();
        }
    }
}
