using System;

namespace BusinessTier.Services
{
    /// <summary>
    /// Base class for all WCF service contracts
    /// </summary>
    public class ServiceBase
    {
        protected string GetExceptionMessage(Exception ex)
        {
            string errorMsg = "Message: " + ex.Message + Environment.NewLine +
                               "StackTrace: " + ex.StackTrace + Environment.NewLine +
                               "Source: " + ex.Source + Environment.NewLine +
                               "TargetSite: " + ex.TargetSite;
            if (ex.InnerException != null)
            {
                errorMsg += Environment.NewLine + ex.InnerException;
            }
            return errorMsg;
        }
    }
}
