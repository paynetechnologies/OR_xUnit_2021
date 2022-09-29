//Generated : 2020-12-17
using OpenQA.Selenium;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
using Core.Base;
using Core.Driver;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;
using System.Reflection;

namespace OR_Modules.Organization
{
    public partial class Organization
    {
        public IWebElement AddContactLink => Browser.FindElement(By.Id("AddContactLink"));
        public IWebElement AddFollowupLink => Browser.FindElement(By.Id("AddFollowupLink"));
        public IWebElement AddOrganizationLink => Browser.FindElement(By.Id("AddOrganizationLink"));
        public IWebElement AddOrganizationModalLink => Browser.FindElement(By.Id("AddOrganizationModalLink"));
        public IWebElement AppLogoLink => Browser.FindElement(By.Id("AppLogoLink"));
        public IWebElement ContactField => Browser.FindElement(By.Id("ContactField"));
        public IWebElement ContactsButton => Browser.FindElement(By.Id("ContactsButton"));
        public IWebElement ContactsReportLink => Browser.FindElement(By.Id("ContactsReportLink"));
        public IWebElement FollowupsButton => Browser.FindElement(By.Id("FollowupsButton"));
        public IWebElement FollowupsReportLink => Browser.FindElement(By.Id("FollowupsReportLink"));
        public IWebElement GTCe1c372e2_9c0c_4903_b9d1_831d901c3f56 => Browser.FindElement(By.Id("GTCe1c372e2_9c0c_4903_b9d1_831d901c3f56"));
        public IWebElement GTCe2963286_c7ce_4754_9c1e_66bc8f7817af => Browser.FindElement(By.Id("GTCe2963286_c7ce_4754_9c1e_66bc8f7817af"));
        public IWebElement LogoffLinkName => Browser.FindElement(By.Id("LogoffLinkName"));
        public IWebElement OrganizationField => Browser.FindElement(By.Id("OrganizationField"));
        public IWebElement OrganizationHyperlinkGTC47wGYlCxnro68l4VWeKU1xg6161 => Browser.FindElement(By.Id("OrganizationHyperlinkGTC47wGYlCxnro68l4VWeKU1xg6161"));
        public IWebElement OrganizationsButton => Browser.FindElement(By.Id("OrganizationsButton"));
        public IWebElement OrganizationsPanel => Browser.FindElement(By.Id("OrganizationsPanel"));
        public IWebElement OrganizationsReportLink => Browser.FindElement(By.Id("OrganizationsReportLink"));
        public IWebElement OutreachReportLink => Browser.FindElement(By.Id("OutreachReportLink"));
        public IWebElement QuickBackToTopLink => Browser.FindElement(By.Id("QuickBackToTopLink"));
        public IWebElement ResetButton => Browser.FindElement(By.Id("ResetButton"));
        public IWebElement SearchButton => Browser.FindElement(By.Id("SearchButton"));
        public IWebElement SearchForm => Browser.FindElement(By.Id("SearchForm"));
        public IWebElement SectorField => Browser.FindElement(By.Id("SectorField"));
        public SelectElement SectorFieldOption => new SelectElement(SectorField);
        public ReadOnlyCollection<IWebElement> SectorFieldOptionsUl => Browser.FindElements(By.XPath("//*[@id='SectorFieldOptionsUl']//li//a"));
        public IWebElement SectorFieldSelectedAnchor => Browser.FindElement(By.Id("SectorFieldSelectedAnchor"));
        public IWebElement SecurityGroupsLink => Browser.FindElement(By.Id("SecurityGroupsLink"));
        public IWebElement SkipToMainContent508 => Browser.FindElement(By.Id("SkipToMainContent508"));
        public IWebElement UsersLink => Browser.FindElement(By.Id("UsersLink"));
    }
}
