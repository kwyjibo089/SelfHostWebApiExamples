using System.IO;

namespace SelfHostApi.Helper
{
    public class FileWriter
    {
        private const string Path = @"c:\temp\log.txt";

        public static void WriteToFile(string content)
        {
            if (!File.Exists(Path))
            {
                using (var sw = File.CreateText(Path))
                {
                    sw.WriteLine(content);
                }
            }
            else
            {
                using (var sw = File.AppendText(Path))
                {
                    sw.WriteLine(content);
                }
            }
        }
    }
}
