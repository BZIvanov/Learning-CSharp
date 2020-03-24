using System.IO;

namespace LearnBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Projects\Hello-World\world.jpg";
            var ext = Path.GetExtension(path);
            var name = Path.GetFileName(path);
        }
    }
}
