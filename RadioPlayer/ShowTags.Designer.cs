using System.ComponentModel;
using System.Windows.Forms;

namespace RadioPlayer
{
    partial class ShowTags
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
			this.Atlikejas = new System.Windows.Forms.TextBox();
			this.DainosPavadinimas = new System.Windows.Forms.TextBox();
			this.AlbumoPavadinimas = new System.Windows.Forms.TextBox();
			this.IsleidimoMetai = new System.Windows.Forms.TextBox();
			this.Zanras = new System.Windows.Forms.TextBox();
			this.DainosNumeris = new System.Windows.Forms.TextBox();
			this.DainuKiekis = new System.Windows.Forms.TextBox();
			this.Komentaras = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Atlikejas
			// 
			this.Atlikejas.Location = new System.Drawing.Point(170, 26);
			this.Atlikejas.Name = "Atlikejas";
			this.Atlikejas.Size = new System.Drawing.Size(284, 20);
			this.Atlikejas.TabIndex = 0;
			// 
			// DainosPavadinimas
			// 
			this.DainosPavadinimas.Location = new System.Drawing.Point(170, 52);
			this.DainosPavadinimas.Name = "DainosPavadinimas";
			this.DainosPavadinimas.Size = new System.Drawing.Size(284, 20);
			this.DainosPavadinimas.TabIndex = 1;
			this.DainosPavadinimas.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// AlbumoPavadinimas
			// 
			this.AlbumoPavadinimas.Location = new System.Drawing.Point(170, 78);
			this.AlbumoPavadinimas.Name = "AlbumoPavadinimas";
			this.AlbumoPavadinimas.Size = new System.Drawing.Size(284, 20);
			this.AlbumoPavadinimas.TabIndex = 2;
			// 
			// IsleidimoMetai
			// 
			this.IsleidimoMetai.Location = new System.Drawing.Point(170, 104);
			this.IsleidimoMetai.Name = "IsleidimoMetai";
			this.IsleidimoMetai.Size = new System.Drawing.Size(284, 20);
			this.IsleidimoMetai.TabIndex = 3;
			// 
			// Zanras
			// 
			this.Zanras.Location = new System.Drawing.Point(170, 128);
			this.Zanras.Name = "Zanras";
			this.Zanras.Size = new System.Drawing.Size(284, 20);
			this.Zanras.TabIndex = 4;
			// 
			// DainosNumeris
			// 
			this.DainosNumeris.Location = new System.Drawing.Point(170, 154);
			this.DainosNumeris.Name = "DainosNumeris";
			this.DainosNumeris.Size = new System.Drawing.Size(284, 20);
			this.DainosNumeris.TabIndex = 6;
			// 
			// DainuKiekis
			// 
			this.DainuKiekis.Location = new System.Drawing.Point(170, 180);
			this.DainuKiekis.Name = "DainuKiekis";
			this.DainuKiekis.Size = new System.Drawing.Size(284, 20);
			this.DainuKiekis.TabIndex = 7;
			// 
			// Komentaras
			// 
			this.Komentaras.Location = new System.Drawing.Point(170, 206);
			this.Komentaras.Name = "Komentaras";
			this.Komentaras.Size = new System.Drawing.Size(284, 20);
			this.Komentaras.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Artist";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(27, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "Title";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 81);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "Album";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 104);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "Year";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(13, 128);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(36, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "Genre";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(13, 154);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(73, 13);
			this.label7.TabIndex = 15;
			this.label7.Text = "Track number";
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(13, 180);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(63, 13);
			this.label8.TabIndex = 16;
			this.label8.Text = "Total tracks";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(13, 206);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(51, 13);
			this.label9.TabIndex = 17;
			this.label9.Text = "Comment";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(16, 235);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 18;
			this.button1.Text = "Save";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(170, 237);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(135, 23);
			this.button2.TabIndex = 19;
			this.button2.Text = "Close";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// ShowTags
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(458, 266);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Komentaras);
			this.Controls.Add(this.DainuKiekis);
			this.Controls.Add(this.DainosNumeris);
			this.Controls.Add(this.Zanras);
			this.Controls.Add(this.IsleidimoMetai);
			this.Controls.Add(this.AlbumoPavadinimas);
			this.Controls.Add(this.DainosPavadinimas);
			this.Controls.Add(this.Atlikejas);
			this.Name = "ShowTags";
			this.Text = "ShowTags";
			this.Load += new System.EventHandler(this.ShowTags_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        public TextBox Atlikejas;
        public TextBox DainosPavadinimas;
        public TextBox AlbumoPavadinimas;
        public TextBox IsleidimoMetai;
        public TextBox Zanras;
        public TextBox DainosNumeris;
        public TextBox DainuKiekis;
        public TextBox Komentaras;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button button1;
        private Button button2;
    }
}