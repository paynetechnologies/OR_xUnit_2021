using System.Reflection;
using Xunit.Abstractions;

namespace Core.Common
{
    public class Trace_Utilities
    {
        public ITestOutputHelper Output { get; set; }
        private string _traceLine;
        private string _traceFailed;
        private string indent="    ";

        public virtual string TraceLine
        {
            get
            {
                return _traceLine;
            }
            set
            {
                _traceLine = value;
                Output.WriteLine(indent + _traceLine);
            }
        }


        public virtual string TraceFailed
        {
            get
            {
                Output.WriteLine(indent + "[*] FAILED " + _traceLine);
                return "[*] FAILED " + _traceLine;
            }
            set
            {
                _traceFailed = "[*] FAILED " + value;
                Output.WriteLine(indent + _traceFailed);
            }
        }

        #region Utilities
        public void PrintCurrentMethod(MethodBase m)
        {
            Output.WriteLine(string.Format("Executing {0}.{1}", m.ReflectedType.Name, m.Name));
        }
        #endregion

    }
}
