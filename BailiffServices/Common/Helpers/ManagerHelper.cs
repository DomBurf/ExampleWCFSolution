using System.Diagnostics;

//DB 29/08/2014

//Use the ManagerHelper design pattern to write loosely coupled code.
//Make as much use of this design pattern as possible as it aids in the development of unit-testing friendly code.
//
//To use the pattern do the following:
//1. Create a new public Helper class e.g. MyClassHelper in the Helpers folder
//2. Inherit your new class from the ManagerBase class and add it to the Common.Helpers namespace
//3. Implement your functionaliry as needed
//4. Add a new private static instance of your class to ManagerHelper 
//5. Add a public Singleton constructor thus ensuring that all calls to your class are rooted through ManagerHelper
//6. You invoke your new class functionality as follows: ManagerHelper.MyHelper().MyFunction()

//For example here is how the ConnectionManager is invoked:
//result = ManagerHelper.DatabaseManager().GeDebtorInfo();

namespace Common.Helpers
{
    public class ManagerHelper
    {
        private static LoggingManager _loggingManager;
        private static AppSettingsManager _appSettings;
        
        /// <summary>
        /// Constructor marked as private to inhibit instance creation
        /// </summary>
        private ManagerHelper()
        {
            
        }

        [DebuggerStepThrough]
        public static LoggingManager LoggingManager()
        {
            if (_loggingManager == null)
            {
                _loggingManager = new LoggingManager();
            }
            return _loggingManager;
        }

        [DebuggerStepThrough]
        public static AppSettingsManager AppSettingsManager()
        {
            if (_appSettings == null)
            {
                _appSettings = new AppSettingsManager();
            }
            return _appSettings;
        }
    }
}