using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Visitor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // Other properties related to visitor

        public ICollection<Ticket> Tickets { get; set; }
    }
}
