using ConsoleApp4.Progress;
using ConsoleApp4.Progress.Implementation;
using ConsoleApp4.Progress.Interface;

public class Program
{
    private static readonly IDownloader downloaderService = new DownloaderService();

    public static void Main(string[] args)
    {
        // Define the callback method
        ProgressCallback callback = progress => Console.WriteLine($"Download progress: {progress}%");

        downloaderService.StartDownload(callback);
    }
}