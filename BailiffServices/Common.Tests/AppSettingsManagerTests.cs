using Common;
using Common.Helpers;

using NUnit.Framework;

namespace Common.Tests
{
    [TestFixture]
    public class AppSettingsManagerTests
    {
        [Test]
        public void ReadValuesTests()
        {
            Assert.AreEqual("bailiffservices_Error.log", ManagerHelper.AppSettingsManager().GetAppSettingsValue("ErrorLog"), "Invalid value returned for 'ErrorLog'");
            Assert.AreEqual("bailiffservices_Info.log", ManagerHelper.AppSettingsManager().GetAppSettingsValue("InfoLog"), "Invalid value returned for 'InfoLog'");
        }
    }
}
