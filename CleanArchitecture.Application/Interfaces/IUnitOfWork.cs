
namespace CleanArchitecture.Application.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        IProductRepository Product { get; }
        IBrandRepository Brand { get; }
        IProductTypeRepository ProductType { get; }
        Task<int> SaveChangesAsync();
    }
}
