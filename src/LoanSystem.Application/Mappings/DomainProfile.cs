using AutoMapper;
using LoanSystem.Domain.Entities;
using LoanSystem.Application.DTOs;

namespace LoanSystem.Application.Mappings
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<Customer, CustomerDto>()
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FirstName + " " + src.LastName));
            CreateMap<LoanRequest, LoanRequestDto>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status.ToString()));
            CreateMap<LoanRequestDto, LoanRequest>().ReverseMap();
            CreateMap<Facility, FacilityDto>().ReverseMap();
            CreateMap<FacilityDto, Facility>()
                .ConstructUsing(src => new Facility(src.Code, src.Name, src.FacilityGroupId, src.PaymentStages));
            CreateMap<FacilityGroup, FacilityGroupDto>().ReverseMap();
        }
    }
}
