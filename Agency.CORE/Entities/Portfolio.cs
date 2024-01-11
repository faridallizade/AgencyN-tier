using Agency.CORE.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency.CORE.Entities
{
    public class Portfolio:BaseAudiTableEntity
    {
        public string? ImageUrl { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
    }
}
