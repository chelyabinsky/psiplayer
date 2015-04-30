using System.Windows.Forms;

namespace RadioPlayer
{
    public partial class LastFmInfo : Form
    {
        private string content;
        public LastFmInfo(string content)
        {
            InitializeComponent();
            this.content = content;
            webBrowser1.DocumentText = content;
            webBrowser1.AllowNavigation = false;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
        //private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        //{
        //    //Regex regex = new Regex(@"facebook|spotify|youtube|google|doubleclick");
        //    //Match match = regex.Match(e.Url.AbsoluteUri);
        //    if (e.Url.AbsoluteUri.Equals("about:blank"))
        //    {
        //        webBrowser1.AllowNavigation = false;
        //        return;
        //    }
        //    //if (match.Success)
        //    //{
        //    //    webBrowser1.Stop();
        //    //    return;
        //    //}
        //    //webBrowser1.DocumentText = content;
        //    //System.Diagnostics.Process.Start(e.Url.ToString());

        //}
    }
}
