using System.Runtime.Serialization;

using Common.Attributes;

namespace Common.Entities
{
    [DataContract]
    public class ClientEntity
    {
        [DataMember, DataField("CF_REF")]
        public string Refno { get; set; }
        [DataMember, DataField("CF_NAME")]
        public string Name { get; set; }
        [DataMember, DataField("CF_CONTACT")]
        public string Contact { get; set; }
        [DataMember, DataField("CF_PC")]
        public string Postcode { get; set; }
        [DataMember, DataField("CF_ADDR")]
        public string Address { get; set; }
    }
}
