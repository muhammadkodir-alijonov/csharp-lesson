namespace file;

public class Program
{
    static void Main(string[] args)
    {
        /*tring path = @"D:\\muhammad.png";

        byte[] music = File.ReadAllBytes(path);

        Array.Resize(ref music, music.Length/4);

       /* foreach (var @byte in music )
        {
            Console.Write(@byte);
        }
        
        File.WriteAllBytes(@"D:\\muhammad2.png", music);*/

        /*string path = @"d://text.txt";
        StreamWriter streamWriter = new StreamWriter(path);

        for (int i = 0; i < 10000; i++)
        {
            streamWriter.Write(i + " ");
        }
        streamWriter.Close();*/

        string path = @"d://Timemanagement.txt";

        StreamReader streamReader = new StreamReader(path);

        while (!streamReader.EndOfStream)
        {
            string str = streamReader.ReadLine();
            Console.WriteLine(str);
        }
        streamReader.Close();
    }
}