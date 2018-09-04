using AutoMapper;
using AutomapperASPNetCore.Models;

namespace AutomapperASPNetCore
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee, EmployeeVM>().ForMember(dest => 
                dest.Address, 
                opts => 
                    opts.MapFrom(src => new Address
                    {
                        City = src.City,
                        State = src.State
                    }));

            CreateMap<EmployeeVM, Employee>().ForMember(dest =>
                dest.City,
                opts =>
                    opts.MapFrom(src => 
                        src.Address.City));

            CreateMap<EmployeeVM, Employee>().ForMember(dest =>
                dest.State,
                opts =>
                    opts.MapFrom(src =>
                        src.Address.State));
        }
    }
}
