namespace SuperTool.Features.DoMath
{
    using System;
    using System.Threading.Tasks;
    using AutoMapper;
    using McMaster.Extensions.CommandLineUtils;
    using MediatR;

    public static class Commands
    {
        [Command("math", Description = "Perform feats of mathematics")]
        public class DoMathCommand
        {
            [Option("-o|--operation", CommandOptionType.SingleValue, Description = "Operation to perform")]
            public MathOperation Operation { get; set; }

            [Option("-l|--left", CommandOptionType.SingleValue, Description = "Left side operand")]
            public double Left { get; set; }

            [Option("-r|--right", CommandOptionType.SingleValue, Description = "Right side operand")]
            public double Right { get; set; }
            
            private async Task OnExecuteAsync(IMediator mediator, IMapper mapper, IConsole console)
            {
                var command = mapper.Map<DoMath.Request>(this);

                var response = await mediator.Send(command);

                console.WriteLine($"{Left} {Enum.GetName(typeof(MathOperation), Operation)} {Right} = {response?.Result}");
            }
        }
    }
}
