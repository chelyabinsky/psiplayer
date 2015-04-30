using System.ComponentModel;
using System.Windows.Forms;

namespace RadioPlayer
{
	partial class RadioForm
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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.playButton = new System.Windows.Forms.Button();
			this.volumeBar = new System.Windows.Forms.HScrollBar();
			this.backButton = new System.Windows.Forms.Button();
			this.newStation = new System.Windows.Forms.Button();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.removeStationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.playStationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeStationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.stopButton = new System.Windows.Forms.Button();
			this.changeStationsNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(12, 12);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(260, 95);
			this.listBox1.TabIndex = 0;
			this.listBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseUp_1);
			// 
			// playButton
			// 
			this.playButton.Location = new System.Drawing.Point(12, 197);
			this.playButton.Name = "playButton";
			this.playButton.Size = new System.Drawing.Size(75, 23);
			this.playButton.TabIndex = 1;
			this.playButton.Text = "Play";
			this.playButton.UseVisualStyleBackColor = true;
			this.playButton.Click += new System.EventHandler(this.playButton_Click);
			// 
			// volumeBar
			// 
			this.volumeBar.Location = new System.Drawing.Point(9, 110);
			this.volumeBar.Maximum = 109;
			this.volumeBar.Name = "volumeBar";
			this.volumeBar.Size = new System.Drawing.Size(260, 17);
			this.volumeBar.TabIndex = 2;
			this.volumeBar.Value = 50;
			this.volumeBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.volumeBar_Scroll);
			// 
			// backButton
			// 
			this.backButton.Location = new System.Drawing.Point(197, 226);
			this.backButton.Name = "backButton";
			this.backButton.Size = new System.Drawing.Size(75, 23);
			this.backButton.TabIndex = 3;
			this.backButton.Text = "Exit";
			this.backButton.UseVisualStyleBackColor = true;
			this.backButton.Click += new System.EventHandler(this.backButton_Click);
			// 
			// newStation
			// 
			this.newStation.Location = new System.Drawing.Point(12, 130);
			this.newStation.Name = "newStation";
			this.newStation.Size = new System.Drawing.Size(75, 23);
			this.newStation.TabIndex = 4;
			this.newStation.Text = "Add station";
			this.newStation.UseVisualStyleBackColor = true;
			this.newStation.Click += new System.EventHandler(this.newStation_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeStationToolStripMenuItem,
            this.playStationToolStripMenuItem,
            this.removeStationToolStripMenuItem1});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(157, 70);
			// 
			// removeStationToolStripMenuItem
			// 
			this.removeStationToolStripMenuItem.Name = "removeStationToolStripMenuItem";
			this.removeStationToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
			this.removeStationToolStripMenuItem.Text = "Stop station";
			// 
			// playStationToolStripMenuItem
			// 
			this.playStationToolStripMenuItem.Name = "playStationToolStripMenuItem";
			this.playStationToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
			this.playStationToolStripMenuItem.Text = "Play station";
			this.playStationToolStripMenuItem.Click += new System.EventHandler(this.playStationToolStripMenuItem_Click);
			// 
			// removeStationToolStripMenuItem1
			// 
			this.removeStationToolStripMenuItem1.Name = "removeStationToolStripMenuItem1";
			this.removeStationToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
			this.removeStationToolStripMenuItem1.Text = "Remove station";
			this.removeStationToolStripMenuItem1.Click += new System.EventHandler(this.removeStationToolStripMenuItem1_Click);
			// 
			// stopButton
			// 
			this.stopButton.Location = new System.Drawing.Point(12, 226);
			this.stopButton.Name = "stopButton";
			this.stopButton.Size = new System.Drawing.Size(75, 23);
			this.stopButton.TabIndex = 6;
			this.stopButton.Text = "Stop";
			this.stopButton.UseVisualStyleBackColor = true;
			this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
			// 
			// changeStationsNameToolStripMenuItem
			// 
			this.changeStationsNameToolStripMenuItem.Name = "changeStationsNameToolStripMenuItem";
			this.changeStationsNameToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
			this.changeStationsNameToolStripMenuItem.Text = "Change stations\' name";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(234, 130);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Volume";
			// 
			// RadioForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.stopButton);
			this.Controls.Add(this.newStation);
			this.Controls.Add(this.backButton);
			this.Controls.Add(this.volumeBar);
			this.Controls.Add(this.playButton);
			this.Controls.Add(this.listBox1);
			this.Name = "RadioForm";
			this.Text = "RadioForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ListBox listBox1;
		private Button playButton;
		private HScrollBar volumeBar;
		private Button backButton;
		private Button newStation;
		private ContextMenuStrip contextMenuStrip1;
		private ToolStripMenuItem removeStationToolStripMenuItem;
		private ToolStripMenuItem playStationToolStripMenuItem;
		private Button stopButton;
		private ToolStripMenuItem removeStationToolStripMenuItem1;
		private ToolStripMenuItem changeStationsNameToolStripMenuItem;
		private Label label1;
	}
}