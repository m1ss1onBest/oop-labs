using System;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class FormWeaponSearch : Form
    {
        private Form1 motherForm;
        public FormWeaponSearch(Form1 mainForm)
        {
            motherForm = mainForm;
            InitializeComponent();
        }//TODO test comment

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            motherForm.RemoveFromDataGrid(textBox1.Text);
        }
    }
}