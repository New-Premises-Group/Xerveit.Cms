namespace Xerveit.Core.Interfaces.Payloads
{
    public interface IResponsePayload
    {
        string Message { get; }
        string GetDetail(string detail);
    }
}
