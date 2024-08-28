using BusinessLayer.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public class SampleDbContext:DbContext
    {

        public SampleDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Location> Location { get; set; }



    }
}
