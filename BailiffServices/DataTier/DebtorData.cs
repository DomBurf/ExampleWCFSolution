using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

using Common;
using Common.Entities;
using Common.Helpers;

namespace DataTier
{
    /// <summary>
    /// Class for handling all debtor related database interactions
    /// </summary>
    public class DebtorData : DataTierBase
    {
        public DebtorEntity GetDebtorInfo(int debtorId)
        {
            ManagerHelper.LoggingManager().LogMessage(string.Format(CultureInfo.InvariantCulture, "{0}.{1}", GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name));

            try
            {
                DebtorEntity result = null;
                SqlConnection connection;
                using (connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    SqlCommand cmd;
                    using (cmd = new SqlCommand("sp_get_debtorinfo", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@DebtorId", debtorId);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            reader.Read();
                            result = ReflectPropertyInfo.ReflectType<DebtorEntity>(reader);
                        }
                    }
                    connection.Close();
                }
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
