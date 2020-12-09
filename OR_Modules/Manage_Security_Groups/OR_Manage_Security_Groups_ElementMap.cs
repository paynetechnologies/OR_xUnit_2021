using OpenQA.Selenium;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
using Core.Base;
using Core.Driver;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;
using System.Reflection;

namespace OR_Manage_Security_Groups
{
    public partial class Manage_Security_Groups
    {
        public IWebElement AddButton => Browser.FindElement(By.Id("AddButton"));
        public IWebElement AddSecurityGroupButton => Browser.FindElement(By.Id("AddSecurityGroupButton"));
        public IWebElement AllowField => Browser.FindElement(By.Id("AllowField"));
        public IWebElement AppLogoLink => Browser.FindElement(By.Id("AppLogoLink"));
        public IWebElement CancelButton => Browser.FindElement(By.Id("CancelButton"));
        public IWebElement CopyFromSecurityGroupField => Browser.FindElement(By.Id("CopyFromSecurityGroupField"));
        public SelectElement CopyFromSecurityGroupFieldOption => new SelectElement(CopyFromSecurityGroupField);
        public ReadOnlyCollection<IWebElement> CopyFromSecurityGroupFieldOptionsUl => Browser.FindElements(By.XPath("//*[@id='CopyFromSecurityGroupFieldOptionsUl']//li//a"));
        public IWebElement CopyFromSecurityGroupFieldSelectedAnchor => Browser.FindElement(By.Id("CopyFromSecurityGroupFieldSelectedAnchor"));
        public IWebElement LogoffLinkName => Browser.FindElement(By.Id("LogoffLinkName"));
        public IWebElement NewSecurityGroupField => Browser.FindElement(By.Id("NewSecurityGroupField"));
        public IWebElement NewSecurityGroupForm => Browser.FindElement(By.Id("NewSecurityGroupForm"));
        public IWebElement QuickBackToTopLink => Browser.FindElement(By.Id("QuickBackToTopLink"));
        public IWebElement SecurityForm => Browser.FindElement(By.Id("SecurityForm"));
        public IWebElement SecurityGroupField => Browser.FindElement(By.Id("SecurityGroupField"));
        public SelectElement SecurityGroupFieldOption => new SelectElement(SecurityGroupField);
        public ReadOnlyCollection<IWebElement> SecurityGroupFieldOptionsUl => Browser.FindElements(By.XPath("//*[@id='SecurityGroupFieldOptionsUl']//li//a"));
        public IWebElement SecurityGroupFieldSelectedAnchor => Browser.FindElement(By.Id("SecurityGroupFieldSelectedAnchor"));
        public IWebElement SecurityGroupsLink => Browser.FindElement(By.Id("SecurityGroupsLink"));
        public IWebElement SecurityPanelAllowAllLink => Browser.FindElement(By.Id("SecurityPanelAllowAllLink"));
        public IWebElement SecurityPanelAllowAllViewsLink => Browser.FindElement(By.Id("SecurityPanelAllowAllViewsLink"));
        public IWebElement SecurityPanelDenyAllLink => Browser.FindElement(By.Id("SecurityPanelDenyAllLink"));
        public IWebElement SecurityPanelDenyAllViewsLink => Browser.FindElement(By.Id("SecurityPanelDenyAllViewsLink"));
        public IWebElement SkipToMainContent508 => Browser.FindElement(By.Id("SkipToMainContent508"));
        public IWebElement UsersLink => Browser.FindElement(By.Id("UsersLink"));
        public IWebElement ViewDetailField => Browser.FindElement(By.Id("ViewDetailField"));
        public SelectElement ViewDetailFieldOption => new SelectElement(ViewDetailField);
        public ReadOnlyCollection<IWebElement> ViewDetailFieldOptionsUl => Browser.FindElements(By.XPath("//*[@id='ViewDetailFieldOptionsUl']//li//a"));
        public IWebElement ViewDetailFieldSelectedAnchor => Browser.FindElement(By.Id("ViewDetailFieldSelectedAnchor"));
    }
}
