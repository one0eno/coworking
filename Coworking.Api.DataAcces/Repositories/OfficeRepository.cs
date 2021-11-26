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
    public class OfficeRepository : IOfficeRepository
    {
        private readonly ICoworkingDBContext _coworkingDbContext;
        public OfficeRepository(ICoworkingDBContext coworkingDBContext) {

            _coworkingDbContext = coworkingDBContext;
        }

        public async Task<OfficeEntity> Add(OfficeEntity entity) {

            await _coworkingDbContext.Offices.AddAsync(entity);
            await _coworkingDbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<OfficeEntity> Update(int id, OfficeEntity entity)
        {

            var updateEntity = _coworkingDbContext.Offices.Update(entity);
            await _coworkingDbContext.SaveChangesAsync();

            return updateEntity.Entity;
        }

        public async Task<OfficeEntity> Update(OfficeEntity entity)
        {

            var updateEntity = _coworkingDbContext.Offices.Update(entity);
            await _coworkingDbContext.SaveChangesAsync();

            return updateEntity.Entity;
        }

        public async Task<OfficeEntity> Get(int idEntity)
        {
            ///var entity = _coworkingDbContext.Admins.FirstOrDefaultAsync(o => o.Id == idEntity);
            var entity =await _coworkingDbContext.Offices
                            //.Include(i => i.Office)
                            //.ThenInclude(i => i.Office2Room)
                            .FirstOrDefaultAsync(o => o.Id == idEntity);

            return entity;
        }

        public async Task<OfficeEntity> DeleteAsync(int idEntity)
        {

            var entity = await _coworkingDbContext.Offices.SingleAsync(x => x.Id == idEntity);

            _coworkingDbContext.Offices.Remove(entity);
            await _coworkingDbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<bool> Exist(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<OfficeEntity>> GetAll()
        {
            throw new NotImplementedException();
        }


       
    }
}
