using CommandLine;
using System;
using System.Text;

namespace Graphene.Crawler.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteArgs(args);
            HandleArgs(args);
        }

        private static void HandleArgs(string[] arguments)
        {
            Parser.Default.ParseArguments<ArgumentOptions>(arguments)
                .WithParsed(o =>
                {
                    if(o.Verbose)
                    {
                        Console.WriteLine($"Verbose output enabled. Current Arguments: -v {o.Verbose}");
                    }
                    else
                    {
                        Console.WriteLine($"Current Arguments: -v {o.Verbose}");
                    }
                });
        }

        private static void WriteArgs(string[] args)
        {
            var sb = new StringBuilder("args: ");

            for (int i = 0; i < args.Length; i++)
            {
                sb.Append(args[i]);
                if (i < args.Length - 1)
                {
                    sb.Append(", ");
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
