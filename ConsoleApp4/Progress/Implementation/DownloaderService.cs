using ConsoleApp4.Progress.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Progress.Implementation
{
    public class DownloaderService : IDownloader
    {
        public void StartDownload(ProgressCallback progressCallback)
        {
            for (int i = 0; i <= 100; i += 10)
            {
                Thread.Sleep(500); // Simulate download work
                progressCallback?.Invoke(i); // Invoke the callback to report progress
            }
        }
    }
}
