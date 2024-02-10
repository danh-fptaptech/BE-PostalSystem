using AutoMapper;
using TARS_Delivery.Models.DTOs;
using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.DTOs.res;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Models;

public class DtoProfile : Profile
{
    public DtoProfile() {
      
        #region Request DTOs
        
        
        CreateMap<Branch, RDTOBranch>().ReverseMap();
        CreateMap<Employee, RDTOEmployeeLogin>().ReverseMap();
        CreateMap<Employee, RDTOEmployee>().ReverseMap();
        CreateMap<Employee, UpdatePassword>().ReverseMap();
        CreateMap<Role, RDTORole>().ReverseMap();
        CreateMap<Permission, RDTOPermisson>().ReverseMap();


        #endregion

        #region Response DTOs


        CreateMap<Branch, SDTOBranch>().ReverseMap();
        CreateMap<Package, SDTOPackage>().ReverseMap();
        CreateMap<Employee, SDTOEmployee>().ReverseMap();
        CreateMap<Role, SDTORole>().ReverseMap();

        #endregion

    }
}