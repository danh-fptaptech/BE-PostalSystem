using AutoMapper;
using TARS_Delivery.Models.DTOs;
using TARS_Delivery.Models.DTOs.req.Location;
using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.DTOs.res;

namespace TARS_Delivery.Models;

public class DtoProfile : Profile
{
    public DtoProfile() {
      
        #region Request DTOs
        
        
        CreateMap<Branch, RDTOBranch>().ReverseMap();
        

        #endregion

        #region Response DTOs

        
        CreateMap<Branch, SDTOBranch>().ReverseMap();
        CreateMap<Employee, EmployeeDTO>().ReverseMap();

        CreateMap<Location, RDTOLocation>().ReverseMap();
        CreateMap<Location, RDTOLocationByZipcode>().ReverseMap();
        CreateMap<Package, SDTOPackage>().ReverseMap();
        
        CreateMap<Package, SDTOPackageList>()
            .AfterMap((src, dest) => dest.CounterItem = src.Items.Count)
            .ReverseMap();

        #endregion
        
    }
}