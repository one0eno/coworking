using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.DataAcces.Contracts.Entities
{
    public class ServicesEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool Active { get; set; }

        public decimal Price { get; set; }

        public virtual ICollection<Room2ServicesEntity> Room { get; set; }
    }
}
