using System;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using Lastfm;
using Lastfm.Services;

namespace RadioPlayer
{
    class LastFmWrapper
    {
        private string API_KEY = "e48a6f5fc33f3d718ed13dd0cbae817b";
        private string API_SECRET = "638fc7579fc0ce42d14ea156f96a2f84";
        private Session session;
        public Session Session
        {
            get { return session; }
        }

        public LastFmWrapper()
        {
            session = new Session(API_KEY, API_SECRET);
        }
        public void Login(string username, string password)
        {
            string md5password = Utilities.md5(password);
			try
			{
				session.Authenticate(username, md5password);
			}
			catch (ServiceException)
			{
				throw;
			}
        }
        public string GetArtistInfo(string title)
        {
            Artist artist = new Artist(title, session);
			try
			{
				return artist.Bio.getContent();
			}
			catch (ServiceException)
			{
				return String.Format("Artist {0} not found", title);
			}
			catch (WebException)
			{
				return "Internet connection not found";
			}
            
        }
        public string GetAlbumInfo(string artistTitle, string albumTitle)
        {
            Album alb = new Album(artistTitle, albumTitle, session);
            string url = alb.Wiki.URL;
            WebClient wc = new WebClient();
			string html = "";
			try
			{
				html = Encoding.UTF8.GetString(wc.DownloadData(url));

			}
			catch (WebException)
			{
				throw;
			}
            Regex regex = new Regex("<div id=\"wiki\">");
            string[] temp = regex.Split(html);
            Regex regex2 = new Regex("</div><!-- #wiki -->");
			try
			{
				return regex2.Split(temp[1]).ElementAt(0);
			}
			catch(IndexOutOfRangeException)
			{
				throw;
			}
            
        }
    }
}
