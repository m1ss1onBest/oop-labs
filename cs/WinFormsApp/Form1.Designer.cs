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
      this.optionsButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip2
      // 
      this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.actionsButtonToolStripMenuItem, this.optionsButtonToolStripMenuItem, this.aToolStripMenuItem });
      this.menuStrip2.Location = new System.Drawing.Point(0, 0);
      this.menuStrip2.Name = "menuStrip2";
      this.menuStrip2.Size = new System.Drawing.Size(904, 28);
      this.menuStrip2.TabIndex = 1;
      this.menuStrip2.Text = "menuStrip2";
      // 
      // actionsButtonToolStripMenuItem
      // 
      this.actionsButtonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.newButtonToolStripMenuItem, this.newWithArgsButtonToolStripMenuItem, this.saveFileButtonToolStripMenuItem, this.loadFileButtonToolStripMenuItem });
      this.actionsButtonToolStripMenuItem.Name = "actionsButtonToolStripMenuItem";
      this.actionsButtonToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
      this.actionsButtonToolStripMenuItem.Text = "actionsButton";
      // 
      // newButtonToolStripMenuItem
      // 
      this.newButtonToolStripMenuItem.Name = "newButtonToolStripMenuItem";
      this.newButtonToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
      this.newButtonToolStripMenuItem.Text = "newButton";
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
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView1.Location = new System.Drawing.Point(0, 28);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowTemplate.Height = 24;
      this.dataGridView1.Size = new System.Drawing.Size(904, 455);
      this.dataGridView1.TabIndex = 2;
      // 
      // aToolStripMenuItem
      // 
      this.aToolStripMenuItem.Name = "aToolStripMenuItem";
      this.aToolStripMenuItem.Size = new System.Drawing.Size(31, 24);
      this.aToolStripMenuItem.Text = "A";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(904, 483);
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

    private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;

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

