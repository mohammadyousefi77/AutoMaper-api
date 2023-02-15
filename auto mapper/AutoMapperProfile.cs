using AutoMapper;

namespace auto_mapper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<StudentDTO, Student>().ForMember(dest => dest.City, opt => opt.MapFrom(src => src.CurrentCity))

                 .ForMember(dest => dest.Regionn, opt => opt.MapFrom(src => src.Region)); 

        }
    }
}
