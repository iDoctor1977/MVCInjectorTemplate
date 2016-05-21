using Injector.Data.ADOModel;

namespace Injector.Data.DataLayer
{
    public abstract class AContainer
    {
        private static DataDbContext _container;

        public static DataDbContext GetContainer()
        {
            if (ReferenceEquals(_container, null))
            {
                _container = new DataDbContext();
            }
            return _container;
        }
    }
}
