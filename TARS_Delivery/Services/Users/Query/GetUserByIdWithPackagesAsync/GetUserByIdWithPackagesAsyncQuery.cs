using MediatR;
using TARS_Delivery.Services.Users.Query.GetUsersWithPackagesAsync;
using TARS_Delivery.Shared;
namespace TARS_Delivery.Services.Users.Query.GetUserByIdWithPackagesAsync;

internal record GetUserByIdWithPackagesAsyncQuery(int Id) : IRequest<Result<UserWithPackagesResponse>>;
