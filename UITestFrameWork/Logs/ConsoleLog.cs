using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITestFrameWork.Logs
{
    public class ConsoleLog : ITestLog
    {
        public void Debug(string message)
        {
            Console.WriteLine(message);
        }

        public void Error(string message)
        {
            Console.WriteLine(message);
        }

        public void Log(string message)
        {
            System.Console.WriteLine(message);
        }
    }
}
