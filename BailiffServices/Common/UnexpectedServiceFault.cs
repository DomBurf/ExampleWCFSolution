using System.Runtime.Serialization;

namespace Common
{
    /// <summary>
    /// Generic WCF service exception. You should NOT pass .NET exceptions back to the client
    /// as the client may NOT be a .NET application. You should only pass SoapExceptions or types
    /// that are derived from SoapException which are language neutral. 
    /// </summary>

    [DataContract]
    public class UnexpectedServiceFault
    {
        [DataMember]
        public string ErrorMessage { get; set; }
    }
}
