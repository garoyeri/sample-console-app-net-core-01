namespace SuperTool.Features.DoMath
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using MediatR;

    public static class DoMath
    {
        public class Request : IRequest<Response>
        {
            public MathOperation Operation { get; set; }
            public double Left { get; set; }
            public double Right { get; set; }
        }

        public class Response
        {
            public double Result { get; set; }
        }

        public class Handler : IRequestHandler<Request, Response>
        {
            public Task<Response> Handle(Request request, CancellationToken cancellationToken)
            {
                switch (request.Operation)
                {
                    case MathOperation.Add:
                        return RespondWith(request.Left + request.Right);
                    case MathOperation.Subtract:
                        return RespondWith(request.Left - request.Right);
                    case MathOperation.Multiply:
                        return RespondWith(request.Left * request.Right);
                    case MathOperation.Divide:
                        return RespondWith(request.Left / request.Right);
                    default:
                        throw new InvalidOperationException("Unsupported operation");
                }
            }

            private Task<Response> RespondWith(double result)
            {
                return Task.FromResult(new Response {Result = result});
            }
        }
    }
}
