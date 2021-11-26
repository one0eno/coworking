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
    public class RoomRepository : IRoomRepository
    {
        private readonly ICoworkingDBContext _coworkingDbContext;
        public RoomRepository(ICoworkingDBContext coworkingDBContext) {

            _coworkingDbContext = coworkingDBContext;
        }

        public async Task<RoomEntity> Add(RoomEntity entity) {

            await _coworkingDbContext.Rooms.AddAsync(entity);
            await _coworkingDbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<RoomEntity> Update(int id, RoomEntity entity)
        {

            var updateEntity = _coworkingDbContext.Rooms.Update(entity);
            await _coworkingDbContext.SaveChangesAsync();

            return updateEntity.Entity;
        }

        public async Task<RoomEntity> Update(RoomEntity entity)
        {

            var updateEntity = _coworkingDbContext.Rooms.Update(entity);
            await _coworkingDbContext.SaveChangesAsync();

            return updateEntity.Entity;
        }

        public async Task<RoomEntity> Get(int idEntity)
        {
            ///var entity = _coworkingDbContext.Admins.FirstOrDefaultAsync(o => o.Id == idEntity);
            var entity =await _coworkingDbContext.Rooms
                            //.Include(i => i.Office)
                            //.ThenInclude(i => i.Office2Room)
                            .FirstOrDefaultAsync(o => o.Id == idEntity);

            return entity;
        }

        public async Task<RoomEntity> DeleteAsync(int idEntity)
        {

            var entity = await _coworkingDbContext.Rooms.SingleAsync(x => x.Id == idEntity);

            _coworkingDbContext.Rooms.Remove(entity);
            await _coworkingDbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<bool> Exist(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<RoomEntity>> GetAll()

        {
            throw new NotImplementedException();
        }


       
    }
}
