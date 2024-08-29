using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WinFormsApp.crutch;

namespace WinFormsApp
{
  public partial class Form1 : Form
  {
    private readonly List<Weapon> _weaponList = new List<Weapon>();
    private TextBox[] _textBoxes;
    public Form1()
    {
      InitializeComponent();
    }
    
    private void Form1_Load(object sender, EventArgs e)
    {
      // form elements
      Text = @"Weapons";

      // tool strip actions
      actionsButtonToolStripMenuItem.Text = @"Actions";
      newButtonToolStripMenuItem.Text = @"New";
      newWithArgsButtonToolStripMenuItem.Text = @"New with args";
      
      // tool strip options
      optionsButtonToolStripMenuItem.Text = @"Options";
      exitButtonToolStripMenuItem.Text = @"Exit";
      
      // data grid view options
      dataGridView1.Columns.Add("Name", "Name");
      dataGridView1.Columns.Add("Caliber", "Caliber");
      dataGridView1.Columns.Add("Magazine", "Magazine Capacity");
      dataGridView1.Columns.Add("Barrel", "Barrel Length");

      dataGridView1.Columns["Name"].Width = 150;
      dataGridView1.Columns["Caliber"].Width = 100;
      dataGridView1.Columns["Magazine"].Width = 100;
      dataGridView1.Columns["Barrel"].Width = 100;
      
      // labels option
      _textBoxes = new[] { textBoxName, textBoxCaliber, textBoxMag, textBoxBarrel };
      labelName.Text = @"Name";
      labelCaliber.Text = @"Caliber";
      labelMagazine.Text = @"Magazine Capacity";
      labelBarrel.Text = @"Barrel Length";
    }

    private void exitButtonToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }
    private void newButtonToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Weapon wp = new Weapon();
      _weaponList.Add(wp);
      AddToDataGrid(wp);
    }
    
    private void newWithArgsButtonToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (float.TryParse(textBoxBarrel.Text, out float barrelLength) &&
          int.TryParse(textBoxMag.Text, out var magazine) &&
          textBoxName.Text != string.Empty &&
          textBoxCaliber.Text != string.Empty)
      { 
        Weapon wp = new Weapon(textBoxName.Text, textBoxCaliber.Text, magazine, barrelLength); 
        _weaponList.Add(wp); 
        AddToDataGrid(wp);
      }
      else
      {
        MessageBox.Show(@"Please enter correct parameters!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      
      foreach(var a in _textBoxes)
        a.Text = string.Empty;
    }
    private void saveFileButtonToolStripMenuItem_Click(object sender, EventArgs e)
    {
      using (FileStream fs = new FileStream("data.dat", FileMode.Create))
      using (BinaryWriter writer = new BinaryWriter(fs))
      {
        foreach (var w in _weaponList)
        {
          writer.Write(w.Name);
          writer.Write(w.Caliber);
          writer.Write(w.MagazineCapacity);
          writer.Write(w.BarrelLength);
        }
      }
    }
    
    private void loadFileButtonToolStripMenuItem_Click(object sender, EventArgs e)
    {
      _weaponList.Clear();
      dataGridView1.Rows.Clear();

      if (File.Exists(@"data.dat"))
      {
        using (FileStream fs = new FileStream("data.dat", FileMode.Open))
        using (BinaryReader reader = new BinaryReader(fs))
        {
          while (reader.BaseStream.Position != reader.BaseStream.Length)
          {
            Weapon weapon = new Weapon(reader.ReadString(), reader.ReadString(), reader.ReadInt32(), reader.ReadSingle());
            _weaponList.Add(weapon);
            AddToDataGrid(weapon);
          }
        }
        
      }
    }
    
    private void removeWeaponToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var weaponToRemove = _weaponList.FirstOrDefault(wp => textBoxName.Text == wp.Name);
      textBoxName.Text = string.Empty;

      if (weaponToRemove != null)
      {
        int index = _weaponList.IndexOf(weaponToRemove);
        if (index >= 0)
        {
          _weaponList.RemoveAt(index);
          
          dataGridView1.Rows.Clear();
          if (index < dataGridView1.Rows.Count)
          {
            dataGridView1.Rows.RemoveAt(index);
          }
        }
      }
    }

    private void AddToDataGrid(Weapon w)
    {
      dataGridView1.Rows.Add(w.Name, w.Caliber, w.MagazineCapacity, w.BarrelLength);
    }
  }
}
