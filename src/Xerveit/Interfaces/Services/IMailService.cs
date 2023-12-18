namespace Xerveit.Core.Interfaces.Services
{
    public interface IMailService
    {
        Task Send<TPayload>(string receiverEmail, string name, ICollection<TPayload> orderItems, decimal total);
    }
}
