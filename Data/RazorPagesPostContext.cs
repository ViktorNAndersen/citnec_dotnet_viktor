using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesPlayground.Models;

namespace RazorPagesPlayground.Data
{
    public class RazorPagesPostContext : DbContext
    {
        public RazorPagesPostContext (DbContextOptions<RazorPagesPostContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesPlayground.Models.Post> Post { get; set; } = default!;
    }
}
