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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.typesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.weaponsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.bulletsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.magazinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.typesToolStripMenuItem, this.exiToolStripMenuItem });
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(904, 28);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // typesToolStripMenuItem
      // 
      this.typesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.weaponsToolStripMenuItem, this.bulletsToolStripMenuItem, this.magazinesToolStripMenuItem });
      this.typesToolStripMenuItem.Name = "typesToolStripMenuItem";
      this.typesToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
      this.typesToolStripMenuItem.Text = "Types";
      // 
      // weaponsToolStripMenuItem
      // 
      this.weaponsToolStripMenuItem.Name = "weaponsToolStripMenuItem";
      this.weaponsToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
      this.weaponsToolStripMenuItem.Text = "Weapons";
      this.weaponsToolStripMenuItem.Click += new System.EventHandler(this.weaponsToolStripMenuItem_Click);
      // 
      // bulletsToolStripMenuItem
      // 
      this.bulletsToolStripMenuItem.Name = "bulletsToolStripMenuItem";
      this.bulletsToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
      this.bulletsToolStripMenuItem.Text = "Bullets";
      // 
      // magazinesToolStripMenuItem
      // 
      this.magazinesToolStripMenuItem.Name = "magazinesToolStripMenuItem";
      this.magazinesToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
      this.magazinesToolStripMenuItem.Text = "Magazines";
      // 
      // exiToolStripMenuItem
      // 
      this.exiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.exitToolStripMenuItem });
      this.exiToolStripMenuItem.Name = "exiToolStripMenuItem";
      this.exiToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
      this.exiToolStripMenuItem.Text = "Options";
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
      this.exitToolStripMenuItem.Text = "Exit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(904, 521);
      this.Controls.Add(this.menuStrip1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem typesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem weaponsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem bulletsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem magazinesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exiToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

    #endregion
  }
}

