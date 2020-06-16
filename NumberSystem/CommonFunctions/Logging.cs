using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NLog;
using ILogger = NumberSystem.Interfaces.ILogger;

namespace NumberSystem.CommonFunctions
{
    public class MyLogger : ILogger
    {
        #region Instance Creation
        private static MyLogger Instance;
        private static Logger Logger;
        
        private MyLogger()
        {

        }

        public static MyLogger GetInstance()
        {
            if (Instance == null)
            {
                Instance = new MyLogger(); 
            }
            return Instance;
        }

        private Logger GetLogger(string theLogger)
        {
            if (Logger==null)
            {
                Logger = LogManager.GetLogger(theLogger);
            }

            return MyLogger.Logger;
        }
        #endregion

        #region Method Declaration
        public void Debug(string message, string arg = null)
        {
            if (arg==null)
            {
                GetLogger("NumberSystemLogRules").Debug(message);
            }
            else
            {
                GetLogger("NumberSystemLogRules").Debug(message,arg);
            }
        }

        public void Error(string message, string arg = null)
        {
            if (arg == null)
            {
                GetLogger("NumberSystemLogRules").Error(message);
            }
            else
            {
                GetLogger("NumberSystemLogRules").Error(message, arg);
            }
        }

        public void Info(string message, string arg = null)
        {
            if (arg == null)
            {
                GetLogger("NumberSystemLogRules").Info(message);
            }
            else
            {
                GetLogger("NumberSystemLogRules").Info(message, arg);
            }
        }

        public void Warn(string message, string arg = null)
        {
            if (arg == null)
            {
                GetLogger("NumberSystemLogRules").Warn(message);
            }
            else
            {
                GetLogger("NumberSystemLogRules").Warn(message, arg);
            }
        }
        #endregion
    }
}