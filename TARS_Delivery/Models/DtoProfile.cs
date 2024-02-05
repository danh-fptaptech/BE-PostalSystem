using AutoMapper;
using TARS_Delivery.Models.DTOs.req.Location;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Models;

public class DtoProfile : Profile
{
    public DtoProfile() {
        
        CreateMap<Branch, RDTOBranch>().ReverseMap();
        CreateMap<Branch, SDTOBranch>().ReverseMap();
        CreateMap<Location, RDTOLocation>().ReverseMap();
        CreateMap<Location, RDTOLocationByZipcode>().ReverseMap();
    }
}