using OpenQA.Selenium;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
using Core.Base;
using Core.Driver;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;
using System.Reflection;

namespace OR_Follow_Ups_Report
{
    public partial class Follow_Ups_Report
    {
        public IWebElement AddContactLink => Browser.FindElement(By.Id("AddContactLink"));
        public IWebElement AddFollowupLink => Browser.FindElement(By.Id("AddFollowupLink"));
        public IWebElement AddOrganizationLink => Browser.FindElement(By.Id("AddOrganizationLink"));
        public IWebElement AnchorOpenCalendar_FromDateField => Browser.FindElement(By.Id("AnchorOpenCalendar_FromDateField"));
        public IWebElement AnchorOpenCalendar_ToDateField => Browser.FindElement(By.Id("AnchorOpenCalendar_ToDateField"));
        public IWebElement AppLogoLink => Browser.FindElement(By.Id("AppLogoLink"));
        public IWebElement ClearButton => Browser.FindElement(By.Id("ClearButton"));
        public IWebElement ContactField => Browser.FindElement(By.Id("ContactField"));
        public IWebElement ContactsButton => Browser.FindElement(By.Id("ContactsButton"));
        public IWebElement ContactsReportLink => Browser.FindElement(By.Id("ContactsReportLink"));
        public IWebElement ExportButton => Browser.FindElement(By.Id("ExportButton"));
        public IWebElement FollowupPanel => Browser.FindElement(By.Id("FollowupPanel"));
        public IWebElement FollowupTypeField => Browser.FindElement(By.Id("FollowupTypeField"));
        public SelectElement FollowupTypeFieldOption => new SelectElement(FollowupTypeField);
        public ReadOnlyCollection<IWebElement> FollowupTypeFieldOptionsUl => Browser.FindElements(By.XPath("//*[@id='FollowupTypeFieldOptionsUl']//li//a"));
        public IWebElement FollowupTypeFieldSelectedAnchor => Browser.FindElement(By.Id("FollowupTypeFieldSelectedAnchor"));
        public IWebElement FollowupsButton => Browser.FindElement(By.Id("FollowupsButton"));
        public IWebElement FollowupsReportLink => Browser.FindElement(By.Id("FollowupsReportLink"));
        public IWebElement FromDateField => Browser.FindElement(By.Id("FromDateField"));
        public IWebElement GTC92d88480_c95d_4d61_8803_02451ac0a729 => Browser.FindElement(By.Id("GTC92d88480_c95d_4d61_8803_02451ac0a729"));
        public IWebElement GTCfd35bc93_1d11_4634_b114_6afeedc52f3c => Browser.FindElement(By.Id("GTCfd35bc93_1d11_4634_b114_6afeedc52f3c"));
        public IWebElement LPOOwnerField => Browser.FindElement(By.Id("LPOOwnerField"));
        public SelectElement LPOOwnerFieldOption => new SelectElement(LPOOwnerField);
        public ReadOnlyCollection<IWebElement> LPOOwnerFieldOptionsUl => Browser.FindElements(By.XPath("//*[@id='LPOOwnerFieldOptionsUl']//li//a"));
        public IWebElement LPOOwnerFieldSelectedAnchor => Browser.FindElement(By.Id("LPOOwnerFieldSelectedAnchor"));
        public IWebElement LogoffLinkName => Browser.FindElement(By.Id("LogoffLinkName"));
        public IWebElement OrganizationField => Browser.FindElement(By.Id("OrganizationField"));
        public IWebElement OrganizationsButton => Browser.FindElement(By.Id("OrganizationsButton"));
        public IWebElement OrganizationsReportLink => Browser.FindElement(By.Id("OrganizationsReportLink"));
        public IWebElement QuickBackToTopLink => Browser.FindElement(By.Id("QuickBackToTopLink"));
        public IWebElement SearchButton => Browser.FindElement(By.Id("SearchButton"));
        public IWebElement SearchForm => Browser.FindElement(By.Id("SearchForm"));
        public IWebElement SecurityGroupsLink => Browser.FindElement(By.Id("SecurityGroupsLink"));
        public IWebElement SkipToMainContent508 => Browser.FindElement(By.Id("SkipToMainContent508"));
        public IWebElement ToDateField => Browser.FindElement(By.Id("ToDateField"));
        public IWebElement UsersLink => Browser.FindElement(By.Id("UsersLink"));
    }
}
