using Common.Entities;

using NUnit.Framework;

namespace DataTier.Tests
{
    [TestFixture]
    public class ClientTests
    {
        [Test]
        public void TestClientInfo()
        {
            string clientid = "015186";

            ClientData data = new ClientData();
            ClientEntity result = data.GetClientInfo(clientid);

            Assert.IsNotNull(result, "No client data has been returned for {0}", clientid);
            Assert.AreEqual("Winston House, 349 Regents Park Road, Finchley, London", result.Address.Trim(), "Invalid value returned for Address");
            Assert.AreEqual("Alan Mays", result.Contact.Trim(), "Invalid value returned for Contact");
            Assert.AreEqual("OSMOND GAUT & ROSE", result.Name.Trim(), "Invalid value returned for Name");
            Assert.AreEqual("N3 1DH", result.Postcode.Trim(), "Invalid value returned for Postcode");
            Assert.AreEqual("015186", result.Refno.Trim(), "Invalid value returned for Refno");

            clientid = "1907";

            data = new ClientData();
            result = data.GetClientInfo(clientid);

            Assert.IsNotNull(result, "No client data has been returned for {0}", clientid);
            Assert.AreEqual("15 DRINKWATER STREET,DOUGLAS,ISLE OF MAN", result.Address.Trim(), "Invalid value returned for Address");
            Assert.AreEqual("M.B.MAJID", result.Contact.Trim(), "Invalid value returned for Contact");
            Assert.AreEqual("REGAL ESTATES LTD", result.Name.Trim(), "Invalid value returned for Name");
            Assert.AreEqual("IM1 1AT", result.Postcode.Trim(), "Invalid value returned for Postcode");
            Assert.AreEqual("1907", result.Refno.Trim(), "Invalid value returned for Refno");
        }
    }
}
