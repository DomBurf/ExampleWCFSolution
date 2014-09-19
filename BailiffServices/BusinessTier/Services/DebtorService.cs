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
    /// Class containing an implementations of the IDebtor interface
    /// </summary>
    public class DebtorService : ServiceBase, IDebtor
    {
        public DebtorEntity GetDebtorInfo(int debtorId)
        {
            ManagerHelper.LoggingManager().LogMessage(string.Format(CultureInfo.InvariantCulture, "{0}.{1}", GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name));

            try
            {
                DatabaseManager dm = new DatabaseManager();
                return dm.GetDebtorInfo(debtorId);
            }
            catch (Exception ex)
            {
                ManagerHelper.LoggingManager().LogException(ex);

                throw new FaultException<UnexpectedServiceFault>(
                    new UnexpectedServiceFault { ErrorMessage = ex.Message }, new FaultReason(string.Format(CultureInfo.InvariantCulture, "{0}", FaultReasons.GetDebtorInfo)));
            }
        }
    }
}
