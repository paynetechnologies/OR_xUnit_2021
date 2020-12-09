using Core.Base;
using Core.Common;
using OR_Modules.Common;
using OR_Modules.Configuration;
using Core.Configuration;
using Core.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Xunit.Abstractions;

namespace OR_AddEditOrganization_Modal
{
    public partial class AddEditOrganization_Modal : BasePage
    {
        // Unit Test URL
        public override string Url => UrlDeterminer.GetSite(Constants.URL.AddEditOrganization_Modal);


        // Unit Test Constructor
        public AddEditOrganization_Modal () : base() 
        {
            Open();
            IsPageTitle();
        }

        public AddEditOrganization_Modal(BrowserTypes bt) : base(bt) 
        {
            Open();
            IsPageTitle();
        }

        // Integration Test Constructor
        public AddEditOrganization_Modal(bool reuse, IWebDriver browser, WebDriverWait browserWait)
             : base(reuse, browser, browserWait) 
        { 
        }

        // Integration Test Constructor
        public AddEditOrganization_Modal(bool reuse, IWebDriver browser, WebDriverWait browserWait, ITestOutputHelper output)
             : base(reuse, browser, browserWait)
        {
            Output = output;
            TraceLine = "AddEditOrganization_Modal Starting...";
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
