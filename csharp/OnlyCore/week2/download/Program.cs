using System.Diagnostics;
using VideoLibrary;

namespace download
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string link = "https://www.youtube.com/shorts/desgIodH3lE";

            string output = "D:\\";

            Console.WriteLine("Waiting.....");

            DownloadVideo(link, output);

            Console.WriteLine("Loaded!");
        }
        public static void DownloadVideo(string link, string output)
        {
            YouTube youtube = new YouTube();

            YouTubeVideo video = youtube.GetVideo(link);

            byte[] result = video.GetBytes();

            string filename = Path.Combine(output, $"{video.FullName}.{video.FileExtension}");

            File.WriteAllBytes(filename, result);

            ProcessStartInfo info = new ProcessStartInfo();

            info.FileName = filename;
            info.UseShellExecute = true;

            Process.Start(info);
        }
    }
}