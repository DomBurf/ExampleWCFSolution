using System;
using BailiffClient.DebtorService;

namespace BailiffClient
{
    public static class DebtorServiceClient
    {
        static DebtorClient _debtorClient = new DebtorClient();
        
        public static DebtorEntity GetDebtorInfo(int debtorId)
        {
            DebtorEntity result;
            using (_debtorClient = new DebtorClient())
            {
                try
                {
                    _debtorClient.Open();
                    result = _debtorClient.GetDebtorInfo(debtorId);
                }
                catch (Exception)
                {
                    _debtorClient.Abort();
                    throw;
                }
                finally
                {
                    _debtorClient.Close();
                }
            }
            return result;
        }
    }
}
