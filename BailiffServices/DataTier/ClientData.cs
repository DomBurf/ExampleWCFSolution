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
    /// Class for handling all client related database interactions
    /// </summary>
    public class ClientData : DataTierBase
    {
        public ClientEntity GetClientInfo(string clientid)
        {
            ManagerHelper.LoggingManager().LogMessage(string.Format(CultureInfo.InvariantCulture, "{0}.{1}", GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name));

            try
            {
                ClientEntity result = null;
                SqlConnection connection;
                using (connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    SqlCommand cmd;
                    using (cmd = new SqlCommand("sp_get_clientinfo", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ClientId", clientid);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            reader.Read();
                            result = ReflectPropertyInfo.ReflectType<ClientEntity>(reader);
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
