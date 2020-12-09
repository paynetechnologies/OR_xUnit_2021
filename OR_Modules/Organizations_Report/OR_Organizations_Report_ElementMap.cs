using OpenQA.Selenium;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
using Core.Base;
using Core.Driver;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;
using System.Reflection;

namespace OR_Organizations_Report
{
    public partial class Organizations_Report
    {
        public IWebElement AddContactLink => Browser.FindElement(By.Id("AddContactLink"));
        public IWebElement AddFollowupLink => Browser.FindElement(By.Id("AddFollowupLink"));
        public IWebElement AddOrganizationLink => Browser.FindElement(By.Id("AddOrganizationLink"));
        public IWebElement AnchorOpenCalendar_FromDateField => Browser.FindElement(By.Id("AnchorOpenCalendar_FromDateField"));
        public IWebElement AnchorOpenCalendar_ToDateField => Browser.FindElement(By.Id("AnchorOpenCalendar_ToDateField"));
        public IWebElement AppLogoLink => Browser.FindElement(By.Id("AppLogoLink"));
        public IWebElement ClearButton => Browser.FindElement(By.Id("ClearButton"));
        public IWebElement ContactsButton => Browser.FindElement(By.Id("ContactsButton"));
        public IWebElement ContactsReportLink => Browser.FindElement(By.Id("ContactsReportLink"));
        public IWebElement ExportButton => Browser.FindElement(By.Id("ExportButton"));
        public IWebElement FollowupsButton => Browser.FindElement(By.Id("FollowupsButton"));
        public IWebElement FollowupsReportLink => Browser.FindElement(By.Id("FollowupsReportLink"));
        public IWebElement FromDateField => Browser.FindElement(By.Id("FromDateField"));
        public IWebElement LogoffLinkName => Browser.FindElement(By.Id("LogoffLinkName"));
        public IWebElement OrganizationPanel => Browser.FindElement(By.Id("OrganizationPanel"));
        public IWebElement OrganizationsButton => Browser.FindElement(By.Id("OrganizationsButton"));
        public IWebElement OrganizationsReportLink => Browser.FindElement(By.Id("OrganizationsReportLink"));
        public IWebElement ProgramField => Browser.FindElement(By.Id("ProgramField"));
        public SelectElement ProgramFieldOption => new SelectElement(ProgramField);
        public ReadOnlyCollection<IWebElement> ProgramFieldOptionsUl => Browser.FindElements(By.XPath("//*[@id='ProgramFieldOptionsUl']//li//a"));
        public IWebElement ProgramFieldSelectedAnchor => Browser.FindElement(By.Id("ProgramFieldSelectedAnchor"));
        public IWebElement QuickBackToTopLink => Browser.FindElement(By.Id("QuickBackToTopLink"));
        public IWebElement SearchButton => Browser.FindElement(By.Id("SearchButton"));
        public IWebElement SearchForm => Browser.FindElement(By.Id("SearchForm"));
        public IWebElement SectorField => Browser.FindElement(By.Id("SectorField"));
        public SelectElement SectorFieldOption => new SelectElement(SectorField);
        public ReadOnlyCollection<IWebElement> SectorFieldOptionsUl => Browser.FindElements(By.XPath("//*[@id='SectorFieldOptionsUl']//li//a"));
        public IWebElement SectorFieldSelectedAnchor => Browser.FindElement(By.Id("SectorFieldSelectedAnchor"));
        public IWebElement SecurityGroupsLink => Browser.FindElement(By.Id("SecurityGroupsLink"));
        public IWebElement SkipToMainContent508 => Browser.FindElement(By.Id("SkipToMainContent508"));
        public IWebElement SolicitationField => Browser.FindElement(By.Id("SolicitationField"));
        public SelectElement SolicitationFieldOption => new SelectElement(SolicitationField);
        public ReadOnlyCollection<IWebElement> SolicitationFieldOptionsUl => Browser.FindElements(By.XPath("//*[@id='SolicitationFieldOptionsUl']//li//a"));
        public IWebElement SolicitationFieldSelectedAnchor => Browser.FindElement(By.Id("SolicitationFieldSelectedAnchor"));
        public IWebElement ToDateField => Browser.FindElement(By.Id("ToDateField"));
        public IWebElement TypeField => Browser.FindElement(By.Id("TypeField"));
        public SelectElement TypeFieldOption => new SelectElement(TypeField);
        public ReadOnlyCollection<IWebElement> TypeFieldOptionsUl => Browser.FindElements(By.XPath("//*[@id='TypeFieldOptionsUl']//li//a"));
        public IWebElement TypeFieldSelectedAnchor => Browser.FindElement(By.Id("TypeFieldSelectedAnchor"));
        public IWebElement UsersLink => Browser.FindElement(By.Id("UsersLink"));
    }
}
