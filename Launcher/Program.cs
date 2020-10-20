using System;
using System.Net;
using System.Net.Http;
using System.Security.Policy;

namespace Launcher
{

    class Program
    {
        private WebClient wc = new WebClient();
        //static Program tenprogram = new Program();
        static Downloader tendownloader = new Downloader();

        Uri url = null;

        static void Main()
        {
            //Console.WriteLine("Hello World!");
            tendownloader.main();

            //tenprogram.wc.DownloadFileAsync(new System.Uri("https://dl.dropboxusercontent.com/s/ya6m3l3mdrqfd3h/tekstowy.TXT"), "downloaded1.txt");

            //pr.wc.DownloadFileAsync(new System.Uri("https://dl.dropboxusercontent.com/s/ya6m3l3mdrqfd3h/tekstowy.TXT"), "downloaded1.txt");
        }

    }
}
