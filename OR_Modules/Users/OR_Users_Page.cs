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

namespace OR_Users
{
    public partial class Users : BasePage
    {
        // Unit Test URL
        public override string Url => UrlDeterminer.GetSite(Constants.URL.Users);


        // Unit Test Constructor
        public Users () : base() 
        {
            Open();
            IsPageLoaded();
        }

        public Users(BrowserTypes bt) : base(bt) 
        {
            Open();
            IsPageLoaded();
        }

        // Integration Test Constructor
        public Users(bool reuse, IWebDriver browser, WebDriverWait browserWait)
             : base(reuse, browser, browserWait) 
        { 
        }

        // Integration Test Constructor
        public Users(bool reuse, IWebDriver browser, WebDriverWait browserWait, ITestOutputHelper output)
             : base(reuse, browser, browserWait)
        {
            Output = output;
            TraceLine = "Users Starting...";
            if (reuse) Open();
            WaitForPinwheel(Core.Common.Constants.PINWHEELOVERLAY);
            IsPageLoaded();
        }

        

        public bool IsPageLoaded()
        {
            TraceLine = "if (!IsPageTitle(Constants.TITLE.Users))";
            if (IsPageTitle(Constants.TITLE.Users))
            {
                return true;
            }
            TraceFailed.ShouldBe(TraceLine);
            return false;
        }
        
    }
}
