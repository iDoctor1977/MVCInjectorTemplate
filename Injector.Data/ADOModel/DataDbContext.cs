using System.Data.Entity;

namespace Injector.Data.ADOModel
{
    public class DataDbContext : DbContext
    {
        public DataDbContext() : base("name=InjectorUnitContainer") { }

        public DbSet<DataEntity> DataEntities { get; set; }
    }
}
