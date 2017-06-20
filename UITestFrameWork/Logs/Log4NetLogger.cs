using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITestFrameWork.Logs
{
    public class Log4NetLogger : ITestLog
    {
        private readonly ILog Logger;

        public Log4NetLogger()
        {
            Logger = LogManager.GetLogger(typeof(Log4NetLogger));
        }

        public void Debug(string message)
        {
            Logger.Debug(message);
        }

        public void Error(string message)
        {
            throw new NotImplementedException();
        }

        public void Log(string message)
        {
            Logger.Info(message);
        }
    }
}
