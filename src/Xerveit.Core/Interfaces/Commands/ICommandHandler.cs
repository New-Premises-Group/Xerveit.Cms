
namespace Core.Interfaces.Commands
{
    public interface ICommandHandler
    {
        Task<int> Handle<TRequest>(TRequest request);
        Task Undo();
    }
}
