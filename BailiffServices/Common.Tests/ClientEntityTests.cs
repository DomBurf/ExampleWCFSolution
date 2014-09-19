using Common.Entities;

using NUnit.Framework;

namespace Common.Tests
{
    [TestFixture]
    public class ClientEntityTests
    {
        [Test]
        public void TestClientEntity()
        {
            ClientEntity clientEntity = new ClientEntity();

            Assert.IsNotNull(clientEntity, "Invalid ClientEntity returned");

            clientEntity.Address = "1 High Street";
            clientEntity.Contact = "Mr John Smith";
            clientEntity.Name = "Mr Test Client";
            clientEntity.Postcode = "NN88 1BX";
            clientEntity.Refno = "REFNO";

            Assert.AreEqual("1 High Street", clientEntity.Address, "Invalid value returned for ClientEntity.Address");
            Assert.AreEqual("Mr John Smith", clientEntity.Contact, "Invalid value returned for ClientEntity.Contact");
            Assert.AreEqual("Mr Test Client", clientEntity.Name, "Invalid value returned for ClientEntity.Name");
            Assert.AreEqual("NN88 1BX", clientEntity.Postcode, "Invalid value returned for ClientEntity.Postcode");
            Assert.AreEqual("REFNO", clientEntity.Refno, "Invalid value returned for ClientEntity.Refno");
        }
    }
}
