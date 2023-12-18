namespace Xerveit.Core.Interfaces.Services
{
    public interface IMediator
    {
        Task<int> Send<TRequest>(TRequest request);
    }
}
