using Common.Entities;

using NUnit.Framework;

namespace Common.Tests
{
    [TestFixture]
    public class DebtorEntityTests
    {
        [Test]
        public void TestDebtorEntity()
        {
            DebtorEntity debtorEntity = new DebtorEntity();

            Assert.IsNotNull(debtorEntity, "Invalid DebtorEntity returned");

            debtorEntity.CRef = "CREF";
            debtorEntity.Client = "CLIENT";
            debtorEntity.Company = "Equita";
            debtorEntity.LiabilityOrderId = "123456";
            debtorEntity.Refno = "REFNO";

            Assert.AreEqual("CREF", debtorEntity.CRef, "Invalid value returned for DebtorEntity.CRef");
            Assert.AreEqual("CLIENT", debtorEntity.Client, "Invalid value returned for DebtorEntity.Client");
            Assert.AreEqual("Equita", debtorEntity.Company, "Invalid value returned for DebtorEntity.Company");
            Assert.AreEqual("123456", debtorEntity.LiabilityOrderId, "Invalid value returned for DebtorEntity.LiabilityOrderId");
            Assert.AreEqual("REFNO", debtorEntity.Refno, "Invalid value returned for DebtorEntity.Refno");
        }
    }
}
