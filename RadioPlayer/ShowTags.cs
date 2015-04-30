using System;
using System.IO;
using System.Windows.Forms;

namespace RadioPlayer
{
    public partial class ShowTags : Form
    {
        private AudioFile file;
        private int index;
        private Form1 frm;
        public ShowTags(AudioFile file, Form1 frm, int index)
        {
            InitializeComponent();
            this.file = file;
            Atlikejas.Text = file.Artist;
            AlbumoPavadinimas.Text = file.AlbumTitle;
            DainosPavadinimas.Text = file.Title;
            IsleidimoMetai.Text = file.Year.ToString();
            Zanras.Text = file.Genres;
            Komentaras.Text = file.Comment;
            DainosNumeris.Text = Convert.ToString(file.Track);
            DainuKiekis.Text = Convert.ToString(file.TrackCount);
            this.index = index;
            this.frm = frm;
        }

        private void ShowTags_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
			TagManager t = new TagManager();
			try
			{
				t.SetTags(file, this);
				frm.Invoke((MethodInvoker) delegate
            {
                frm.updateList(index, file);   
            });
			}
			catch (IOException)
			{
				MessageBox.Show("Cannot edit tags of a file that is currently playing");
			}
        }

		private void label7_Click(object sender, EventArgs e)
		{

		}
    }
}
