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
      this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.buttonEmptyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.buttonParamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.buttonOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.buttonExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.dataToolStripMenuItem, this.buttonOptionsToolStripMenuItem });
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(922, 28);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // dataToolStripMenuItem
      // 
      this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.buttonEmptyToolStripMenuItem, this.buttonParamsToolStripMenuItem });
      this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
      this.dataToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
      this.dataToolStripMenuItem.Text = "buttonData";
      // 
      // buttonEmptyToolStripMenuItem
      // 
      this.buttonEmptyToolStripMenuItem.Name = "buttonEmptyToolStripMenuItem";
      this.buttonEmptyToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
      this.buttonEmptyToolStripMenuItem.Text = "buttonEmpty";
      // 
      // buttonParamsToolStripMenuItem
      // 
      this.buttonParamsToolStripMenuItem.Name = "buttonParamsToolStripMenuItem";
      this.buttonParamsToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
      this.buttonParamsToolStripMenuItem.Text = "buttonParams";
      // 
      // buttonOptionsToolStripMenuItem
      // 
      this.buttonOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.buttonExitToolStripMenuItem });
      this.buttonOptionsToolStripMenuItem.Name = "buttonOptionsToolStripMenuItem";
      this.buttonOptionsToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
      this.buttonOptionsToolStripMenuItem.Text = "buttonOptions";
      // 
      // buttonExitToolStripMenuItem
      // 
      this.buttonExitToolStripMenuItem.Name = "buttonExitToolStripMenuItem";
      this.buttonExitToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
      this.buttonExitToolStripMenuItem.Text = "buttonExit";
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(0, 31);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowTemplate.Height = 24;
      this.dataGridView1.Size = new System.Drawing.Size(929, 440);
      this.dataGridView1.TabIndex = 1;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(922, 483);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.menuStrip1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem buttonEmptyToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem buttonParamsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem buttonOptionsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem buttonExitToolStripMenuItem;
    private System.Windows.Forms.DataGridView dataGridView1;

    #endregion
  }
}

