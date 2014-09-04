using System.Runtime.Serialization;

using Common.Attributes;

namespace Common.Entities
{
    [DataContract]
    public class DebtorEntity
    {
        [DataMember, DataField("DF_REFNO")]
        public string Refno { get; set; }
        [DataMember, DataField("DF_CLIENT")]
        public string Client { get; set; }
        [DataMember, DataField("DF_CREF")]
        public string CRef { get; set; }
        [DataMember, DataField("DF_LIAB_ORDERID")]
        public string LiabilityOrderId { get; set; }
        [DataMember, DataField("DF_COMPANY")]
        public string Company { get; set; }
    }
}


