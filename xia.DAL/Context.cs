using Microsoft.EntityFrameworkCore;
using System;
using xia.DAL.Models;

namespace xia.DAL
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options): base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }

    }
}
