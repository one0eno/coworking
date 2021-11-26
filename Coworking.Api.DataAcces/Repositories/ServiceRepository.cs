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
    public class ServiceRepository : IServiceRepository
    {
        private readonly ICoworkingDBContext _coworkingDbContext;
        public ServiceRepository(ICoworkingDBContext coworkingDBContext) {

            _coworkingDbContext = coworkingDBContext;
        }

        public async Task<ServicesEntity> Add(ServicesEntity entity) {

            await _coworkingDbContext.Services.AddAsync(entity);
            await _coworkingDbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<ServicesEntity> Update(int id, ServicesEntity entity)
        {

            var updateEntity = _coworkingDbContext.Services.Update(entity);
            await _coworkingDbContext.SaveChangesAsync();

            return updateEntity.Entity;
        }

        public async Task<ServicesEntity> Update(ServicesEntity entity)
        {

            var updateEntity = _coworkingDbContext.Services.Update(entity);
            await _coworkingDbContext.SaveChangesAsync();

            return updateEntity.Entity;
        }

        public async Task<ServicesEntity> Get(int idEntity)
        {
            ///var entity = _coworkingDbContext.Admins.FirstOrDefaultAsync(o => o.Id == idEntity);
            var entity =await _coworkingDbContext.Services
                            //.Include(i => i.Office)
                            //.ThenInclude(i => i.Office2Room)
                            .FirstOrDefaultAsync(o => o.Id == idEntity);

            return entity;
        }

        public async Task<ServicesEntity> DeleteAsync(int idEntity)
        {

            var entity = await _coworkingDbContext.Services.SingleAsync(x => x.Id == idEntity);

            _coworkingDbContext.Services.Remove(entity);
            await _coworkingDbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<bool> Exist(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ServicesEntity>> GetAll()

        {
            throw new NotImplementedException();
        }


       
    }
}
