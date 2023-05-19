using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTO
{
    public class TicketDto
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        // Other properties related to ticket

        public int AttractionId { get; set; }
        public AttractionDto Attraction { get; set; }

        public int VisitorId { get; set; }
        public VisitorDto Visitor { get; set; }
    }
}
