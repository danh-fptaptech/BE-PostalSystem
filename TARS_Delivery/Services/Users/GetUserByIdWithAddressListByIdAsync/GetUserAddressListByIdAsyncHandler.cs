using MediatR;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Repositories;
using TARS_Delivery.Services.Users.GetUserByIdWithAddressListByIdAsync;

namespace TARS_Delivery.Services.Users.GetUserByIdWithAddressListAsync;

internal class GetUserAddressListByIdAsyncHandler(IUserRepository userRepository)
    : IRequestHandler<
        GetUserAddressListByIdAsyncQuery,
        IReadOnlyCollection<AddressList>>
{
    private readonly IUserRepository _userRepository = userRepository;

    public async Task<IReadOnlyCollection<AddressList>> Handle(
        GetUserAddressListByIdAsyncQuery query, 
        CancellationToken cancellationToken)
    {
        User? user = await _userRepository
            .GetUserByIdWithAddressListAsync(query.Id, cancellationToken);

        if (user == null)
        {
            return null;
        }

        IReadOnlyCollection<AddressList> addressList = user
            .Customers
            .Select(c => new AddressList(
                c.Name, 
                c.PhoneNumber, 
                c.Address, 
                c.City, 
                c.District, 
                c.Ward, 
                c.TypeInfo))
            .ToList();

        return addressList;
    }
}
