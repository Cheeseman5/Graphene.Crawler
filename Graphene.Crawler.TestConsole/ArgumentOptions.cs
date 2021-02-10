using CommandLine;

namespace Graphene.Crawler.TestConsole
{
    // https://github.com/commandlineparser/commandline
    public class ArgumentOptions
    {
        [Option('v', "verbose", Required = false, HelpText = "Set output to verbose messages.")]
        public bool Verbose { get; set; }
    }
}
