using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Admin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // Other properties related to admin

        public ICollection<Attraction> Attractions { get; set; }
    }

}
