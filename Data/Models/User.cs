using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class User
    {

        public int Id { get; set; }
        public string Name { get; set; }
        // Other properties related to user

        public ICollection<Purchase> Purchases { get; set; }
    }

}
