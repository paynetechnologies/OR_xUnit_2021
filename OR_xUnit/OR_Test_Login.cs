using Core.Common;
using OR_Login;
using System.Reflection;
using Xunit;
using Xunit.Abstractions;

namespace OR_xUnit
{
    public class OR_Test_Login : Trace_Utilities
    {

        public OR_Test_Login(ITestOutputHelper output)
        {
            Output = output;
        }
     
        [Fact]
        public void OR_Login_Test()
        {
            PrintCurrentMethod(MethodBase.GetCurrentMethod());

            // Arrange
            // Login 
            //using (var login = new Login())
            using (var driver = new Login(Output))
            {
                
            }
        }
    }
}