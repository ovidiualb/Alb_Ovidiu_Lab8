using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Alb_Ovidiu_Lab8.Models;

namespace Alb_Ovidiu_Lab8.Data
{
    public class Alb_Ovidiu_Lab8Context : DbContext
    {
        public Alb_Ovidiu_Lab8Context (DbContextOptions<Alb_Ovidiu_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Alb_Ovidiu_Lab8.Models.Book> Book { get; set; }

        public DbSet<Alb_Ovidiu_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Alb_Ovidiu_Lab8.Models.Category> Category { get; set; }
    }
}
