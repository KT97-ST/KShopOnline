using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Models.Framework
{
    public partial class KShopDBContext : DbContext
    {
        public KShopDBContext()
            : base("name=KShopDBContext")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.account_username)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.account_password)
                .IsUnicode(false);
        }
    }
}
