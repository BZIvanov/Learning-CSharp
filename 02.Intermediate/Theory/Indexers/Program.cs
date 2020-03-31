using System;

namespace IntermediateLevel
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            // our set keyword will be called here
            cookie["name"] = "Tony";
            // our get keyword will be called here
            Console.WriteLine(cookie["name"]);
		}
    }
}
