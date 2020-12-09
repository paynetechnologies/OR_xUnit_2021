//using OR_Modules.Common;
//using Core.Driver;
//using Core.Model;
//using OR_Login;
//using OR_ManageLoans;
//using OR_Task_CreditReportModal;
//using OR_Task_Summary;
//using System.Reflection;
//using Xunit;
//using Xunit.Abstractions;
//using $rootnamespace$;

//namespace OR_xUnit
//{
//    /// <summary>
//    ///   Problem Title:    
//    ///   Module:           
//    ///   Severity:         
//    ///   Problem Description:
//    ///     Name of Person who Reported Defect: 
//    ///     User Role: 
//    ///     Steps To Reproduce:
//    ///         1. 
//    ///         2. 
//    ///         3. 
//    ///         4. 
//    ///
//    ///     Expected Result:
//    ///         
//    ///     Actual Result:
//    ///         
//    /// </summary>


//    public partial class $safeitemname$_Test  : Trace_Utilities
//    {
//        // Classes under Test
//        public ManageLoans ManageLoans { get; private set; }



//        // Test Data from JSON Config File
//        public $safeitemname$_TestData_Model TestData { get; set; } = new $safeitemname$_TestData_Model();

//        public $safeitemname$_Test(ITestOutputHelper output)
//        {
//            Output = output;
//        }

//        [Theory]
//        [InlineData(@"Finance Update")]
//        public void $safeitemname$_Theory(string inlinedata)
//        {
//            PrintCurrentMethod(MethodBase.GetCurrentMethod());

//            // Arrange
//            using (var driver = new Login(Output))
//            {
//                // Arrange

//                // Act

//                // Assert

//            }
//        }

//        [Fact]
//        public void $safeitemname$_Fact()
//        {
//            PrintCurrentMethod(MethodBase.GetCurrentMethod());

//            // Arrange
//            using (var driver = new Login(Output))
//            {
//                // Arrange

//                // Act

//                // Assert

//            }
//        }
//    }
//}

