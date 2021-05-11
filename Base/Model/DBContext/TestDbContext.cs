using Base.EntityModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Model.DBContext
{
    public class TestDbContext : DbContext
    {
        public TestDbContext()
            : base("test")
        {
            Database.SetInitializer<TestDbContext>(null);
        }

        public DbSet<Account> Account { get; set; }

    }
}
