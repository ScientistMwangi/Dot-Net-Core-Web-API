using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5_api.Entities.Auth;

namespace WebApplication5_api.Entities
{
    public class MyAppContext : IdentityDbContext<User, Role, Guid>
    {
        public MyAppContext()
        {

        }
        public MyAppContext(DbContextOptions<MyAppContext> options)
            : base(options)
        { }

        public DbSet<Music> Musics { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
