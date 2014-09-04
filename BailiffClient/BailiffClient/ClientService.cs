using System;
using BailiffClient.ClientService;

namespace BailiffClient
{
    public static class ClientServiceClient
    {
        static ClientClient _clientClient = new ClientClient();

        public static ClientEntity GetClientInfo(string clientid)
        {
            ClientEntity result;
            using (_clientClient = new ClientClient())
            {
                try
                {
                    _clientClient.Open();
                    result = _clientClient.GetClientInfo(clientid);
                }
                catch (Exception)
                {
                    _clientClient.Abort();
                    throw;
                }
                finally
                {
                    _clientClient.Close();
                }
            }
            return result;
        }
    }
}
