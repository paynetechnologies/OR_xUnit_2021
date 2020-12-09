using Core.Base;
using Core.Common;
using OR_Modules.Common;
using OR_Modules.Configuration;
using Core.Configuration;
using Core.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Xunit.Abstractions;

namespace OR_AddEditContactModal
{
    public partial class AddEditContactModal : BasePage
    {
        // Unit Test URL
        public override string Url => UrlDeterminer.GetSite(Constants.URL.AddEditContactModal);


        // Unit Test Constructor
        public AddEditContactModal () : base() 
        {
            Open();
            IsPageTitle();
        }

        public AddEditContactModal(BrowserTypes bt) : base(bt) 
        {
            Open();
            IsPageTitle();
        }

        // Integration Test Constructor
        public AddEditContactModal(bool reuse, IWebDriver browser, WebDriverWait browserWait)
             : base(reuse, browser, browserWait) 
        { 
        }

        // Integration Test Constructor
        public AddEditContactModal(bool reuse, IWebDriver browser, WebDriverWait browserWait, ITestOutputHelper output)
             : base(reuse, browser, browserWait)
        {
            Output = output;
            TraceLine = "AddEditContactModal Starting...";
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
