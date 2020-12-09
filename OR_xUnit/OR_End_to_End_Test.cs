using Core.Common;
using Core.Driver;
using OR_Login;
using Xunit;
using Xunit.Abstractions;

namespace OR_xUnit
{
    public class OR_End_to_End_Test : Trace_Utilities
    {

        public OR_End_to_End_Test(ITestOutputHelper output)
        {
            Output = output;
        }

        [Fact]
        public void Test_OR_Login_to_Reports()
        {
            // using will automatically call Dispose
            using (var driver = new Login(Output))
            {
                bool ready = false;

                WaitFor.WaitForPageLoad();
                ready = driver.WaitForPinwheel(Core.Common.Constants.PINWHEELOVERLAY);

                if (ready)
                {
                    //// ***********************************
                    //// *               Home              *  
                    //// ***********************************
                    //var tilePage = new Home(true, driver.Browser, driver.BrowserWait);

                    //ready = tilePage.WaitForPinwheel(Constants.PINWHEELOVERLAY);

                    //if (ready)
                    //{
                    //    tilePage.ManageLoansTileTileLink.Click();
                    //}
                }

                // ***********************************
                // *         Manage Loans            *  
                // ***********************************
                //_ManageLoans.ClickOnFooter(true, driver.Browser, driver.BrowserWait);
                //_ManageLoans.ClickOnMonitoringActivites(true, driver.Browser, driver.BrowserWait);

                // ***********************************
                // *      Monitoring Activity        *  
                // ***********************************
                WaitFor.WaitForPageLoad();
                //var monitoringActivities = new MonitoringActivities(false, driver.Browser, driver.BrowserWait, Output);
                //ready = monitoringActivities.WaitForPinwheel(Constants.PINWHEELOVERLAY);
                //if (ready)
                //{
                //    monitoringActivities.SetSearchParameters(
                //        OR_Constants.SearchByFieldOptions.ProjectUpdate
                //        ,"Loan Profile Name"
                //        , "Ascending"); 
                //}
            }

        }
    }
}
