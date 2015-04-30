using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WMPLib;

namespace RadioPlayer
{
	public partial class RadioForm : Form
	{
		public struct RadioStation
		{
			public string name;
			public string url;
			public RadioStation(string Name, string Url)
			{
				name = Name;
				url = Url;
			}
		}
		WindowsMediaPlayer Player;
		List<RadioStation> stations = new List<RadioStation>();

		public RadioForm()
		{
			InitializeComponent();

			Player = new WindowsMediaPlayer();
			Player.settings.volume = volumeBar.Value;
			stations.Add(new RadioStation("Zip FM", @"http://84.46.205.13:80/zipfm64.aac"));
			stations.Add(new RadioStation("Power hit radio", @"http://power-stream.data.lt:8000/PHR"));
			listBox1.Items.Add(stations[0].name);
			listBox1.Items.Add(stations[1].name);
		}

		private void newStation_Click(object sender, EventArgs e)
		{
			string[] station = Prompt.ShowDialog("Enter your radio stations' address", "New station", "Enter your radio stations' name");
			RadioStation st = new RadioStation(station[0], "@\""+station[1]+"\"");
			listBox1.Items.Add(station[1]);
			stations.Add(new RadioStation(station[1], station[0]));
		}

		private void playButton_Click(object sender, EventArgs e)
		{
			if (listBox1.SelectedIndex < 0) return;
			int index = listBox1.SelectedIndex;

			Player.URL = stations.ElementAt(index).url;
			Player.controls.play();
		}

		private void volumeBar_Scroll(object sender, ScrollEventArgs e)
		{
			Player.settings.volume = volumeBar.Value;
		}

		private void playStationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int index = listBox1.SelectedIndex;
			Player.URL = stations.ElementAt(index).url;
			Player.controls.play();
		}

		private void stopStationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Player.controls.stop();
		}

		private void listBox1_MouseUp_1(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				int item = listBox1.IndexFromPoint(e.Location);
				if (item >= 0)
				{
					listBox1.SelectedIndex = item;
					contextMenuStrip1.Show(listBox1, e.Location);
				}
			}
		}

		private void stopButton_Click(object sender, EventArgs e)
		{
			Player.controls.stop();
		}

		private void backButton_Click(object sender, EventArgs e)
		{
			Player.controls.stop();
			Dispose();
		}

		private void removeStationToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			int index = listBox1.SelectedIndex;
			stations.Remove(new RadioStation(stations.ElementAt(index).name, stations.ElementAt(index).url));
			listBox1.Items.RemoveAt(index);
			Player.controls.play();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			Player.controls.stop();
		}
	}
}
