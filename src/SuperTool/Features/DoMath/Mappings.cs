namespace SuperTool.Features.DoMath
{
    using AutoMapper;

    public class Mappings : Profile
    {
        public Mappings()
        {
            CreateMap<Commands.DoMathCommand, DoMath.Request>();
        }
    }
}
