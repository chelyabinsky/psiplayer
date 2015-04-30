using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using Lastfm.Services;

namespace RadioPlayer
{
	public partial class Form1 : Form
	{
		public static Label nameLabel2;
		public static HScrollBar positionBar2;
		public int timePassed, i;
		public TimeSpan ts;
		private bool eqEnabled;
		Player player;
		Playlist activePL;
		private LastFmWrapper lastfm;

		public Form1()
		{
			player = new Player(this);
			nameLabel2 = new Label();
			activePL = new Playlist();
			timePassed = 0;
			positionBar2 = new HScrollBar();
			InitializeComponent();
			lastfm = new LastFmWrapper();
			button1.Text = "ON";
			eqEnabled = true;
			player.player2.EnableEqualizer(eqEnabled);
		}


		private void Form1_Load(object sender, EventArgs e)
		{
			positionBar2.Name = "positionBar2";
			positionBar2.Size = new Size(202, 21);
			positionBar2.Location = new Point(26, 33);
			positionBar2.Visible = true;
			positionBar2.Scroll += positionBar2_Scroll;
			positionBar2.Maximum = 109;

			nameLabel2.Visible = true;
			nameLabel2.Location = new Point(80, 15);
			nameLabel2.Size = new Size(100, 15);
			Controls.Add(nameLabel2);
			Controls.Add(positionBar2);

		}

		public void positionBar2_Scroll(object sender, ScrollEventArgs e)
		{
			player.SetPlayerPosition(positionBar2.Value);
		}

		private void volumeBar_Scroll(object sender, ScrollEventArgs e)
		{
			player.SetPlayerVolume(volumeBar.Value);
		}

		private void pauseButton_Click(object sender, EventArgs e)
		{
			player.Pause();
		}

		private void playButton_Click(object sender, EventArgs e)
		{
			player.Play();
		}

		private void stopButton_Click(object sender, EventArgs e)
		{
			player.Stop();
		}

		public static void ChangeNameLabel(string s)
		{
			nameLabel2.Text = s;
		}

		public static void ChangePositionBar(int i)
		{
			positionBar2.Value = i;
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "m3u Files (*m3u)|*.m3u";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				using (Stream s = File.Open(saveFileDialog.FileName, FileMode.OpenOrCreate))
				{
					using (TextWriter tw = new StreamWriter(s))
					{
						activePL.SavePlaylist(tw);
					}
				}
			}
		}

