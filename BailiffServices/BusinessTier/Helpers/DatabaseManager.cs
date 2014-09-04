using System;

using Common.Entities;
using Common.Helpers;

using DataTier;

namespace BusinessTier.Helpers
{
    /// <summary>
    /// Helper class for managing database calls within the BusinessTier assembly
    /// </summary>
    public class DatabaseManager : ManagerBase
    {
        public DebtorEntity GetDebtorInfo(int debtorId)
        {
            ManagerHelper.LoggingManager().LogMessage(string.Format("{0}.{1}", GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name));

            try
            {
                DebtorData data = new DebtorData();
                DebtorEntity result = data.GetDebtorInfo(debtorId);
                return result;
            }
            catch (Exception ex)
            {
                ManagerHelper.LoggingManager().LogException(ex);
                throw;
            }
        }

        public ClientEntity GetClientInfo(string clientid)
        {
            ManagerHelper.LoggingManager().LogMessage(string.Format("{0}.{1}", GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name));

            try
            {
                ClientData data = new ClientData();
                ClientEntity result = data.GetClientInfo(clientid);
                return result;
            }
            catch (Exception ex)
            {
                ManagerHelper.LoggingManager().LogException(ex);
                throw;
            }
        }
    }
}

