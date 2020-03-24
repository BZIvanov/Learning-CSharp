namespace IntermediateLevel
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            // now we have Width field and Copy method on Text class, because we inherited them from the parent class
            text.Width = 100;
            text.Copy();
		}
    }
}
