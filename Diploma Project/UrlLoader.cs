using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diploma_Project
{
    public static class UrlLoader
    {
        public static void LoadVideo(string videoId,WebBrowser webBrowser)
        {
            string html = $@"
            <html>
                <head>
                    <meta content='IE=Edge' http-equiv='X-UA-Compatible'/>
                </head>
                <body>
                <iframe id='video' src='https://www.youtube.com/embed/{videoId}' 
                    width='600' height='300' frameborder='0' allowfullscreen>
                </iframe>
                </body>
            </html>";

            webBrowser.DocumentText = html;
        }
    }
}
