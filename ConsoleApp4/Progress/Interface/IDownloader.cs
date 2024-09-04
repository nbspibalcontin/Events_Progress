using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Progress.Interface
{
    public interface IDownloader
    {
        void StartDownload(ProgressCallback progressCallback);
    }
}
