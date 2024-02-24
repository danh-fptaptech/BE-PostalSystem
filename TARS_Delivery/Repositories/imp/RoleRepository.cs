using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Data;
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

        public async Task<IEnumerable<Role>> GetRoles()
        {
            IEnumerable<Role> roles = await _context.Roles
                .ToListAsync();


            return roles;
        }

        public async Task<Role> GetRole(int id)
        {
            var role = await _context.Roles     
                .FirstOrDefaultAsync(r => r.Id == id);
            if(role != null)
            {
                return role;
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

        public async Task<SDTORole> GetRoleWithPermissions(int id)
        {
            var role = await _context.Roles
                .Include(r => r.RoleHasPermissions)
                .ThenInclude(rhp => rhp.Permission)
                .FirstOrDefaultAsync(r => r.Id == id);
            if (role != null)
            {
                SDTORole dtoRole = new()
                {
                    Id = role.Id,
                    Name = role.RoleName,
                    Status = role.Status,
                    RoleHasPermissions = role.RoleHasPermissions.Select(rhp => new SDTORoleHasPermission
                    {
                        Id = rhp.PermissionId,
                        Name = rhp.Permission.PermissionName
                    }).ToList(),
                };
                return dtoRole;
            }
            throw new Exception("The role does not exist !");
        }

        public async Task<SDTORole> AddPermission(int roleId, int permissionId)
        {
            var role = await _context.Roles
                .Include(r => r.RoleHasPermissions)
                .FirstOrDefaultAsync(r => r.Id == roleId);

            if (role != null)
            {
                // Thêm mới
                var roleHasPermission = new RoleHasPermission
                {
                    RoleId = roleId,
                    PermissionId = permissionId
                };

                role.RoleHasPermissions.Add(roleHasPermission);

                await _context.SaveChangesAsync();

                SDTORole dtoRole = new()
                {
                    Id = role.Id,
                    Name = role.RoleName,
                    Status = role.Status,
                    RoleHasPermissions = role.RoleHasPermissions.Select(rhp => new SDTORoleHasPermission
                    {
                        Id = rhp.PermissionId,
                        Name = rhp.Permission.PermissionName
                    }).ToList(),
                };
                return dtoRole;
            }
            throw new Exception("The role does not exist !");
        }

        public async Task<IEnumerable<SDTORole>> GetRolesWithPermissions()
        {
            IEnumerable<Role> roles = await _context.Roles
                .Include(r => r.RoleHasPermissions)
                .ThenInclude(rhp => rhp.Permission)
                .ToListAsync();

            IEnumerable<SDTORole> dtoRoles = roles.Select(r => new SDTORole
            {
                Id = r.Id,
                Name = r.RoleName,
                Status = r.Status,
                RoleHasPermissions = r.RoleHasPermissions.Select(rhp => new SDTORoleHasPermission
                {
                    Id = rhp.PermissionId,
                    Name = rhp.Permission.PermissionName
                }).ToList(),
            });

            return dtoRoles;
        }

        public async Task DeletePermission(int roleId, int permissionId)
        {
            var rhp = await _context.RoleHasPermissions
            .FirstOrDefaultAsync(rhp => rhp.PermissionId == permissionId && rhp.RoleId == roleId); ;

            if (rhp != null)
            {
                _context.RoleHasPermissions.Remove(rhp);

                await _context.SaveChangesAsync();

                return;
            }

            throw new Exception("The role or permission does not exist !");
        }
    }
}
