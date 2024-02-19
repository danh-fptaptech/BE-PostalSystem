using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Security;
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
            IEnumerable<Role> roles = await _context.Roles
                .Include(r => r.RoleHasPermissions)
                .ToListAsync();

            IEnumerable<SDTORole> dtoRoles = roles.Select(r => new SDTORole
            {
                Id = r.Id,
                RoleName = r.RoleName,
                Status = r.Status,
                RoleHasPermissions = r.RoleHasPermissions.Select(rhp => new RoleHasPermission
                {
                    RoleId = rhp.RoleId,
                    PermissionId = rhp.PermissionId,
                }).ToList(),
            });

            return dtoRoles;
        }

        public async Task<SDTORole> GetRole(int id)
        {
            var role = await _context.Roles
                .Include(r => r.RoleHasPermissions)
                .FirstOrDefaultAsync(r => r.Id == id);
            if(role != null)
            {
                SDTORole dtoRole = new()
                {
                    Id = role.Id,
                    RoleName = role.RoleName,
                    Status = role.Status,
                    RoleHasPermissions = role.RoleHasPermissions.Select(rhp => new RoleHasPermission 
                    { 
                        RoleId = rhp.RoleId,
                        PermissionId = rhp.PermissionId 
                    }).ToList(),
                };
                return dtoRole;
            }
            throw new Exception("The role does not exist !");
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
                var updatedRole = await _context.Roles.FindAsync(id);
                if (updatedRole != null)
                {
                    var existingRole = await _context.Roles
                        .FirstOrDefaultAsync(r => r.RoleName == role.RoleName && r.Id != id);

                    if (existingRole != null)
                    {
                        throw new Exception("The role name already exists.");
                    }

                    _context.Entry(updatedRole).CurrentValues.SetValues(role);
                    await _context.SaveChangesAsync();

                    return updatedRole;
                }
                throw new Exception("This role does not exist!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: ", ex.Message);
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
