using System;

namespace RadioPlayer
{
	public class AudioFile
	{
		public virtual int Id { get; protected set; }
		public virtual string Url { get; set; }
		public virtual string Title { get; set; }
        public virtual string Artist { get; set; }
        public virtual string AlbumTitle { get; set; }
		public virtual TimeSpan Length { get; set; }
		public virtual int Track { get; set; }
		public virtual int TrackCount { get; set; }
		public virtual string Genres { get; set; }
		public virtual int Year { get; set; }
		public virtual string Comment { get; set; }


		protected AudioFile()
		{

		}
		public AudioFile(string url)
		{
            Url = url;
			TagManager t = new TagManager();
			t.GetTags(this);
		}
	}
}
