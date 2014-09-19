using System;
using System.Globalization;
using System.IO;
using System.Xml.Linq;

namespace Common.Helpers
{
    /// <summary>
    /// Base class for all Helper classes.
    /// Implements the IDisposable interface because it manages the dispsable field _errorlog of type TextWriter.
    /// </summary>
    public class ManagerBase : IDisposable
    {
        private TextWriter _errorLog;
        private string _tempFolder;

        protected void LogError(Exception ex)
        {
            ManagerHelper.LoggingManager().LogMessage(string.Format(CultureInfo.InvariantCulture, "{0}.{1}", GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name));

            if (ex == null) return;
            XElement xmlException = ErrorToXml(ex);
            if (xmlException == null) return;
            if (_errorLog == null)
            {
                SetupErrorLog();
            }
            if (_errorLog != null) _errorLog.WriteLine(xmlException.ToString());
        }

        private XElement ErrorToXml(Exception ex)
        {
            ManagerHelper.LoggingManager().LogMessage(string.Format(CultureInfo.InvariantCulture, "{0}.{1}", GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name));
            
            XElement xmlException = new XElement("ERROR",
                                             new XElement("MESSAGE", ex.Message),
                                             new XElement("SOURCE", ex.Source),
                                             new XElement("TARGET", ex.TargetSite.ToString()),
                                             new XElement("INNEREXCEPTION", ex.InnerException),
                                             new XElement("STACK", ex.StackTrace));

            return xmlException;
        }

        private void SetupErrorLog()
        {
            _tempFolder = GetTempFolder();
           string filename = ManagerHelper.AppSettingsManager().GetAppSettingsValue("ErrorLog");
            _errorLog = new StreamWriter(Path.Combine(_tempFolder, filename), true);
        }

        protected string GetTempFolder()
        {
            if (string.IsNullOrEmpty(_tempFolder))
            {
                _tempFolder = Path.GetTempPath();
            }
            return _tempFolder;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                //dispose managed resources
                _errorLog.Close();
            }
        }
    }
}