using OpenQA.Selenium;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
using Core.Base;
using Core.Driver;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;
using System.Reflection;

namespace OR_Login
{
    public partial class Login
    {
        public IWebElement ForgotPasswordLink => Browser.FindElement(By.Id("ForgotPasswordLink"));
        public IWebElement ForgotUsernameLink => Browser.FindElement(By.Id("ForgotUsernameLink"));
        public IWebElement LoginButton => Browser.FindElement(By.Id("LoginButton"));
        public IWebElement LoginForm => Browser.FindElement(By.Id("LoginForm"));
        public IWebElement PasswordField => Browser.FindElement(By.Id("PasswordField"));
        public IWebElement QuickBackToTopLink => Browser.FindElement(By.Id("QuickBackToTopLink"));
        public IWebElement SkipToMainContent508 => Browser.FindElement(By.Id("SkipToMainContent508"));
        public IWebElement UsernameField => Browser.FindElement(By.Id("UsernameField"));
    }
}
