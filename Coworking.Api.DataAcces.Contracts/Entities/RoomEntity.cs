using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.DataAcces.Contracts.Entities
{
    public class RoomEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Capacity { get; set; }

        public virtual ICollection<Offices2RoomEntity> Office2Room { get; set; }
        public virtual ICollection<Room2ServicesEntity> Room { get; set; }

    }
}
