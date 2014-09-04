using System;
using System.ServiceModel;

using BailiffClient.DebtorService;
using BailiffClient.ClientService;
using UnexpectedServiceFault = BailiffClient.DebtorService.UnexpectedServiceFault;

namespace BailiffClient
{
    /// <summary>
    /// Simple client to demonstrate how to invoke the WCF bailiff services
    /// </summary>
    class Program
    {
        static void Main()
        {
            try
            {
                DebtorServices();
                ClientServices();

                Console.WriteLine();
                Console.WriteLine("Press <ENTER> to terminate the client");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                DumpExceptionDetails(ex);
                Console.ReadKey();
            }
        }

        private static void ClientServices()
        {
            try
            {
                string clientid = "015186";

                Console.WriteLine("Fetching details from CLIENT service for {0}", clientid);
                ClientEntity ce = ClientServiceClient.GetClientInfo(clientid);
                Console.WriteLine("Address: {0}", ce.Address.Trim());
                Console.WriteLine("Contact: {0}", ce.Contact.Trim());
                Console.WriteLine("Name: {0}", ce.Name.Trim());
                Console.WriteLine("Postcode: {0}", ce.Postcode.Trim());
                Console.WriteLine("Refno: {0}", ce.Refno.Trim());

                Console.WriteLine();

                clientid = "1907";
                Console.WriteLine("Fetching details from CLIENT service for {0}", clientid);
                ce = ClientServiceClient.GetClientInfo(clientid.Trim());
                Console.WriteLine("Address: {0}", ce.Address.Trim());
                Console.WriteLine("Contact: {0}", ce.Contact.Trim());
                Console.WriteLine("Name: {0}", ce.Name.Trim());
                Console.WriteLine("Postcode: {0}", ce.Postcode.Trim());
                Console.WriteLine("Refno: {0}", ce.Refno.Trim());

                Console.WriteLine();
            }
            catch (FaultException<UnexpectedServiceFault> ex)
            {
                Console.WriteLine("Error occurred: {0}", ex.Message);
                Console.WriteLine("service message: {0}", ex.Detail.ErrorMessage);
            }
            catch (CommunicationException ex)
            {
                Console.WriteLine("Communications error occurred: {0}", ex.Message);
            }
            catch (TimeoutException ex)
            {
                Console.WriteLine("Service has timed out");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error has occurred");
                DumpExceptionDetails(ex);
            }
        }
        
        private static void DebtorServices()
        {
            try
            {
                int debtorId = 15100003;

                Console.WriteLine("Fetching details from DEBTOR service for {0}", debtorId);
                DebtorEntity de = DebtorServiceClient.GetDebtorInfo(debtorId);
                Console.WriteLine("CRef: {0}", de.CRef.Trim());
                Console.WriteLine("Client: {0}", de.Client.Trim());
                Console.WriteLine("Company: {0}", de.Company.Trim());
                Console.WriteLine("LiabilityOrderId: {0}", de.LiabilityOrderId.Trim());
                Console.WriteLine("Refno: {0}", de.Refno.Trim());

                Console.WriteLine();

                debtorId = 15100052;

                Console.WriteLine("Fetching details from DEBTOR service for {0}", debtorId);
                de = DebtorServiceClient.GetDebtorInfo(debtorId);
                Console.WriteLine("CRef: {0}", de.CRef.Trim());
                Console.WriteLine("Client: {0}", de.Client.Trim());
                Console.WriteLine("Company: {0}", de.Company.Trim());
                Console.WriteLine("LiabilityOrderId: {0}", de.LiabilityOrderId.Trim());
                Console.WriteLine("Refno: {0}", de.Refno.Trim());

                Console.WriteLine();
            }
            catch (FaultException<UnexpectedServiceFault> ex)
            {
                Console.WriteLine("Error occurred: {0}", ex.Message);
                Console.WriteLine("service message: {0}", ex.Detail.ErrorMessage);
            }
            catch (CommunicationException ex)
            {
                Console.WriteLine("Communications error occurred: {0}", ex.Message);
            }
            catch (TimeoutException ex)
            {
                Console.WriteLine("Service has timed out");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error has occurred");
                DumpExceptionDetails(ex);
            }
        }

        private static void DumpExceptionDetails(Exception ex)
        {
            Console.WriteLine("Error occurred:");
            Console.WriteLine("Message: {0}", ex.Message);
            Console.WriteLine("StackTrace {0}", ex.StackTrace);
            Console.WriteLine("TargetSite: {0}", ex.TargetSite);
            Console.WriteLine("Source: {0}", ex.Source);
            if (ex.InnerException != null)
            {
                Console.WriteLine("InnerException: {0}", ex.InnerException);
            }
        }
    }
}
