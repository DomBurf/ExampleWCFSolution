using System;
using System.Globalization;
using System.ServiceModel;

using BusinessTier.Interfaces;
using BusinessTier.Helpers;

using Common;
using Common.Entities;
using Common.Helpers;
using Common.Enums;

namespace BusinessTier.Services
{
    /// <summary>
    /// Class containing an implementations of the IClient interface
    /// </summary>
    public class ClientService : ServiceBase, IClient
    {
        public ClientEntity GetClientInfo(string clientid)
        {
            ManagerHelper.LoggingManager().LogMessage(string.Format(CultureInfo.InvariantCulture, "{0}.{1}", GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name));

            try
            {
                DatabaseManager dm = new DatabaseManager();
                return dm.GetClientInfo(clientid);
            }
            catch (Exception ex)
            {
                ManagerHelper.LoggingManager().LogException(ex);

                throw new FaultException<UnexpectedServiceFault>(
                    new UnexpectedServiceFault { ErrorMessage = ex.Message }, new FaultReason(string.Format(CultureInfo.InvariantCulture, "{0}", FaultReasons.GetClientInfo)));
            }
        }
    }
}
