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
    public partial class FormAddType : Form
    {
        public FormAddType()
        {
            InitializeComponent();
        }



        private void btnSaveChanges_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTypeName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxTypeName.Text))
            {
                errorProvider.SetError(textBoxTypeName, "Поле не может быть пустым");
                btnSaveChanges.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                btnSaveChanges.Enabled = true;
            }
        }


        private void textBoxTypeName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxTypeName.Text))
            {
                errorProvider.SetError(textBoxTypeName, "Поле не может быть пустым");
                btnSaveChanges.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                btnSaveChanges.Enabled = true;
            }
        }
    }
}
