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
        //Employee
        CreateMap<Employee, RDTOEmployeeLogin>().ReverseMap();
        CreateMap<Employee, RDTOEmployee>().ReverseMap();
        CreateMap<Employee, RDTOChangePassword>().ReverseMap();
        CreateMap<Employee, UpdateInfoAsync>().ReverseMap();

        CreateMap<Role, RDTORole>().ReverseMap();
        CreateMap<Permission, RDTOPermission>().ReverseMap();


        #endregion

        #region Response DTOs


        CreateMap<Branch, SDTOBranch>().ReverseMap();
        CreateMap<Package, SDTOPackage>().ReverseMap();
        CreateMap<Employee, SDTOEmployee>().ReverseMap();
        CreateMap<Role, SDTORole>().ReverseMap();

        #endregion

    }
}