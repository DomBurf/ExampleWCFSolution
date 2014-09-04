using System.ServiceModel;

using Common;
using Common.Entities;

namespace BusinessTier.Interfaces
{
    /// <summary>
    /// Definitions for the IClient interface
    /// </summary>

    [ServiceContract]
    public interface IClient
    {
        [OperationContract, FaultContract(typeof(UnexpectedServiceFault))]
        ClientEntity GetClientInfo(string clientid);
    }
}
