using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.DataAcces.Contracts.Entities
{
    public class OfficeEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string IdAdmin { get; set; }
        public bool HasIndividualWorkSpace{ get; set; }
        public int NumberWorkSpaces { get; set; }
        public decimal PriceWorkSpaceDaily { get; set; }
        public decimal PriceWorkSpaceMonthly { get; set; }


        //public virtual AdminEntity Admin { get; set; }
        public virtual ICollection<Offices2RoomEntity> Office2Room { get; set; }

        public virtual BookingEntity Booking { get; set; }

    }
}
