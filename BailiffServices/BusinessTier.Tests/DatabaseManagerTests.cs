﻿using BusinessTier.Helpers;

using Common.Entities;

using NUnit.Framework;

namespace BusinessTier.Tests
{
    [TestFixture]
    public class DatabaseManagerTests
    {
        [Test]
        public void GetDebtorInfoTests()
        {
            int debtorId = 15100003;

            DatabaseManager dm = new DatabaseManager();
            DebtorEntity result = dm.GetDebtorInfo(debtorId);

            Assert.IsNotNull(result, "No debtor data has been returned for {0}", debtorId);
            Assert.AreEqual("521906283", result.CRef.Trim()  , "Invalid value returned for CFREF");
            Assert.AreEqual("S737NDR", result.Client.Trim(), "Invalid value returned for CLIENT");
            Assert.AreEqual("E", result.Company.Trim(), "Invalid value returned for COMPANY");
            Assert.AreEqual("3241", result.LiabilityOrderId.Trim(), "Invalid value returned for LIABILITY ORDER ID");
            Assert.AreEqual("15100003", result.Refno.Trim(), "Invalid value returned for REFNO");

            debtorId = 15100052;
            result = dm.GetDebtorInfo(debtorId);

            Assert.IsNotNull(result, "No debtor data has been returned for {0}", debtorId);
            Assert.AreEqual("12510250", result.CRef.Trim(), "Invalid value returned for CFREF");
            Assert.AreEqual("S737CT", result.Client.Trim(), "Invalid value returned for CLIENT");
            Assert.AreEqual("E", result.Company.Trim(), "Invalid value returned for COMPANY");
            Assert.AreEqual("50317", result.LiabilityOrderId.Trim(), "Invalid value returned for LIABILITY ORDER ID");
            Assert.AreEqual("15100052", result.Refno.Trim(), "Invalid value returned for REFNO");
        }
    }
}
