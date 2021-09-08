using imecappAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace imecappAPI.Data
{
    public class DataContext:IdentityDbContext<User,Role,int>
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Messages>()
                .HasOne(i => i.Sender)
                .WithMany(i => i.MessagesSent)
                .HasForeignKey(i => i.SenderId);

            builder.Entity<Messages>()
                .HasOne(i => i.Recipient)
                .WithMany(i => i.MessagesReceived)
                .HasForeignKey(i => i.RecipientId);

        }
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Messages> Messages { get; set; }
    }
}
