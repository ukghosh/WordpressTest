using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITestFrameWork.Reports
{
   public class TestReport
    {
        private StringBuilder stringBuilder = new StringBuilder();
        private string title;
        public void Log(string log)
        {
            stringBuilder.AppendLine(log);
        }


        public void NewTestCase(string name)
        {
            Log($"Test Case:{name}");

        }

        public void NewStep(string name)
        {
            Log($"Test Step:{name}");
        }

        public void Flush()
        {
            System.Console.WriteLine(stringBuilder.ToString());
        }

        public void SetTitle(string testTitle)
        {
            this.title = testTitle;          

        }

        public void Passed()
        {
            Log($"{this.title} Passed");
        }
        public void Failed()
        {
            Log($"{this.title} Failed");
        }
    }
}
