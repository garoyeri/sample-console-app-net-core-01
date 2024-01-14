using Microsoft.Extensions.DependencyInjection;

namespace SuperTool
{
    using System.Reflection;
    using System.Threading.Tasks;
    using McMaster.Extensions.CommandLineUtils;
    using Microsoft.Extensions.Hosting;

    [Command(Name = "SuperTool",
        Description = "Run helpful utilities for my application")]
    [HelpOption]
    [VersionOptionFromMember(MemberName = "GetVersion")]
    [Subcommand(
        typeof(Features.When.Commands.WhenCommand),
        typeof(Features.DoMath.Commands.DoMathCommand))
    ]
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            await CreateHostBuilder()
                .RunCommandLineApplicationAsync<Program>(args);
        }

        public static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    services
                        .AddMediatR(o => o.RegisterServicesFromAssemblyContaining<Program>())
                        .AddAutoMapper(typeof(Program).Assembly);
                });
        }

        private int OnExecute(CommandLineApplication app, IConsole console)
        {
            console.WriteLine("You must specify a command");
            app.ShowHelp();
            return 1;
        }

        private string GetVersion()
        {
            return typeof(Program).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()
                ?.InformationalVersion;
        }
    }
}