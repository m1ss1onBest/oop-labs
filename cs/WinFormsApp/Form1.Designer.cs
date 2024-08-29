namespace WinFormsApp
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.menuStrip2 = new System.Windows.Forms.MenuStrip();
      this.actionsButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.newButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.newWithArgsButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveFileButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.loadFileButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.removeWeaponToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.optionsButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.labelName = new System.Windows.Forms.Label();
      this.textBoxName = new System.Windows.Forms.TextBox();
      this.textBoxCaliber = new System.Windows.Forms.TextBox();
      this.labelCaliber = new System.Windows.Forms.Label();
      this.textBoxMag = new System.Windows.Forms.TextBox();
      this.labelMagazine = new System.Windows.Forms.Label();
      this.textBoxBarrel = new System.Windows.Forms.TextBox();
      this.labelBarrel = new System.Windows.Forms.Label();
      this.menuStrip2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip2
      // 
      this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.actionsButtonToolStripMenuItem, this.optionsButtonToolStripMenuItem });
      this.menuStrip2.Location = new System.Drawing.Point(0, 0);
      this.menuStrip2.Name = "menuStrip2";
      this.menuStrip2.Size = new System.Drawing.Size(922, 28);
      this.menuStrip2.TabIndex = 1;
      this.menuStrip2.Text = "menuStrip2";
      // 
      // actionsButtonToolStripMenuItem
      // 
      this.actionsButtonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.newButtonToolStripMenuItem, this.newWithArgsButtonToolStripMenuItem, this.saveFileButtonToolStripMenuItem, this.loadFileButtonToolStripMenuItem, this.removeWeaponToolStripMenuItem });
      this.actionsButtonToolStripMenuItem.Name = "actionsButtonToolStripMenuItem";
      this.actionsButtonToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
      this.actionsButtonToolStripMenuItem.Text = "actionsButton";
      // 
      // newButtonToolStripMenuItem
      // 
      this.newButtonToolStripMenuItem.Name = "newButtonToolStripMenuItem";
      this.newButtonToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
      this.newButtonToolStripMenuItem.Text = "newButton";
      this.newButtonToolStripMenuItem.Click += new System.EventHandler(this.newButtonToolStripMenuItem_Click);
      // 
      // newWithArgsButtonToolStripMenuItem
      // 
      this.newWithArgsButtonToolStripMenuItem.Name = "newWithArgsButtonToolStripMenuItem";
      this.newWithArgsButtonToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
      this.newWithArgsButtonToolStripMenuItem.Text = "newWithArgsButton";
      this.newWithArgsButtonToolStripMenuItem.Click += new System.EventHandler(this.newWithArgsButtonToolStripMenuItem_Click);
      // 
      // saveFileButtonToolStripMenuItem
      // 
      this.saveFileButtonToolStripMenuItem.Name = "saveFileButtonToolStripMenuItem";
      this.saveFileButtonToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
      this.saveFileButtonToolStripMenuItem.Text = "saveFileButton";
      this.saveFileButtonToolStripMenuItem.Click += new System.EventHandler(this.saveFileButtonToolStripMenuItem_Click);
      // 
      // loadFileButtonToolStripMenuItem
      // 
      this.loadFileButtonToolStripMenuItem.Name = "loadFileButtonToolStripMenuItem";
      this.loadFileButtonToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
      this.loadFileButtonToolStripMenuItem.Text = "loadFileButton";
      this.loadFileButtonToolStripMenuItem.Click += new System.EventHandler(this.loadFileButtonToolStripMenuItem_Click);
      // 
      // removeWeaponToolStripMenuItem
      // 
      this.removeWeaponToolStripMenuItem.Name = "removeWeaponToolStripMenuItem";
      this.removeWeaponToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
      this.removeWeaponToolStripMenuItem.Text = "removeWeapon";
      this.removeWeaponToolStripMenuItem.Click += new System.EventHandler(this.removeWeaponToolStripMenuItem_Click);
      // 
      // optionsButtonToolStripMenuItem
      // 
      this.optionsButtonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.exitButtonToolStripMenuItem });
      this.optionsButtonToolStripMenuItem.Name = "optionsButtonToolStripMenuItem";
      this.optionsButtonToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
      this.optionsButtonToolStripMenuItem.Text = "optionsButton";
      // 
      // exitButtonToolStripMenuItem
      // 
      this.exitButtonToolStripMenuItem.Name = "exitButtonToolStripMenuItem";
      this.exitButtonToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
      this.exitButtonToolStripMenuItem.Text = "exitButton";
      this.exitButtonToolStripMenuItem.Click += new System.EventHandler(this.exitButtonToolStripMenuItem_Click);
      // 
      // dataGridView1
      // 
      this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(269, 31);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowTemplate.Height = 24;
      this.dataGridView1.Size = new System.Drawing.Size(649, 440);
      this.dataGridView1.TabIndex = 2;
      // 
      // labelName
      // 
      this.labelName.Location = new System.Drawing.Point(12, 28);
      this.labelName.Name = "labelName";
      this.labelName.Size = new System.Drawing.Size(239, 21);
      this.labelName.TabIndex = 3;
      this.labelName.Text = "labelName";
      // 
      // textBoxName
      // 
      this.textBoxName.Location = new System.Drawing.Point(12, 52);
      this.textBoxName.Name = "textBoxName";
      this.textBoxName.Size = new System.Drawing.Size(239, 22);
      this.textBoxName.TabIndex = 4;
      // 
      // textBoxCaliber
      // 
      this.textBoxCaliber.Location = new System.Drawing.Point(12, 101);
      this.textBoxCaliber.Name = "textBoxCaliber";
      this.textBoxCaliber.Size = new System.Drawing.Size(239, 22);
      this.textBoxCaliber.TabIndex = 6;
      // 
      // labelCaliber
      // 
      this.labelCaliber.Location = new System.Drawing.Point(12, 77);
      this.labelCaliber.Name = "labelCaliber";
      this.labelCaliber.Size = new System.Drawing.Size(239, 21);
      this.labelCaliber.TabIndex = 5;
      this.labelCaliber.Text = "labelCaliber";
      // 
      // textBoxMag
      // 
      this.textBoxMag.Location = new System.Drawing.Point(12, 150);
      this.textBoxMag.Name = "textBoxMag";
      this.textBoxMag.Size = new System.Drawing.Size(239, 22);
      this.textBoxMag.TabIndex = 8;
      // 
      // labelMagazine
      // 
      this.labelMagazine.Location = new System.Drawing.Point(12, 126);
      this.labelMagazine.Name = "labelMagazine";
      this.labelMagazine.Size = new System.Drawing.Size(239, 21);
      this.labelMagazine.TabIndex = 7;
      this.labelMagazine.Text = "labelMagazine";
      // 
      // textBoxBarrel
      // 
      this.textBoxBarrel.Location = new System.Drawing.Point(12, 199);
      this.textBoxBarrel.Name = "textBoxBarrel";
      this.textBoxBarrel.Size = new System.Drawing.Size(239, 22);
      this.textBoxBarrel.TabIndex = 10;
      // 
      // labelBarrel
      // 
      this.labelBarrel.Location = new System.Drawing.Point(12, 175);
      this.labelBarrel.Name = "labelBarrel";
      this.labelBarrel.Size = new System.Drawing.Size(239, 21);
      this.labelBarrel.TabIndex = 9;
      this.labelBarrel.Text = "labelBarrel";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(922, 483);
      this.Controls.Add(this.textBoxBarrel);
      this.Controls.Add(this.labelBarrel);
      this.Controls.Add(this.textBoxMag);
      this.Controls.Add(this.labelMagazine);
      this.Controls.Add(this.textBoxCaliber);
      this.Controls.Add(this.labelCaliber);
      this.Controls.Add(this.textBoxName);
      this.Controls.Add(this.labelName);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.menuStrip2);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.menuStrip2.ResumeLayout(false);
      this.menuStrip2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private System.Windows.Forms.TextBox textBoxCaliber;
    private System.Windows.Forms.Label labelCaliber;
    private System.Windows.Forms.TextBox textBoxMag;
    private System.Windows.Forms.Label labelMagazine;
    private System.Windows.Forms.TextBox textBoxBarrel;
    private System.Windows.Forms.Label labelBarrel;

    private System.Windows.Forms.TextBox textBoxName;

    private System.Windows.Forms.Label labelName;

    private System.Windows.Forms.ToolStripMenuItem removeWeaponToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem saveFileButtonToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem loadFileButtonToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem actionsButtonToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem newButtonToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem newWithArgsButtonToolStripMenuItem;

    private System.Windows.Forms.DataGridView dataGridView1;

    public System.Windows.Forms.MenuStrip menuStrip2;
    private System.Windows.Forms.ToolStripMenuItem optionsButtonToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitButtonToolStripMenuItem;

    #endregion
  }
}

