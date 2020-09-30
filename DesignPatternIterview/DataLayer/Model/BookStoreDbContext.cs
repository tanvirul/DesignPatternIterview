using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternIterview.DataLayer.Model
{
    class BookStoreDbContext:DbContext
    {
        public BookStoreDbContext() : base(GlobalDbConnection.Connection)
        {
            Database.SetInitializer<BookStoreDbContext>(null);

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookPrice> BookPrices { get; set; }
        protected override void OnModelCreating(DbModelBuilder dbModelBuilder)
        {
            dbModelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            
        }
    }
}
