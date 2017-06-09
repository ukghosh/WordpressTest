using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITestFrameWork.Reports
{
   public class TestCaseModel
    {

        private readonly List<TestStepModel> _steps = new List<TestStepModel>();
        private int _stepId;
        private Exception _ex;
        public TestStepModel CurrentStep { get; private set; }
        public string TestCaseSubject { get; set; }
        public bool BddStyle { get; private set; }
    

        public TestCaseModel(bool bdd = false)
        {
            this.CurrentStep = null;
            this.BddStyle = bdd;
        }

        public bool Passed
        {
            get
            {
                return (this.CurrentStep != null) && this.CurrentStep.Passed;
            }
        }

        public List<TestStepModel> Steps
        {
            get
            {
                return this._steps;
            }

        } 
        
        public static string ExToCode(Exception ex)            
        {
            if (ex == null)
            {
                return string.Empty;
            }

            var res = new StringBuilder();
            res.AppendFormat("Exception of type '{0}' : {1}", ex.GetType().Name, ex.Message);
            res.AppendLine();

            if (!string.IsNullOrEmpty(ex.StackTrace))
            {
                res.AppendLine(ex.StackTrace);
            }
            if (ex.InnerException != null)
            {
                res.AppendLine(ExToCode(ex.InnerException));
            }
            return res.ToString().Replace("\n", "<br/>");
        }

        public void LowStep(string action, string parmeters)
        {
            if (this.CurrentStep != null)
            {
                this.CurrentStep.LowStep(action, parmeters);
            }
        }
        public void LowStep(Exception ex)
        {
            this._ex = ex;
            if (this.CurrentStep != null)
            {
                this.CurrentStep.LowStep(ex);
            }
        }

        public virtual void NewStep(string action, string expected = "")
        {
            if (this.CurrentStep != null)
            {
                this.CurrentStep.Passed = true;
            }
            this.CurrentStep = new TestStepModel
            {
                Action = action,
                Expected = expected,
                Id = ++this._stepId,
                Passed = false

        };
            this.Steps.Add(this.CurrentStep);
        }

        public void TestPassed(string newstep = null)
        {
            if (this.CurrentStep == null)
            {
                this.NewStep(newstep ?? "TestMethod");
            }
        }
    }

    public class TestStepModel
    {
        private readonly List<LowStepModel> _lowSteps = new List<LowStepModel>();

        public string Action { get; internal set; }
        public string Expected { get; internal set; }
        public bool Passed { get; internal set; }

        public int Id { get; internal set; }

        public List<LowStepModel> LowSteps
        {
            get
            {
                return this._lowSteps;
            }
        }

        public string Result
        {
            get
            {
                return this.Passed ? "Passed" : "Failed";
            }
        }

        public void LowStep(string action, string parmeters)
        {
            this._lowSteps.Add(new LowStepModel { Action = action, Parameters = parmeters});
        }
        public void LowStep(Exception ex)
        {
            this._lowSteps.Add(
                new LowStepModel { Action = "Exception", Parameters = ex.GetType().Name, Code = TestCaseModel.ExToCode(ex) });
        }
    }

    public class LowStepModel
    {
        [DefaultValue("")]
        public string Action { get; internal set; }
        [DefaultValue("")]
        public string Code { get; internal set; }
        [DefaultValue("")]
        public string Parameters { get; internal set; }
    }
}
