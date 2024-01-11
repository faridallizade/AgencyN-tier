using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency.CORE.Entities.Base
{
    public class BaseAudiTableEntity:BaseEntity
    {
        public bool isDeleted { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set;}
    }
}
