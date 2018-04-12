namespace primeiraguerra.desk
{
    partial class sejabemvindo
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_jogar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(411, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seja Bem-Vindo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_jogar
            // 
            this.btn_jogar.AutoSize = true;
            this.btn_jogar.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_jogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_jogar.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_jogar.Location = new System.Drawing.Point(506, 484);
            this.btn_jogar.Name = "btn_jogar";
            this.btn_jogar.Size = new System.Drawing.Size(140, 48);
            this.btn_jogar.TabIndex = 1;
            this.btn_jogar.Text = "JOGAR ";
            this.btn_jogar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_jogar.UseVisualStyleBackColor = false;
            this.btn_jogar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 28F);
            this.label2.Location = new System.Drawing.Point(481, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 43);
            this.label2.TabIndex = 2;
            this.label2.Text = "novo jogador..";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // sejabemvindo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.BackgroundImage = global::primeiraguerra.desk.Properties.Resources.depositphotos_10091810_stock_photo_aged_vintage_world_map_texture;
            this.ClientSize = new System.Drawing.Size(1184, 801);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_jogar);
            this.Controls.Add(this.label1);
            this.Name = "sejabemvindo";
            this.Text = "sejabemvindo";
            this.Load += new System.EventHandler(this.sejabemvindo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_jogar;
        private System.Windows.Forms.Label label2;
    }
}