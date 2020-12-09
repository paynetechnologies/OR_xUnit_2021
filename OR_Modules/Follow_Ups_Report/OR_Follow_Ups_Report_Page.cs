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

namespace OR_Follow_Ups_Report
{
    public partial class Follow_Ups_Report : BasePage
    {
        // Unit Test URL
        public override string Url => UrlDeterminer.GetSite(Constants.URL.Follow_Ups_Report);


        // Unit Test Constructor
        public Follow_Ups_Report () : base() 
        {
            Open();
            IsPageLoaded();
        }

        public Follow_Ups_Report(BrowserTypes bt) : base(bt) 
        {
            Open();
            IsPageLoaded();
        }

        // Integration Test Constructor
        public Follow_Ups_Report(bool reuse, IWebDriver browser, WebDriverWait browserWait)
             : base(reuse, browser, browserWait) 
        { 
        }

        // Integration Test Constructor
        public Follow_Ups_Report(bool reuse, IWebDriver browser, WebDriverWait browserWait, ITestOutputHelper output)
             : base(reuse, browser, browserWait)
        {
            Output = output;
            TraceLine = "Follow_Ups_Report Starting...";
            if (reuse) Open();
            WaitForPinwheel(Core.Common.Constants.PINWHEELOVERLAY);
            IsPageLoaded();
        }

        

        public bool IsPageLoaded()
        {
            TraceLine = "if (!IsPageTitle(Constants.TITLE.Follow_Ups_Report))";
            if (IsPageTitle(Constants.TITLE.Follow_Ups_Report))
            {
                return true;
            }
            TraceFailed.ShouldBe(TraceLine);
            return false;
        }
        
    }
}
