﻿namespace Project
{
    partial class Mainmanu
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
            this.หนาแรกToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.สมครสมาชกToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.จดการนำมนToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.การขายนำมนToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.จดการแทงคนำมนToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.หนาแรกToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // หนาแรกToolStripMenuItem
            // 
            this.หนาแรกToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.สมครสมาชกToolStripMenuItem,
            this.จดการนำมนToolStripMenuItem,
            this.การขายนำมนToolStripMenuItem,
            this.จดการแทงคนำมนToolStripMenuItem});
            this.หนาแรกToolStripMenuItem.Name = "หนาแรกToolStripMenuItem";
            this.หนาแรกToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.หนาแรกToolStripMenuItem.Text = "หน้าแรก";
            // 
            // สมครสมาชกToolStripMenuItem
            // 
            this.สมครสมาชกToolStripMenuItem.Name = "สมครสมาชกToolStripMenuItem";
            this.สมครสมาชกToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.สมครสมาชกToolStripMenuItem.Text = "สมัครสมาชิก";
            this.สมครสมาชกToolStripMenuItem.Click += new System.EventHandler(this.สมครสมาชกToolStripMenuItem_Click);
            // 
            // จดการนำมนToolStripMenuItem
            // 
            this.จดการนำมนToolStripMenuItem.Name = "จดการนำมนToolStripMenuItem";
            this.จดการนำมนToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.จดการนำมนToolStripMenuItem.Text = "จัดการน้ำมัน";
            this.จดการนำมนToolStripMenuItem.Click += new System.EventHandler(this.จดการนำมนToolStripMenuItem_Click);
            // 
            // การขายนำมนToolStripMenuItem
            // 
            this.การขายนำมนToolStripMenuItem.Name = "การขายนำมนToolStripMenuItem";
            this.การขายนำมนToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.การขายนำมนToolStripMenuItem.Text = "การขายน้ำมัน";
            this.การขายนำมนToolStripMenuItem.Click += new System.EventHandler(this.การขายนำมนToolStripMenuItem_Click);
            // 
            // จดการแทงคนำมนToolStripMenuItem
            // 
            this.จดการแทงคนำมนToolStripMenuItem.Name = "จดการแทงคนำมนToolStripMenuItem";
            this.จดการแทงคนำมนToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.จดการแทงคนำมนToolStripMenuItem.Text = "จัดการแทงค์น้ำมัน";
            this.จดการแทงคนำมนToolStripMenuItem.Click += new System.EventHandler(this.จดการแทงคนำมนToolStripMenuItem_Click);
            // 
            // Mainmanu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mainmanu";
            this.Text = "Mainmanu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem หนาแรกToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem สมครสมาชกToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem จดการนำมนToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem การขายนำมนToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem จดการแทงคนำมนToolStripMenuItem;
    }
}