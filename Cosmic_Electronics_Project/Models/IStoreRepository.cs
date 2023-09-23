namespace Cosmic_Electronics_Project.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
    }
}
