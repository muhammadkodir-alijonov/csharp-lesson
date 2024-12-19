using System.Diagnostics;
using System.Net.NetworkInformation;

namespace thread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = 20, minute= 04;
            Thread thread = new Thread(()=>Alarm(hour,minute));
            thread.Start();
        }
        public static void Alarm(int hour, int minut)
        {
            while (true)
            {
                var currentHour = int.Parse(DateTime.Now.ToString("HH"));
                var currentMinute = DateTime.Now.Minute;
                Console.Clear();
                Console.WriteLine(currentHour + ":" + currentMinute+ ":" + DateTime.Now.Second);
                if (currentHour >= hour && currentMinute >= minut)
                {
                    WakeUp();
                    break;
                }
                Thread.Sleep(600);
            }
        }
        public static void WakeUp()
        {
            Console.WriteLine("Uyg'on ukam! ");
            Console.WriteLine("Musiqani eshit va tur");
            PlayMusic();
            Console.WriteLine("Tugadi ukam tur");
        }

        public static void PlayMusic()
        {
            string path = "d://alarm.mp3";

            ProcessStartInfo processStartInfo = new ProcessStartInfo()
            {
                FileName = "cmd.exe",
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            Process process = new Process();
            process.StartInfo = processStartInfo;
            process.Start();
            process.StandardInput.WriteLine(path);
            //process.BeginErrorReadLine();
            process.WaitForExit(600);
            process.Dispose();
            //process.Kill();
        }
    }
}