using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models;
using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.DTOs.res;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Repositories.imp
{
    public class RoleRepository : IRoleRepository
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        public RoleRepository(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<SDTORole>> GetRoles()
        {
            IEnumerable<Role> roles = await _context.Roles.ToListAsync();
            return _mapper.Map<IEnumerable<SDTORole>>(roles);
        }

        public async Task<Role> GetRole(int id)
        {
            return await _context.Roles.FindAsync(id);
        }

        public async Task<Role> Create(Role role)
        {
            try
            {
                var duplicatedRoleName = await _context.Roles.FirstOrDefaultAsync(r => r.RoleName == role.RoleName);
                if (duplicatedRoleName != null)
                {
                    throw new Exception("The role name has already existed.");
                }

                await _context.Roles.AddAsync(role);
                await _context.SaveChangesAsync();

                return role;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Role> Update(int id, RDTORole role)
        {
            try
            {
                Role updatedRole = await _context.Roles.FindAsync(id);
                if (updatedRole != null)
                {
                    if(updatedRole.Id > 3)
                    {
                        updatedRole.RoleName = role.RoleName;
                        updatedRole.Status = role.Status;
                        await _context.SaveChangesAsync();
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Role> Delete(int id)
        {
            try
            {
                var removedRole = await _context.Roles.FindAsync(id);
                if (removedRole != null)
                {
                    if (removedRole.Id > 3)
                    {
                        _context.Roles.Remove(removedRole);
                        await _context.SaveChangesAsync();
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
