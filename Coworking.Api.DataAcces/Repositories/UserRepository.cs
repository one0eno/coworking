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
    public class UserRepository : IUserRepository
    {
        private readonly ICoworkingDBContext _coworkingDbContext;
        public UserRepository(ICoworkingDBContext coworkingDBContext) {

            _coworkingDbContext = coworkingDBContext;
        }

        public async Task<UserEntity> Add(UserEntity entity) {

            await _coworkingDbContext.Users.AddAsync(entity);
            await _coworkingDbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<UserEntity> Update(int id, UserEntity entity)
        {

            var updateEntity = _coworkingDbContext.Users.Update(entity);
            await _coworkingDbContext.SaveChangesAsync();

            return updateEntity.Entity;
        }

        public async Task<UserEntity> Update(UserEntity entity)
        {

            var updateEntity = _coworkingDbContext.Users.Update(entity);
            await _coworkingDbContext.SaveChangesAsync();

            return updateEntity.Entity;
        }

        public async Task<UserEntity> Get(int idEntity)
        {
            ///var entity = _coworkingDbContext.Admins.FirstOrDefaultAsync(o => o.Id == idEntity);
            var entity =await _coworkingDbContext.Users
                            //.Include(i => i.Office)
                            //.ThenInclude(i => i.Office2Room)
                            .FirstOrDefaultAsync(o => o.Id == idEntity);

            return entity;
        }

        public async Task<UserEntity> DeleteAsync(int idEntity)
        {

            var entity = await _coworkingDbContext.Users.SingleAsync(x => x.Id == idEntity);

            _coworkingDbContext.Users.Remove(entity);
            await _coworkingDbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<bool> Exist(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<UserEntity>> GetAll()

        {
            throw new NotImplementedException();
        }


       
    }
}
