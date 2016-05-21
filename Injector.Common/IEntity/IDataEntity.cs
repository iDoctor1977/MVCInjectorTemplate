namespace Injector.Common.IEntity
{
    public interface IDataEntity
    {
        int Id { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
    }
}