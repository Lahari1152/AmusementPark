using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Data.DataFolder
{
    public class AmusementParkDbContext : DbContext
    {

        public AmusementParkDbContext(DbContextOptions<AmusementParkDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Attraction> Attractions { get; set; }
        public DbSet<Visitor>Visitors { get; set; }
        public DbSet<Ticket>Tickets { get; set; }

       
    }
} 

   