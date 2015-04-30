using System.Collections.Generic;
using System.IO;

namespace RadioPlayer
{
    class Playlist
    {
        private List<AudioFile> songs;
        public int LoadedIndex { get; set; }
        public int CurrentLoaded { get; set; }
        public List<AudioFile> Songs
        {
            get { return songs; }
            set { songs = value; }
        }
        public Playlist()
        {
            songs = new List<AudioFile>();
            CurrentLoaded = -1;
        }
        public void AddSong(AudioFile audio)
        {
            songs.Add(audio);
        }

        public void SavePlaylist(TextWriter tw)
        {
            foreach (AudioFile file in songs)
            {
                tw.WriteLine(file.Url);
            }
        }
        public void LoadPlaylist(string path)
        {
            songs.Clear();
            string[] readText = File.ReadAllLines(path);
            foreach (string s in readText)
            {
                songs.Add(new AudioFile(s));
            }
        }
    }
}
