using Core.Base;
using Core.Common;
using Core.Configuration;
using Core.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OR_Modules.Common;
using OR_Modules.Configuration;
using Shouldly;
using System.Reflection;
using Xunit.Abstractions;

namespace OR_Manage_Security_Groups
{
    public partial class Manage_Security_Groups : BasePage
    {
        // Unit Test URL
        public override string Url => UrlDeterminer.GetSite(Constants.URL.Manage_Security_Groups);


        // Unit Test Constructor
        public Manage_Security_Groups () : base() 
        {
            Open();
            IsPageLoaded();
        }

        public Manage_Security_Groups(BrowserTypes bt) : base(bt) 
        {
            Open();
            IsPageLoaded();
        }

        // Integration Test Constructor
        public Manage_Security_Groups(bool reuse, IWebDriver browser, WebDriverWait browserWait)
             : base(reuse, browser, browserWait) 
        { 
        }

        // Integration Test Constructor
        public Manage_Security_Groups(bool reuse, IWebDriver browser, WebDriverWait browserWait, ITestOutputHelper output)
             : base(reuse, browser, browserWait)
        {
            Output = output;
            TraceLine = "Manage_Security_Groups Starting...";
            if (reuse) Open();
            WaitForPinwheel(Core.Common.Constants.PINWHEELOVERLAY);
            IsPageLoaded();
        }

        

        public bool IsPageLoaded()
        {
            TraceLine = "if (!IsPageTitle(Constants.TITLE.Manage_Security_Groups))";
            if (IsPageTitle(Constants.TITLE.Manage_Security_Groups))
            {
                return true;
            }
            TraceFailed.ShouldBe(TraceLine);
            return false;
        }
        
    }
}