		private void loadButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "m3u Files (*m3u)|*.m3u";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				activePL.LoadPlaylist(openFileDialog.FileName);
				listBox1.Items.Clear();
				foreach (AudioFile song in activePL.Songs)
				{
					if (song.Length.Seconds < 10)
					{
						listBox1.Items.Add(String.Format("{0}:0{1} --- {2} - {3}", song.Length.Minutes, song.Length.Seconds, song.Artist, song.Title));
					}
					else
					{
						listBox1.Items.Add(String.Format("{0}:{1} --- {2} - {3}", song.Length.Minutes, song.Length.Seconds, song.Artist, song.Title));
					}
				}
			}
		}

		public void Forward()
		{
			if (activePL.CurrentLoaded + 1 < listBox1.Items.Count)
			{
				player.PlayMusicFromURL(activePL.Songs.ElementAt(activePL.CurrentLoaded + 1));
				activePL.CurrentLoaded++;
				Text = listBox1.Items[activePL.CurrentLoaded] as string;
				listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
			}
		}

		private void forwardButton_Click(object sender, EventArgs e)
		{
			Forward();
		}

		private void backwardButton_Click(object sender, EventArgs e)
		{
			if (activePL.CurrentLoaded > 0)
			{
				player.PlayMusicFromURL(activePL.Songs.ElementAt(activePL.CurrentLoaded - 1));
				activePL.CurrentLoaded--;
				Text = listBox1.Items[activePL.CurrentLoaded] as string;
				listBox1.SelectedIndex = listBox1.SelectedIndex - 1;
			}
		}

		private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
		{

		}

		private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
		{


		}

		private void vScrollBar3_Scroll(object sender, ScrollEventArgs e)
		{


		}

		private void vScrollBar4_Scroll(object sender, ScrollEventArgs e)
		{


		}

		private void vScrollBar5_Scroll(object sender, ScrollEventArgs e)
		{


		}

		private void vScrollBar10_Scroll(object sender, ScrollEventArgs e)
		{


		}

		private void vScrollBar9_Scroll(object sender, ScrollEventArgs e)
		{


		}

		private void vScrollBar8_Scroll(object sender, ScrollEventArgs e)
		{



		}

		private void vScrollBar7_Scroll(object sender, ScrollEventArgs e)
		{



		}

		private void vScrollBar6_Scroll(object sender, ScrollEventArgs e)
		{

		}

		private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
		{

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

		private void GetAlbumInfo_Click(object sender, EventArgs e)
		{
			if (!lastfm.Session.Authenticated)
			{
				LastFmLogin();
			}
			if (lastfm.Session.Authenticated)
			{
				AudioFile selectedSong = activePL.Songs.ElementAt(listBox1.SelectedIndex);
				string content;
				try
				{
					content = lastfm.GetAlbumInfo(selectedSong.Artist, selectedSong.AlbumTitle);
				}
				catch (IndexOutOfRangeException)
				{
					content = "Could not find album. Either it does not exist or files tags are incorrect";
				}
				catch (WebException)
				{
					content = "Either internet connection is not found or could not find album because file does not have required tags";
				}
				LastFmInfo info = new LastFmInfo(content);
				info.Show();
			}
			
		}

		private void LastFmLogin()
		{
			string[] loginInfo = Prompt.ShowDialog("Sign in to your Last.FM account", "Sign In");
			if (String.IsNullOrEmpty(loginInfo[0]) || String.IsNullOrEmpty(loginInfo[1]))
			{
				MessageBox.Show("You have not entered the login or password");
				return;
			} 
			try
			{
				lastfm.Login(loginInfo[0], loginInfo[1]);
			}
			catch (ServiceException)
			{
				MessageBox.Show("Wrong username or password");
			}
		}

		private void GetArtistInfo_Click(object sender, EventArgs e)
		{
			if (!lastfm.Session.Authenticated)
			{
				LastFmLogin();
			}
			if (lastfm.Session.Authenticated)
			{
				AudioFile selectedSong = activePL.Songs.ElementAt(listBox1.SelectedIndex);
				string content = lastfm.GetArtistInfo(selectedSong.Artist);
				LastFmInfo info = new LastFmInfo(content);
				info.Show();
			}
		}

		private void removeTrackToolStripMenuItem_Click(object sender, EventArgs e)
		{
			activePL.Songs.RemoveAt(listBox1.SelectedIndex);
			listBox1.Items.RemoveAt(listBox1.SelectedIndex);
		}

		private void showTagsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int index = listBox1.SelectedIndex;
			AudioFile file = activePL.Songs.ElementAt(index);
			ShowTags showTags = new ShowTags(file, this, index);
			showTags.Show();

		}
		public void updateList(int index, AudioFile file)
		{
			listBox1.Items.RemoveAt(index);
			string insert;
			if (file.Length.Seconds < 10)
			{
				insert = String.Format("{0}:0{1} --- {2} - {3}", file.Length.Minutes, file.Length.Seconds, file.Artist, file.Title);
			}
			else
			{
				insert = String.Format("{0}:{1} --- {2} - {3}", file.Length.Minutes, file.Length.Seconds, file.Artist, file.Title);
			}
			listBox1.Items.Insert(index, insert);
		}

		private void AddFiles_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "mp3 Files (*mp3)|*.mp3";
			openFileDialog.Multiselect = true;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				foreach (string path in openFileDialog.FileNames)
				{
					AudioFile song = new AudioFile(path);
					activePL.Songs.Add(song);
					if (song.Length.Seconds < 10)
					{
						listBox1.Items.Add(String.Format("{0}:0{1} --- {2} - {3}", song.Length.Minutes, song.Length.Seconds, song.Artist, song.Title));
					}
					else
					{
						listBox1.Items.Add(String.Format("{0}:{1} --- {2} - {3}", song.Length.Minutes, song.Length.Seconds, song.Artist, song.Title));
					}
				}
			}
		}

		private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (listBox1.SelectedIndex < 0) return;
			int index = listBox1.SelectedIndex;
			player.PlayMusicFromURL(activePL.Songs.ElementAt(index));
			Text = String.Format("{0} - {1}", activePL.Songs.ElementAt(index).Artist, activePL.Songs.ElementAt(index).Title);
			activePL.CurrentLoaded = index;


		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (eqEnabled)
			{
				player.player2.EnableEqualizer(false);
				button1.Text = "OFF";
				eqEnabled = false;
			}
			else
			{
				player.player2.EnableEqualizer(true);
				button1.Text = "ON";
				eqEnabled = true;
			}

		}

		private void vScrollBar1_ValueChanged(object sender, EventArgs e)
		{
			player.SetPoints(0, vScrollBar1.Value * -1);
		}

		private void vScrollBar2_ValueChanged(object sender, EventArgs e)
		{
			player.SetPoints(1, vScrollBar2.Value * -1);
		}

		private void vScrollBar3_ValueChanged(object sender, EventArgs e)
		{
			player.SetPoints(2, vScrollBar3.Value * -1);
		}

		private void vScrollBar4_ValueChanged(object sender, EventArgs e)
		{
			player.SetPoints(3, vScrollBar4.Value * -1);
		}

		private void vScrollBar5_ValueChanged(object sender, EventArgs e)
		{
			player.SetPoints(4, vScrollBar5.Value * -1);
		}

		private void vScrollBar6_ValueChanged(object sender, EventArgs e)
		{
			player.SetPoints(5, vScrollBar6.Value * -1);
		}

		private void vScrollBar7_ValueChanged(object sender, EventArgs e)
		{
			player.SetPoints(6, vScrollBar7.Value * -1);
		}

		private void vScrollBar8_ValueChanged(object sender, EventArgs e)
		{
			player.SetPoints(7, vScrollBar8.Value * -1);
		}

		private void vScrollBar9_ValueChanged(object sender, EventArgs e)
		{
			player.SetPoints(8, vScrollBar9.Value * -1);
		}

		private void vScrollBar10_ValueChanged(object sender, EventArgs e)
		{
			player.SetPoints(9, vScrollBar10.Value * -1);
		}

		private void playerTimer_Tick(object sender, EventArgs e)
		{
			//player.player2.GetStatus
		}


		private void radioButton_Click(object sender, EventArgs e)
		{
			player.Stop();
			RadioForm radio = new RadioForm();
			radio.ShowDialog();
		}

	}
}
