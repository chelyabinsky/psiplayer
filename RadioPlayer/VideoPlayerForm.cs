using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioPlayer
{
	public partial class VideoPlayerForm : Form
	{
		private string _path;
		public VideoPlayerForm()
		{
			InitializeComponent();
		}

		public VideoPlayerForm(string path)
			: base()
		{
			_path = path;
		}
		private void VideoPlayerForm_Load(object sender, EventArgs e)
		{
			axWindowsMediaPlayer1.URL = _path;
		}
	}
}
