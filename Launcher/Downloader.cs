using System;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace Launcher
{
    class Downloader
    {

        private WebClient wc = new WebClient();
        Uri link = new Uri("https://dl.dropboxusercontent.com/s/ya6m3l3mdrqfd3h/tekstowy.TXT");

        public void main()
        { 
            Console.WriteLine("Pobieranie uruchomione sex");
            wc.DownloadFileAsync(link, "pobrany.txt");

        }
    }
}
