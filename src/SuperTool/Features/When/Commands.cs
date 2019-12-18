namespace SuperTool.Features.When
{
    using System;
    using System.Threading.Tasks;
    using McMaster.Extensions.CommandLineUtils;
    using MediatR;

    public static class Commands
    {
        [Command(Name = "when", Description = "Get the current time")]
        public class WhenCommand
        {
            private async Task OnExecute(IMediator mediator, IConsole console)
            {
                var response = await mediator.Send(new When.Query());

                console.WriteLine($"Current Time: {response.CurrentTime:O}");
            }
        }
    }
}
