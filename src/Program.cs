using System.CommandLine;

namespace Mscl;

public class Program
{
    protected Program() { }

    public static async Task Main(string[] args)
    {
        var rootCommand = new RootCommand("Sample command-line app");
        var sub1Command = new Command("sub1", "First-level subcommand");
        rootCommand.Add(sub1Command);

        rootCommand.SetHandler(() =>
        {
            Console.WriteLine("Hello world!");
        });

        await rootCommand.InvokeAsync(args);
    }
}
