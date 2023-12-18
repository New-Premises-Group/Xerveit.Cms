using Xerveit.Core.Common;

namespace Xerveit.Core.Interfaces.Payloads
{
    public interface IPayloadFactory
    {
        public int TotalObjectsCreated { get; }
        public IResponsePayload GetResponsePayload(PAYLOAD_TYPE type);
    }
}
