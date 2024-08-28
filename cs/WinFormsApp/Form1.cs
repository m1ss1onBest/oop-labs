using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using WinFormsApp.crutch;

namespace WinFormsApp
{
  public partial class Form1 : Form
  {
    public List<Weapon> WeaponList = new List<Weapon>();
    public Form1()
    {
      InitializeComponent();
    }
    
    //region form
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

      dataGridView1.Columns["Name"].Width = 175;
    }

    private void exitButtonToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }
    private void newWithArgsButtonToolStripMenuItem_Click(object sender, EventArgs e)
    {
      
    }
    private void saveFileButtonToolStripMenuItem_Click(object sender, EventArgs e)
    {
      using (FileStream fs = new FileStream("data.dat", FileMode.Create))
      using (BinaryWriter writer = new BinaryWriter(fs))
      {
        foreach (var w in WeaponList)
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
      WeaponList.Clear();

      if (File.Exists(@"data.dat"))
      {
        using (FileStream fs = new FileStream("data.dat", FileMode.Open))
        using (BinaryReader reader = new BinaryReader(fs))
        {
          while (reader.BaseStream.Position != reader.BaseStream.Length)
          {
            Weapon weapon = new Weapon(reader.ReadString(), reader.ReadString(), reader.ReadInt32(), reader.ReadSingle());
          }
        }

      }
    }
    //endregion form
    
    //region logic
    private void AddToDataGrid(Weapon w)
    {
      dataGridView1.Rows.Add(w.Name, w.Caliber, w.MagazineCapacity, w.BarrelLength);
    }
    //endregion logic

  }
}
