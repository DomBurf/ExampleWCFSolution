using System;
using System.Configuration;
using System.ServiceModel;
using System.ServiceModel.Description;

using BusinessTier.Interfaces;
using BusinessTier.Services;

namespace BailiffHost
{
    /// <summary>
    /// Very simple WCF host impemented as a self-hosting console application.
    /// In a production environment this should be hosted under IIS.
    /// Ideal for development testing. 
    /// </summary>
    class Program
    {
        static void Main()
        {
            try
            {
                //Setup the endpoints for the services. 
                //N.B. You can only have one service per endpoint.

                string configFile = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;
                Console.WriteLine("Configuration information being read from {0}", configFile);
                Console.WriteLine();

                //
                // DEBTOR SERVICE
                //

                //create a URI to serve as the address
                string debtorAddress = ConfigurationManager.AppSettings["DebtorServices"];
                Uri debtorBaseAddress = new Uri(debtorAddress);

                Console.WriteLine("Starting DebtorService service...");
                ServiceHost debtorHost = DebtorServicesHost(debtorBaseAddress);

                //start the service
                debtorHost.Open();

                //
                //CLIENT SERVICE
                //

                //create a URI to serve as the address
                string clientAddress = ConfigurationManager.AppSettings["ClientServices"];
                Uri clientBaseAddress = new Uri(clientAddress);

                Console.WriteLine("Starting ClientService service...");
                ServiceHost clientHost = ClientServicesHost(clientBaseAddress);

                //start the service
                clientHost.Open();

                Console.WriteLine();
                Console.WriteLine("The services are ready");
                Console.WriteLine("Debtor Service URI: {0}", debtorAddress);
                Console.WriteLine("Client Service URI: {0}", clientAddress);
                Console.WriteLine("Press <ENTER> to terminate the services");
                Console.ReadLine();

                //close the services
                debtorHost.Close();
                clientHost.Close();
            }
            catch (CommunicationException ex)
            {
                Console.WriteLine("Communication error occurred: {0}", ex.Message);
                Console.ReadLine();
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred: {0}", ex.Message);
                Console.ReadLine();
                throw;
            }
        }

        private static ServiceHost DebtorServicesHost(Uri baseAddress)
        {
            ServiceHost debtorHost = new ServiceHost(typeof(DebtorService), baseAddress);
            //add the service endpoint
            debtorHost.AddServiceEndpoint(typeof(IDebtor), new WSHttpBinding(), "DebtorServices");

            //enable metadata exchange
            ServiceMetadataBehavior smb = new ServiceMetadataBehavior { HttpGetEnabled = true };
            debtorHost.Description.Behaviors.Add(smb);

            return debtorHost;
        }

        private static ServiceHost ClientServicesHost(Uri baseAddress)
        {
            ServiceHost clientHost = new ServiceHost(typeof(ClientService), baseAddress);
            //add the service endpoint
            clientHost.AddServiceEndpoint(typeof(IClient), new WSHttpBinding(), "ClientServices");

            //enable metadata exchange
            ServiceMetadataBehavior smb = new ServiceMetadataBehavior { HttpGetEnabled = true };
            clientHost.Description.Behaviors.Add(smb);

            return clientHost;
        }
    }
}
