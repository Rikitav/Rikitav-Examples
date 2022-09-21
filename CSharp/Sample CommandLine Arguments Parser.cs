namespace ExampleApp
{
    class ExampleClass
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
                if (args[i].StartsWith("-") || args[i].StartsWith("/"))
                    switch (args[i].Substring(1).ToLower())
                    {
                        case "print": 
                            Console.WriteLine(args[++i]); break;

                        case "win": 
                            Console.WriteLine("Win"); break;

                        case "help": 
                        case "?": 
                            ShowHelp(); break;

                        default: 
                            Console.WriteLine("No valid argument"); break;
                    }
        }
    }
}
