using Core.Base;
using Core.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OR_Modules.Configuration;
using OR_Modules.Model;
using Shouldly;
using Xunit.Abstractions;

namespace OR_Login
{
    public partial class Login : BasePage
    {
        // need vm url
        //public override string Url => @"http://localhost:100/content/login.html";
        public override string Url => UrlDeterminer.GetSite(Constants.URL.Login);

        /// /////////////////////////////////////////

        // TODO : add to HTML Parser

        // Default userId & password
        public Login(ITestOutputHelper output)
            : this(BrowserTypes.Chrome, output) { }

        // SSO or default user
        //public Login(BrowserTypes bt, ITestOutputHelper output) : base(bt)
        //{
        //    if (UrlSettingsModel.UrlSettings.SingleSignOn == true)
        //    {
        //        Output = output;
        //        SplashScreen = new SplashScreen.SplashScreen(open: false, browser: this.Browser, browserWait: this.BrowserWait, output: Output);
        //        if (UrlSettingsModel.UrlSettings.Site == QS_Constants.SITE.DOE_UAT_QS) //."doeUatQS")
        //        {
        //            Url = UrlDeterminer.GetSite("/");
        //        }
        //        else
        //        {
        //            Url = UrlDeterminer.GetSite("/splashscreen/home.html");
        //        }
        //        //05.29.20 Should I call Open and Load JQuery (below) or just simply Open();
        //        Open(true);
        //        WaitForPinwheel(QS_Constants.PINWHEELOVERLAY);
        //        ScrollDown();
        //        Action_MoveToElement(By.Id("ContinueButton"));
        //        WaitFor.WaitForPageLoad();
        //        SplashScreen.ContinueButton.Click();
        //    }
        //    else
        //    {
        //        Output = output;
        //        //05.29.20 Should I call Open and Load JQuery (below) or just simply Open();
        //        Open(true);
        //        WaitForPinwheel(QS_Constants.PINWHEELOVERLAY);
        //        IsPageTitle("Login");
        //        LoginUser();
        //        WaitForPinwheel(QS_Constants.PINWHEELOVERLAY);
        //    }
        //}

        // TODO : add to HTML Parser
        public Login(BrowserTypes bt, ITestOutputHelper output) : base(bt)
        {
            Output = output;
            Open(true);
            WaitForPinwheel(Core.Common.Constants.PINWHEELOVERLAY);
            IsPageTitle("Login");
            LoginUser();
            WaitForPinwheel(Core.Common.Constants.PINWHEELOVERLAY);
        }
        
        // TODO : add to HTML Parser
        public void LoginUser()
        {
            UserSettingsModel uc = new UserSettingsModel();

            SendData(UsernameField, uc.UserId);
            SendData(PasswordField, uc.UserPassword);

            if (IsClickable(By.Id("LoginButton")))
            {
                LoginButton.SendKeys(Keys.Return);
            }
        }

        ///////////////////////////////////////////////

        // Unit Test Constructor
        public Login () : base() 
        {
            Open();
            IsPageLoaded();
        }

        public Login(BrowserTypes bt) : base(bt) 
        {
            Open();
            IsPageLoaded();
        }

        // Integration Test Constructor
        public Login(bool reuse, IWebDriver browser, WebDriverWait browserWait)
             : base(reuse, browser, browserWait) 
        { 
        }

        // Integration Test Constructor
        public Login(bool reuse, IWebDriver browser, WebDriverWait browserWait, ITestOutputHelper output)
             : base(reuse, browser, browserWait)
        {
            Output = output;
            TraceLine = "Login Starting...";
            if (reuse) Open();
            WaitForPinwheel(Core.Common.Constants.PINWHEELOVERLAY);
            IsPageLoaded();
        }

        

        public override void Open(string part = "")
        {
            base.Open(part);
        }

        public void LoginUser(string userName, string password)
        {
            // Login - input username and password
            SendData(UsernameField, userName);
            SendData(PasswordField, password);

            // Click login button
            if (IsClickable(By.Id("LoginButton")))
            {
                LoginButton.SendKeys(Keys.Return);
            }
        }
        

        public bool IsPageLoaded()
        {
            TraceLine = "if (!IsPageTitle(Constants.TITLE.Login))";
            if (IsPageTitle(Constants.TITLE.Login))
            {
                return true;
            }
            TraceFailed.ShouldBe(TraceLine);
            return false;
        }
        
    }
}
