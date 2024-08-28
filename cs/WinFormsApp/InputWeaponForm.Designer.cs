using System.ComponentModel;

namespace WinFormsApp
{
    partial class InputWeaponForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.labelName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelCaliber = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelMag = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.labelBarrel = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(5, 10);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(253, 32);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "labelName";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(5, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 34);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(5, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(253, 34);
            this.textBox2.TabIndex = 3;
            // 
            // labelCaliber
            // 
            this.labelCaliber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCaliber.Location = new System.Drawing.Point(5, 82);
            this.labelCaliber.Name = "labelCaliber";
            this.labelCaliber.Size = new System.Drawing.Size(253, 32);
            this.labelCaliber.TabIndex = 2;
            this.labelCaliber.Text = "labelCaliber";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(5, 189);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(253, 34);
            this.textBox3.TabIndex = 5;
            // 
            // labelMag
            // 
            this.labelMag.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMag.Location = new System.Drawing.Point(5, 154);
            this.labelMag.Name = "labelMag";
            this.labelMag.Size = new System.Drawing.Size(253, 32);
            this.labelMag.TabIndex = 4;
            this.labelMag.Text = "labelMag";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(5, 261);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(253, 34);
            this.textBox4.TabIndex = 7;
            // 
            // labelBarrel
            // 
            this.labelBarrel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBarrel.Location = new System.Drawing.Point(5, 226);
            this.labelBarrel.Name = "labelBarrel";
            this.labelBarrel.Size = new System.Drawing.Size(253, 32);
            this.labelBarrel.TabIndex = 6;
            this.labelBarrel.Text = "labelBarrel";
            // 
            // buttonOk
            // 
            this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOk.Location = new System.Drawing.Point(158, 301);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(100, 35);
            this.buttonOk.TabIndex = 8;
            this.buttonOk.Text = "buttonOk";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // InputWeaponForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(264, 343);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.labelBarrel);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.labelMag);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelCaliber);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InputWeaponForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputWeaponForm";
            this.Load += new System.EventHandler(this.InputWeaponForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button buttonOk;

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelCaliber;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelMag;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label labelBarrel;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Label labelName;

        #endregion
    }
}