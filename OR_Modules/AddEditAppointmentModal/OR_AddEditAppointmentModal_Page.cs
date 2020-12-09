using Core.Base;
using Core.Common;
using OR_Modules.Common;
using OR_Modules.Configuration;
using Core.Configuration;
using Core.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Xunit.Abstractions;

namespace OR_AddEditAppointmentModal
{
    public partial class AddEditAppointmentModal : BasePage
    {
        // Unit Test URL
        public override string Url => UrlDeterminer.GetSite(Constants.URL.AddEditAppointmentModal);


        // Unit Test Constructor
        public AddEditAppointmentModal () : base() 
        {
            Open();
            IsPageTitle();
        }

        public AddEditAppointmentModal(BrowserTypes bt) : base(bt) 
        {
            Open();
            IsPageTitle();
        }

        // Integration Test Constructor
        public AddEditAppointmentModal(bool reuse, IWebDriver browser, WebDriverWait browserWait)
             : base(reuse, browser, browserWait) 
        { 
        }

        // Integration Test Constructor
        public AddEditAppointmentModal(bool reuse, IWebDriver browser, WebDriverWait browserWait, ITestOutputHelper output)
             : base(reuse, browser, browserWait)
        {
            Output = output;
            TraceLine = "AddEditAppointmentModal Starting...";
            if (reuse) Open(); // Modals opened by switch frame
            WaitForPinwheel(Core.Common.Constants.PINWHEELOVERLAY);
            //IsPageTitle();
        }

        

        public void IsPageTitle()
        {
            // Modals don't have a page title
            return;
        }
        
    }
}
