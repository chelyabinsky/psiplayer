using System;

namespace RadioPlayer
{
	public class AudioFile
	{
		public string Url { get; set; }
		public string Title { get; set; }
        public string Artist { get; set; }
        public string AlbumTitle { get; set; }
		public TimeSpan Length { get; set; }
		public int Track { get; set; }
		public int TrackCount { get; set; }
		public string Genres { get; set; }
		public int Year { get; set; }
		public string Comment { get; set; }

		public AudioFile(string url)
		{
            Url = url;
			TagManager t = new TagManager();
			t.GetTags(this);
		}
	}
}
