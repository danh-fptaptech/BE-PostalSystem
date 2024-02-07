using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Security;
using TARS_Delivery.Models;
using TARS_Delivery.Models.DTOs;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Repositories.imp
{
    public class RoleRepository : IRoleRepository
    {
        private readonly DatabaseContext databaseContext;
        private readonly IMapper mapper;
        public RoleRepository(DatabaseContext databaseContext, IMapper mapper)
        {
            this.databaseContext = databaseContext;
            this.mapper = mapper;
        }


        public async Task<IEnumerable<Role>> GetRoles()
        {
            return await databaseContext.Roles.ToListAsync();
        }


        public async Task<Role> GetRole(int id)
        {
            var role = await databaseContext.Roles.FindAsync(id);
            if(role != null) 
            {
                return role;
            }
            return null;
        }


        public async Task<Role> Create(Role RolePost)
        {
            var duplicatedRole = await databaseContext.Roles.FirstOrDefaultAsync(r => r.RoleName == RolePost.RoleName );
            if (duplicatedRole != null)
            {
                throw new InvalidOperationException("Role name already exists.");
            }

            Role role = mapper.Map<Role>(RolePost);
            await databaseContext.Roles.AddAsync(role);
            await databaseContext.SaveChangesAsync();

            return role;
        }

        

        //public async Task<Role> Update(Role role)
        //{
        //    databaseContext.Roles.Update(role);
        //    await databaseContext.SaveChangesAsync();
        //    return role;

        //}
    }
}
