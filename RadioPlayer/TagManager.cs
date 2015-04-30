using System;
using System.IO;
using File = TagLib.File;

namespace RadioPlayer
{
	class TagManager
	{
		public void GetTags(AudioFile f)
		{
			File file = File.Create(f.Url);
			f.Artist = file.Tag.FirstArtist;
			f.Title = file.Tag.Title;
			f.Length = file.Properties.Duration;
			f.AlbumTitle = file.Tag.Album;
			f.Track = Convert.ToInt32(file.Tag.Track);
			f.TrackCount = Convert.ToInt32(file.Tag.TrackCount);
			f.Genres = String.Join(", ", file.Tag.Genres);
			f.Year = Convert.ToInt32(file.Tag.Year);
			f.Comment = file.Tag.Comment;
		}
		public void SetTags(AudioFile file, ShowTags frm)
		{
			File tags = File.Create(file.Url);
			string[] arists = { frm.Atlikejas.Text };
			tags.Tag.Artists = arists;
			file.Artist = frm.Atlikejas.Text;
			file.Title = frm.DainosPavadinimas.Text;
			file.AlbumTitle = frm.AlbumoPavadinimas.Text;
			tags.Tag.Album = frm.AlbumoPavadinimas.Text;
			tags.Tag.Track = Convert.ToUInt32(frm.DainosNumeris.Text);
			tags.Tag.Title = frm.DainosPavadinimas.Text;
			tags.Tag.TrackCount = Convert.ToUInt32(frm.DainuKiekis.Text);
			tags.Tag.Comment = frm.Komentaras.Text;
			string[] genres = { frm.Zanras.Text };
			tags.Tag.Genres = genres;
			tags.Tag.Year = Convert.ToUInt32(frm.IsleidimoMetai.Text);
			
			file.Track = Convert.ToInt32(frm.DainosNumeris.Text);
			file.TrackCount = Convert.ToInt32(frm.DainuKiekis.Text);
			file.Comment = frm.Komentaras.Text;
			file.Genres = frm.Zanras.Text;
			file.Year = Convert.ToInt32(frm.IsleidimoMetai.Text);
			try
			{
				tags.Save();
			}
			catch (IOException)
			{
				throw;
			}
		}
	}
}
