using NUnit.Framework;

namespace DataTier.Tests
{
    [TestFixture]
    public class DataTierBaseTests
    {
        [Test]
        public void TestConnectionString()
        {
            DataTierBase dataTier = new DataTierBase();
            Assert.IsNotNull(dataTier, "DataTierBase is null");
            Assert.IsNotNullOrEmpty(dataTier.ConnectionString, "DataTierBase.ConnectionString is null or empty");
            Assert.AreEqual(dataTier.ConnectionString, "Data Source=decri-sql\\decri;Initial Catalog=ccs1;Integrated Security=true;", "DataTierBase.ConnectionString is incorrect");
        }
    }
}
