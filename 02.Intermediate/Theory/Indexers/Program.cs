using System;

namespace IntermediateLevel
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Tony";
            Console.WriteLine(cookie["name"]);
		}
    }
}
