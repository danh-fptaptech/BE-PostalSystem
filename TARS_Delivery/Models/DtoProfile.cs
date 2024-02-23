using AutoMapper;
using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.DTOs.res;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Models;

public class DtoProfile : Profile
{
    public DtoProfile() {
      
        #region Request DTOs
        
        
        CreateMap<Branch, RDTOBranch>().ReverseMap();
        

        #endregion

        #region Response DTOs

        
        CreateMap<Branch, SDTOBranch>().ReverseMap();
        
        CreateMap<Package, SDTOPackage>().ReverseMap();
        
        CreateMap<Package, SDTOPackageList>()
            .AfterMap((src, dest) => dest.CounterItem = src.Items.Count)
            .ReverseMap();

        #endregion
        
    }
}