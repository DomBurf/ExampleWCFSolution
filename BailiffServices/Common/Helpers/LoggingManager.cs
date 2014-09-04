using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;

namespace Common.Helpers
{
    /// <summary>
    /// Class for writing to the information and error log files
    /// </summary>
    public class LoggingManager : ManagerBase
    {
        private TextWriter _infoLog;
        
        private void SetupInformationLog()
        {
            string filename = ManagerHelper.AppSettingsManager().GetAppSettingsValue("InfoLog");
            if (!string.IsNullOrEmpty(filename))
            {
                _infoLog = new StreamWriter(Path.Combine(GetTempFolder(), filename), true);
            }
        }

        public void LogMessage(string message)
        {
            if (_infoLog == null)
            {
                SetupInformationLog();
            }
            if (_infoLog != null) _infoLog.WriteLine("{0} {1}", DateTime.Now.ToString(CultureInfo.InvariantCulture), message);
        }

        public void LogStackTrace()
        {
            StackTrace st = new StackTrace(true);
            for (int count = 0; count < st.FrameCount; ++count)
            {
                //the 0 stack element is this method which can be excluded
                if (count == 0) continue;
                StackFrame sf = st.GetFrame(count);
                LogMessage(string.Format("Method={0}", sf.GetMethod()));
                LogMessage(string.Format("Filename={0}", sf.GetFileName()));
                LogMessage(string.Format("Linenumber={0}", sf.GetFileLineNumber()));
            }
        }

        public void LogException(Exception ex)
        {
            LogMessage(string.Format("Exception occured at {0}", DateTime.Now.ToString(CultureInfo.InvariantCulture)));
            LogMessage(System.Reflection.MethodBase.GetCurrentMethod().Name);

            LogError(ex);
        }
    }
}
