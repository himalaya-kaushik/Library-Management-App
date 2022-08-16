using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace LMSApp.Models
{
    public partial class LMSContext : DbContext
    {
        

        public LMSContext(DbContextOptions<LMSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<LendRequest> LendRequests { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }

        internal static Task<string> ToListAsync()
        {
            throw new NotImplementedException();
        }
    }
}
