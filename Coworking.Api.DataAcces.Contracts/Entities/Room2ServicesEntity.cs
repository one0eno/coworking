using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.DataAcces.Contracts.Entities
{
    public class Room2ServicesEntity
    {
        public int IdRoom { get; set; }
        public int IdService { get; set; }

        public virtual RoomEntity Room { get; set; }
        public virtual ServicesEntity Service { get; set; }
    }
}
