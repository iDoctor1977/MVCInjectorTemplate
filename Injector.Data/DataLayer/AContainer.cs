using Injector.Data.ADOModel;

namespace Injector.Data.DataLayer
{
    public abstract class AContainer
    {
        private static DataDbContext container;

        public static DataDbContext GetContainer()
        {
            if (container == null)
            {
                container = new DataDbContext();
            }
            return container;
        }
    }
}
