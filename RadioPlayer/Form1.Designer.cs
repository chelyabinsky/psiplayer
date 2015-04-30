using System.ComponentModel;
using System.Windows.Forms;

namespace RadioPlayer
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			this.volumeBar = new System.Windows.Forms.HScrollBar();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.playerTimer = new System.Windows.Forms.Timer(this.components);
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.saveButton = new System.Windows.Forms.Button();
			this.loadButton = new System.Windows.Forms.Button();
			this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
			this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
			this.vScrollBar10 = new System.Windows.Forms.VScrollBar();
			this.vScrollBar3 = new System.Windows.Forms.VScrollBar();
			this.vScrollBar4 = new System.Windows.Forms.VScrollBar();
			this.vScrollBar5 = new System.Windows.Forms.VScrollBar();
			this.vScrollBar6 = new System.Windows.Forms.VScrollBar();
			this.vScrollBar7 = new System.Windows.Forms.VScrollBar();
			this.vScrollBar8 = new System.Windows.Forms.VScrollBar();
			this.vScrollBar9 = new System.Windows.Forms.VScrollBar();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.GetAlbumInfo = new System.Windows.Forms.ToolStripMenuItem();
			this.GetArtistInfo = new System.Windows.Forms.ToolStripMenuItem();
			this.removeTrackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showTagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddFiles = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.radioButton = new System.Windows.Forms.Button();
			this.backwardButton = new System.Windows.Forms.Button();
			this.forwardButton = new System.Windows.Forms.Button();
			this.stopButton = new System.Windows.Forms.Button();
			this.pauseButton = new System.Windows.Forms.Button();
			this.playButton = new System.Windows.Forms.Button();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// volumeBar
			// 
			this.volumeBar.Location = new System.Drawing.Point(26, 109);
			this.volumeBar.Name = "volumeBar";
			this.volumeBar.Size = new System.Drawing.Size(202, 21);
			this.volumeBar.TabIndex = 0;
			this.volumeBar.Value = 50;
			this.volumeBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.volumeBar_Scroll);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(231, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "position";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(231, 117);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "volume";
			// 
			// playerTimer
			// 
			this.playerTimer.Tick += new System.EventHandler(this.playerTimer_Tick);
			// 
			// listBox1
			// 
			this.listBox1.AllowDrop = true;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(279, 9);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(297, 121);
			this.listBox1.TabIndex = 8;
			this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
			this.listBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseUp_1);
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(279, 136);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 23);
			this.saveButton.TabIndex = 9;
			this.saveButton.Text = "Save List";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// loadButton
			// 
			this.loadButton.Location = new System.Drawing.Point(501, 136);
			this.loadButton.Name = "loadButton";
			this.loadButton.Size = new System.Drawing.Size(75, 23);
			this.loadButton.TabIndex = 10;
			this.loadButton.Text = "Load List";
			this.loadButton.UseVisualStyleBackColor = true;
			this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
			// 
			// vScrollBar1
			// 
			this.vScrollBar1.Location = new System.Drawing.Point(102, 181);
			this.vScrollBar1.Maximum = 8000;
			this.vScrollBar1.Minimum = -8000;
			this.vScrollBar1.Name = "vScrollBar1";
			this.vScrollBar1.Size = new System.Drawing.Size(18, 140);
			this.vScrollBar1.TabIndex = 12;
			this.vScrollBar1.Value = 15;
			this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
			this.vScrollBar1.ValueChanged += new System.EventHandler(this.vScrollBar1_ValueChanged);
			// 
			// vScrollBar2
			// 
			this.vScrollBar2.Location = new System.Drawing.Point(142, 181);
			this.vScrollBar2.Maximum = 8000;
			this.vScrollBar2.Minimum = -8000;
			this.vScrollBar2.Name = "vScrollBar2";
			this.vScrollBar2.Size = new System.Drawing.Size(18, 140);
			this.vScrollBar2.TabIndex = 13;
			this.vScrollBar2.Value = 115;
			this.vScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar2_Scroll);
			this.vScrollBar2.ValueChanged += new System.EventHandler(this.vScrollBar2_ValueChanged);
			// 
			// vScrollBar10
			// 
			this.vScrollBar10.LargeChange = 1;
			this.vScrollBar10.Location = new System.Drawing.Point(462, 181);
			this.vScrollBar10.Maximum = 8000;
			this.vScrollBar10.Minimum = -8000;
			this.vScrollBar10.Name = "vScrollBar10";
			this.vScrollBar10.Size = new System.Drawing.Size(17, 140);
			this.vScrollBar10.TabIndex = 14;
			this.vScrollBar10.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar3_Scroll);
			this.vScrollBar10.ValueChanged += new System.EventHandler(this.vScrollBar10_ValueChanged);
			// 
			// vScrollBar3
			// 
			this.vScrollBar3.Location = new System.Drawing.Point(182, 181);
			this.vScrollBar3.Maximum = 8000;
			this.vScrollBar3.Minimum = -8000;
			this.vScrollBar3.Name = "vScrollBar3";
			this.vScrollBar3.Size = new System.Drawing.Size(18, 140);
			this.vScrollBar3.TabIndex = 16;
			this.vScrollBar3.Value = 240;
			this.vScrollBar3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar4_Scroll);
			this.vScrollBar3.ValueChanged += new System.EventHandler(this.vScrollBar3_ValueChanged);
			// 
			// vScrollBar4
			// 
			this.vScrollBar4.Location = new System.Drawing.Point(222, 181);
			this.vScrollBar4.Maximum = 8000;
			this.vScrollBar4.Minimum = -8000;
			this.vScrollBar4.Name = "vScrollBar4";
			this.vScrollBar4.Size = new System.Drawing.Size(17, 140);
			this.vScrollBar4.TabIndex = 17;
			this.vScrollBar4.Value = 455;
			this.vScrollBar4.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar5_Scroll);
			this.vScrollBar4.ValueChanged += new System.EventHandler(this.vScrollBar4_ValueChanged);
			// 
			// vScrollBar5
			// 
			this.vScrollBar5.Location = new System.Drawing.Point(262, 181);
			this.vScrollBar5.Maximum = 8000;
			this.vScrollBar5.Minimum = -8000;
			this.vScrollBar5.Name = "vScrollBar5";
			this.vScrollBar5.Size = new System.Drawing.Size(18, 140);
			this.vScrollBar5.TabIndex = 22;
			this.vScrollBar5.Value = 800;
			this.vScrollBar5.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar6_Scroll);
			this.vScrollBar5.ValueChanged += new System.EventHandler(this.vScrollBar5_ValueChanged);
			// 
			// vScrollBar6
			// 
			this.vScrollBar6.Location = new System.Drawing.Point(302, 181);
			this.vScrollBar6.Maximum = 8000;
			this.vScrollBar6.Minimum = -8000;
			this.vScrollBar6.Name = "vScrollBar6";
			this.vScrollBar6.Size = new System.Drawing.Size(17, 140);
			this.vScrollBar6.TabIndex = 21;
			this.vScrollBar6.Value = 2000;
			this.vScrollBar6.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar7_Scroll);
			this.vScrollBar6.ValueChanged += new System.EventHandler(this.vScrollBar6_ValueChanged);
			// 
			// vScrollBar7
			// 
			this.vScrollBar7.Location = new System.Drawing.Point(342, 181);
			this.vScrollBar7.Maximum = 8000;
			this.vScrollBar7.Minimum = -8000;
			this.vScrollBar7.Name = "vScrollBar7";
			this.vScrollBar7.Size = new System.Drawing.Size(17, 140);
			this.vScrollBar7.TabIndex = 20;
			this.vScrollBar7.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar8_Scroll);
			this.vScrollBar7.ValueChanged += new System.EventHandler(this.vScrollBar7_ValueChanged);
			// 
			// vScrollBar8
			// 
			this.vScrollBar8.Location = new System.Drawing.Point(382, 181);
			this.vScrollBar8.Maximum = 8000;
			this.vScrollBar8.Minimum = -8000;
			this.vScrollBar8.Name = "vScrollBar8";
			this.vScrollBar8.Size = new System.Drawing.Size(17, 140);
			this.vScrollBar8.TabIndex = 19;
			this.vScrollBar8.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar9_Scroll);
			this.vScrollBar8.ValueChanged += new System.EventHandler(this.vScrollBar8_ValueChanged);
			// 
			// vScrollBar9
			// 
			this.vScrollBar9.Location = new System.Drawing.Point(422, 181);
			this.vScrollBar9.Maximum = 8000;
			this.vScrollBar9.Minimum = -8000;
			this.vScrollBar9.Name = "vScrollBar9";
			this.vScrollBar9.Size = new System.Drawing.Size(17, 140);
			this.vScrollBar9.TabIndex = 18;
			this.vScrollBar9.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar10_Scroll);
			this.vScrollBar9.ValueChanged += new System.EventHandler(this.vScrollBar9_ValueChanged);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GetAlbumInfo,
            this.GetArtistInfo,
            this.removeTrackToolStripMenuItem,
            this.showTagsToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(156, 114);
			this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
			// 
			// GetAlbumInfo
			// 
			this.GetAlbumInfo.Name = "GetAlbumInfo";
			this.GetAlbumInfo.Size = new System.Drawing.Size(155, 22);
			this.GetAlbumInfo.Text = "Get Album Info";
			this.GetAlbumInfo.Click += new System.EventHandler(this.GetAlbumInfo_Click);
			// 
			// GetArtistInfo
			// 
			this.GetArtistInfo.Name = "GetArtistInfo";
			this.GetArtistInfo.Size = new System.Drawing.Size(155, 22);
			this.GetArtistInfo.Text = "Get Artist Info";
			this.GetArtistInfo.Click += new System.EventHandler(this.GetArtistInfo_Click);
			// 
			// removeTrackToolStripMenuItem
			// 
			this.removeTrackToolStripMenuItem.Name = "removeTrackToolStripMenuItem";
			this.removeTrackToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.removeTrackToolStripMenuItem.Text = "Remove Track";
			this.removeTrackToolStripMenuItem.Click += new System.EventHandler(this.removeTrackToolStripMenuItem_Click);
			// 
			// showTagsToolStripMenuItem
			// 
			this.showTagsToolStripMenuItem.Name = "showTagsToolStripMenuItem";
			this.showTagsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.showTagsToolStripMenuItem.Text = "Show Tags";
			this.showTagsToolStripMenuItem.Click += new System.EventHandler(this.showTagsToolStripMenuItem_Click);
			// 
			// AddFiles
			// 
			this.AddFiles.Location = new System.Drawing.Point(390, 136);
			this.AddFiles.Name = "AddFiles";
			this.AddFiles.Size = new System.Drawing.Size(75, 23);
			this.AddFiles.TabIndex = 23;
			this.AddFiles.Text = "Add Files";
			this.AddFiles.UseVisualStyleBackColor = true;
			this.AddFiles.Click += new System.EventHandler(this.AddFiles_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(9, 181);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 24;
			this.button1.Text = "EQ On/Off";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(99, 330);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(19, 13);
			this.label1.TabIndex = 25;
			this.label1.Text = "80";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(139, 330);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(25, 13);
			this.label4.TabIndex = 26;
			this.label4.Text = "200";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(179, 330);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(25, 13);
			this.label5.TabIndex = 27;
			this.label5.Text = "400";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(219, 330);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(25, 13);
			this.label6.TabIndex = 28;
			this.label6.Text = "700";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(255, 330);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(31, 13);
			this.label7.TabIndex = 29;
			this.label7.Text = "1500";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(299, 330);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(31, 13);
			this.label8.TabIndex = 30;
			this.label8.Text = "3000";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(339, 330);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(31, 13);
			this.label9.TabIndex = 31;
			this.label9.Text = "6000";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(379, 330);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(31, 13);
			this.label10.TabIndex = 32;
			this.label10.Text = "9000";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(419, 330);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(37, 13);
			this.label11.TabIndex = 33;
			this.label11.Text = "12000";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(459, 330);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(37, 13);
			this.label12.TabIndex = 34;
			this.label12.Text = "15000";
			// 
			// radioButton
			// 
			this.radioButton.Location = new System.Drawing.Point(501, 181);
			this.radioButton.Name = "radioButton";
			this.radioButton.Size = new System.Drawing.Size(75, 23);
			this.radioButton.TabIndex = 35;
			this.radioButton.Text = "Radio player";
			this.radioButton.UseVisualStyleBackColor = true;
			this.radioButton.Click += new System.EventHandler(this.radioButton_Click);
			// 
			// backwardButton
			// 
			this.backwardButton.BackgroundImage = global::RadioPlayer.Properties.Resources.backward;
			this.backwardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.backwardButton.Location = new System.Drawing.Point(28, 69);
			this.backwardButton.Name = "backwardButton";
			this.backwardButton.Size = new System.Drawing.Size(30, 36);
			this.backwardButton.TabIndex = 15;
			this.backwardButton.UseVisualStyleBackColor = true;
			this.backwardButton.Click += new System.EventHandler(this.backwardButton_Click);
			// 
			// forwardButton
			// 
			this.forwardButton.BackgroundImage = global::RadioPlayer.Properties.Resources.forward;
			this.forwardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.forwardButton.Location = new System.Drawing.Point(176, 69);
			this.forwardButton.Name = "forwardButton";
			this.forwardButton.Size = new System.Drawing.Size(30, 36);
			this.forwardButton.TabIndex = 11;
			this.forwardButton.UseVisualStyleBackColor = true;
			this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
			// 
			// stopButton
			// 
			this.stopButton.BackgroundImage = global::RadioPlayer.Properties.Resources.stop;
			this.stopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.stopButton.Location = new System.Drawing.Point(140, 69);
			this.stopButton.Name = "stopButton";
			this.stopButton.Size = new System.Drawing.Size(30, 36);
			this.stopButton.TabIndex = 7;
			this.stopButton.UseVisualStyleBackColor = true;
			this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
			// 
			// pauseButton
			// 
			this.pauseButton.BackgroundImage = global::RadioPlayer.Properties.Resources.pause;
			this.pauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pauseButton.Location = new System.Drawing.Point(102, 69);
			this.pauseButton.Name = "pauseButton";
			this.pauseButton.Size = new System.Drawing.Size(32, 36);
			this.pauseButton.TabIndex = 6;
			this.pauseButton.UseVisualStyleBackColor = true;
			this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
			// 
			// playButton
			// 
			this.playButton.BackgroundImage = global::RadioPlayer.Properties.Resources.play;
			this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.playButton.Location = new System.Drawing.Point(64, 69);
			this.playButton.Name = "playButton";
			this.playButton.Size = new System.Drawing.Size(32, 36);
			this.playButton.TabIndex = 5;
			this.playButton.UseVisualStyleBackColor = true;
			this.playButton.Click += new System.EventHandler(this.playButton_Click);
			// 
			// Form1
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ClientSize = new System.Drawing.Size(587, 366);
			this.Controls.Add(this.radioButton);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.AddFiles);
			this.Controls.Add(this.vScrollBar5);
			this.Controls.Add(this.vScrollBar6);
			this.Controls.Add(this.vScrollBar7);
			this.Controls.Add(this.vScrollBar8);
			this.Controls.Add(this.vScrollBar9);
			this.Controls.Add(this.vScrollBar4);
			this.Controls.Add(this.vScrollBar3);
			this.Controls.Add(this.backwardButton);
			this.Controls.Add(this.vScrollBar10);
			this.Controls.Add(this.vScrollBar2);
			this.Controls.Add(this.vScrollBar1);
			this.Controls.Add(this.forwardButton);
			this.Controls.Add(this.loadButton);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.stopButton);
			this.Controls.Add(this.pauseButton);
			this.Controls.Add(this.playButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.volumeBar);
			this.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private HScrollBar volumeBar;
		private Label label2;
		private Label label3;
		private Button playButton;
		private Button pauseButton;
		private Button stopButton;
		private Timer playerTimer;
		private ListBox listBox1;
		private Button saveButton;
		private Button loadButton;
		private Button forwardButton;
		private VScrollBar vScrollBar1;
		private VScrollBar vScrollBar2;
		private VScrollBar vScrollBar10;
		private Button backwardButton;
		private VScrollBar vScrollBar3;
		private VScrollBar vScrollBar4;
		private VScrollBar vScrollBar5;
		private VScrollBar vScrollBar6;
		private VScrollBar vScrollBar7;
		private VScrollBar vScrollBar8;
		private VScrollBar vScrollBar9;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem GetAlbumInfo;
        private ToolStripMenuItem GetArtistInfo;
        private ToolStripMenuItem removeTrackToolStripMenuItem;
        private ToolStripMenuItem showTagsToolStripMenuItem;
        private Button AddFiles;
		private Button button1;
		private Label label1;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private Label label9;
		private Label label10;
		private Label label11;
		private Label label12;
		private Button radioButton;
	}
}

