using System.IO;

namespace LearnBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            // using keyword will open and close the stream properly. It will be closed on the next closing curly bracket after 'using'
            using StreamWriter writer = new StreamWriter("result.txt");

            // the file will be created in the build folder of the project
            writer.Write("Hello");
            writer.Write("World");
        }
    }
}
