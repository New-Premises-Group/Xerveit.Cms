namespace Xerveit.Core.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        // Add your Repository here
        Task<int> CompleteAsync();
    }
}
