using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.DataAcces.Contracts.Entities
{
    public class Offices2RoomEntity
    {
        public int OfficeId { get; set; }

        public int RoomId { get; set; }


        public virtual OfficeEntity Office { get; set; }
        public virtual RoomEntity Room { get; set; }

    }
}
