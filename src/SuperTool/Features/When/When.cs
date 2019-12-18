namespace SuperTool.Features.When
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using MediatR;

    public static class When
    {
        public class Query : IRequest<Response>
        {
        }

        public class Response
        {
            public DateTime CurrentTime { get; set; }
        }

        public class Handler : IRequestHandler<Query, Response>
        {
            public Task<Response> Handle(Query request, CancellationToken cancellationToken)
            {
                return Task.FromResult(new Response {CurrentTime = DateTime.UtcNow});
            }
        }
    }
}
