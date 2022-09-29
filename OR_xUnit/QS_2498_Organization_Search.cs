using Core.Common;
using OR_Login;
using OR_Modules.Model;
using OR_Modules.Organization;
using Shouldly;
using System.Reflection;
using Xunit;
using Xunit.Abstractions;

namespace OR_xUnit
{
    public partial class QS_2548_Organization_Search_Test : Trace_Utilities
    {
        // Classes under Test
        public Organization Organization { get; private set; }

        // Test Data from JSON Config File
        public QS_2498_Organization_TestData_Model TestData { get; set; } = new QS_2498_Organization_TestData_Model();

        public QS_2548_Organization_Search_Test(ITestOutputHelper output)
        {
            Output = output;
        }

        [Fact]
        public void QS_2548_Organization_Search()
        {
            PrintCurrentMethod(MethodBase.GetCurrentMethod());

            // Arrange
            using (var driver = new Login(Output))
            {
                // Arrange
                Organization = new Organization(true, driver.Browser, driver.BrowserWait, Output);
                Organization.SetSearchParameters(TestData.OrganizationName);

                // Act
                Organization.SearchButton.Click();

                var returnValue = Organization.OrganizationSearchResults(TestData.OrganizationName);

                if (returnValue)
                {
                    // Assert Equal
                    Organization.Organization_Name_Value.ShouldBe(TestData.OrganizationName);
                    TraceLine = "Finished";
                    return;
                }
            }
            TraceFailed.ShouldBe(TestData.OrganizationName);
        }
    }
}
