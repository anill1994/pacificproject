using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace PacificProject.Models
{
    public class PacificContext:DbContext
    {
        public PacificContext(DbContextOptions<PacificContext> options)
            :base(options)
        {

        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Contact> Contacts { get; set; }


    }
}
