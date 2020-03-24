using System;
using System.IO;

namespace LearnBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"c:\temp\some-folder");

            var files = Directory.GetFiles(@"c:\projects\my-files", "*.*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            var directoryInfo = new DirectoryInfo(@"c:\temp\some-folder");
            directoryInfo.GetFiles();
        }
    }
}
