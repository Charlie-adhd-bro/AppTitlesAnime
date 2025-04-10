using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using AppContext = AppTitlesAnime.Modules.AppContext;
namespace AppTitlesAnime
{
    public partial class FormListTypes : Form
    {
        private AppContext db;

        public FormListTypes()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
            this.db.Types.Load();
            this.dataGridViewTypes.DataSource = this.db.Types.Local.OrderBy(o => o.TypeName).ToList();

            //скрытие столбцов
            dataGridViewTypes.Columns["Id"].Visible = false;
            dataGridViewTypes.Columns["AnimeTitles"].Visible = false;

            //изменение названий заголовков столбцов
            dataGridViewTypes.Columns["TypeName"].HeaderText = "Тип аниме";
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.db.Dispose();
            this.db = null;
        }
        private void FormListTypes_Load(object sender, EventArgs e)
        {

        }
        private void btnUpdateType_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteType_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewTypes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            FormAddType formAddType = new FormAddType();
            formAddType.ShowDialog();
        }

        private void dataGridViewTypes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
