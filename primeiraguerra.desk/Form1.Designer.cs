﻿namespace primeiraguerra.desk
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fase1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fase2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fase3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fase1ToolStripMenuItem,
            this.fase2ToolStripMenuItem,
            this.fase3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 43);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fase1ToolStripMenuItem
            // 
            this.fase1ToolStripMenuItem.Name = "fase1ToolStripMenuItem";
            this.fase1ToolStripMenuItem.Size = new System.Drawing.Size(96, 39);
            this.fase1ToolStripMenuItem.Text = "Fase 1";
            this.fase1ToolStripMenuItem.Click += new System.EventHandler(this.fase1ToolStripMenuItem_Click);
            // 
            // fase2ToolStripMenuItem
            // 
            this.fase2ToolStripMenuItem.Name = "fase2ToolStripMenuItem";
            this.fase2ToolStripMenuItem.Size = new System.Drawing.Size(96, 39);
            this.fase2ToolStripMenuItem.Text = "Fase 2";
            this.fase2ToolStripMenuItem.Click += new System.EventHandler(this.fase2ToolStripMenuItem_Click);
            // 
            // fase3ToolStripMenuItem
            // 
            this.fase3ToolStripMenuItem.Name = "fase3ToolStripMenuItem";
            this.fase3ToolStripMenuItem.Size = new System.Drawing.Size(96, 39);
            this.fase3ToolStripMenuItem.Text = "Fase 3";
            this.fase3ToolStripMenuItem.Click += new System.EventHandler(this.fase3ToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.BackgroundImage = global::primeiraguerra.desk.Properties.Resources.qui;
            this.ClientSize = new System.Drawing.Size(1184, 801);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fase1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fase2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fase3ToolStripMenuItem;
    }
}

