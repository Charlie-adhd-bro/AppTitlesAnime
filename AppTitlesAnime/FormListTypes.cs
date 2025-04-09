using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTitlesAnime
{
    public partial class FormListTypes : Form
    {
        public FormListTypes()
        {
            InitializeComponent();
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

        private void btnUpdateType_Click_1(object sender, EventArgs e)
        {

        }

        private void btnUpdateType_Click_2(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnAddType_Click(object sender, EventArgs e)
        {
            FormAddType formAddType = new FormAddType();
            formAddType.ShowDialog();
        }
    }
}
