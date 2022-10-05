using Microsoft.EntityFrameworkCore;
using PurpleBuzzLast.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PurpleBuzzLast.Data
{
    public class AppDbContext: DbContext
    {


        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }

        public DbSet<SliderImage> SliderImages { get; set; }
        public DbSet<SliderSide> SliderSides { get; set; }
    }
}
