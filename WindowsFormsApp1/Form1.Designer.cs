﻿namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.QuitBtn = new System.Windows.Forms.Button();
            this.OptionBtn = new System.Windows.Forms.Button();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // QuitBtn
            // 
            this.QuitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.QuitBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.QuitBtn.Location = new System.Drawing.Point(715, 597);
            this.QuitBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(205, 70);
            this.QuitBtn.TabIndex = 3;
            this.QuitBtn.Text = "QUIT";
            this.QuitBtn.UseVisualStyleBackColor = false;
            this.QuitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // OptionBtn
            // 
            this.OptionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.OptionBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.OptionBtn.Location = new System.Drawing.Point(715, 448);
            this.OptionBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.OptionBtn.Name = "OptionBtn";
            this.OptionBtn.Size = new System.Drawing.Size(205, 70);
            this.OptionBtn.TabIndex = 4;
            this.OptionBtn.Text = "OPTION";
            this.OptionBtn.UseVisualStyleBackColor = false;
            this.OptionBtn.Click += new System.EventHandler(this.OptionBtn_Click_1);
            // 
            // PlayBtn
            // 
            this.PlayBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.PlayBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.PlayBtn.Location = new System.Drawing.Point(715, 289);
            this.PlayBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(205, 70);
            this.PlayBtn.TabIndex = 5;
            this.PlayBtn.Text = "PLAY";
            this.PlayBtn.UseVisualStyleBackColor = false;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(58, 43);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(567, 801);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1359, 901);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PlayBtn);
            this.Controls.Add(this.OptionBtn);
            this.Controls.Add(this.QuitBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button QuitBtn;
        private System.Windows.Forms.Button OptionBtn;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

