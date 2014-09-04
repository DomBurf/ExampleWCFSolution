using System.ServiceModel;

using Common;
using Common.Entities;

namespace BusinessTier.Interfaces
{
    /// <summary>
    /// Definitions for the IDebtor interface
    /// </summary>

    [ServiceContract]
    public interface IDebtor
    {
        [OperationContract, FaultContract(typeof(UnexpectedServiceFault))]
        DebtorEntity GetDebtorInfo(int debtorId);
    }
}
