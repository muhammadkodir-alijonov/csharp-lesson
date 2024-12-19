using System.Diagnostics;

class Program
{
    public static void Main(string[] args)
    {
        /*Console.WriteLine("1. Calculator");
        Console.WriteLine("2. Notepad");
        int t = int.Parse(Console.ReadLine());
        if (t == 1) Run("calc.exe", "");
        else if (t == 2) Run("notepad.exe", "");
        else Console.WriteLine("Buyruq xato");
        Main(args);*/

        Console.Write("Path: ");
        string path = Console.ReadLine();
        Run("cmd.exe", path);
    }
    public static void Run(string filename, string args)
    {
        Process process = new Process();

        ProcessStartInfo processStartInfo = new ProcessStartInfo()
        {
            FileName = filename,
            RedirectStandardOutput = true,
            RedirectStandardInput = true,
            CreateNoWindow = true,
            UseShellExecute = false,
            //Arguments = args
        };
        process.StartInfo = processStartInfo;
        process.Start();
        process.StandardInput.Flush();
        process.StandardInput.WriteLine(args);
        process.StandardInput.Close();
        process.WaitForExit();
    }
}

