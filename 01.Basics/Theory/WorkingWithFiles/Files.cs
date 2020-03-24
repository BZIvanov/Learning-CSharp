using System.IO;

namespace LearnBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            // @ prefix makes it verbating string allowing us to skip char escaping and multilines if we need that
            var path = @"c:\somefile.jpg";

            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
            File.Delete(path);
            if (File.Exists(path))
            {
                // do something
            }
            var content = File.ReadAllText(path);

            // FileInfo provides  instance methods since we instantiate it as class
            var fileInfo = new FileInfo(path);
            fileInfo.Delete();
        }
    }
}
