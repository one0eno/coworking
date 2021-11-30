using Coworking.Api.DataAcces.Contracts;
using Coworking.Api.DataAcces.Contracts.Entities;
using Coworking.Api.DataAcces.Contracts.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.DataAcces.Repositories
{
    public class AdminRepository: IAdminRepository
    {
        private readonly ICoworkingDBContext _coworkingDbContext;
        public AdminRepository(ICoworkingDBContext coworkingDBContext) {

            _coworkingDbContext = coworkingDBContext;
        }

        public async Task<AdminEntity> Add(AdminEntity entity) {

            await _coworkingDbContext.Admins.AddAsync(entity);
            await _coworkingDbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<AdminEntity> Update(int id, AdminEntity entity)
        {

            var updateEntity = _coworkingDbContext.Admins.Update(entity);
            await _coworkingDbContext.SaveChangesAsync();

            return updateEntity.Entity;
        }

        public async Task<AdminEntity> Update(AdminEntity entity)
        {

            var updateEntity = _coworkingDbContext.Admins.Update(entity);
            await _coworkingDbContext.SaveChangesAsync();

            return updateEntity.Entity;
        }

        public async Task<AdminEntity> Get(int idEntity)
        {
            ///var entity = _coworkingDbContext.Admins.FirstOrDefaultAsync(o => o.Id == idEntity);
            var entity =await _coworkingDbContext.Admins
                            .Include(i => i.Office)
                            //.ThenInclude(i => i.Office2Room)
                            .FirstOrDefaultAsync(o => o.Id == idEntity);

            return entity;
        }

        public async Task<AdminEntity> DeleteAsync(int idEntity)
        {

            var entity = await _coworkingDbContext.Admins.SingleAsync(x => x.Id == idEntity);

            _coworkingDbContext.Admins.Remove(entity);
            await _coworkingDbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<bool> Exist(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<AdminEntity>> GetAll()
        {
            return _coworkingDbContext.Admins;
        }
    }
}
