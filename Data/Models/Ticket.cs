using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        // Other properties related to ticket

        public int AttractionId { get; set; }
        public Attraction Attraction { get; set; }

        public int VisitorId { get; set; }
        public Visitor Visitor { get; set; }
    }
}
