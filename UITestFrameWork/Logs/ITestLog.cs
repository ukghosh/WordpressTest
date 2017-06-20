using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITestFrameWork.Logs
{
  public interface ITestLog
    {
        void Log(string message);
        void Error(string message);
        void Debug(string message);

    }
}
