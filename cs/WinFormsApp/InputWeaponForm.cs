using System;
using System.Windows.Forms;
using WinFormsApp.crutch;

namespace WinFormsApp
{
    public partial class InputWeaponForm : Form
    {
        private readonly Form1 _motherForm;
        
        public InputWeaponForm(Form1 motherForm)
        {
            _motherForm = motherForm;
            InitializeComponent();
        }

        private void InputWeaponForm_Load(object sender, EventArgs e)
        {
            Text = @"New Weapon";
            labelName.Text = @"Name";
            labelCaliber.Text = @"Caliber";
            labelMag.Text = @"Mag";
            labelBarrel.Text = @"Barrel Len";
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox3.Text, out var mag)) return;
            if (!float.TryParse(textBox4.Text, out var barrel)) return;
            
            Weapon wp = new Weapon(textBox1.Text, textBox2.Text, mag, barrel);
            _motherForm.WeaponList.Add(wp);
            _motherForm.AddToDataGrid(wp);
            Close();
        }
    }
}