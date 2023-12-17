
namespace Core.Interfaces.Services
{
    public interface IMailService
    {
        Task Send(string receiverEmail, string name, ICollection<ItemDto> orderItems, decimal total);
    }
}
