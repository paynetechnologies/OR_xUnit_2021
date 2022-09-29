using OpenQA.Selenium;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
using Core.Base;
using Core.Driver;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;
using System.Reflection;

namespace OR_Organizations
{
    public partial class Organizations
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
        public IWebElement GTC08103905_7ed7_4ad8_96dd_d23655affc44 => Browser.FindElement(By.Id("GTC08103905_7ed7_4ad8_96dd_d23655affc44"));
        public IWebElement GTC97193ebe_8fe8_45b2_9cad_9182e7b0e443 => Browser.FindElement(By.Id("GTC97193ebe_8fe8_45b2_9cad_9182e7b0e443"));
        public IWebElement LogoffLinkName => Browser.FindElement(By.Id("LogoffLinkName"));
        public IWebElement OrganizationField => Browser.FindElement(By.Id("OrganizationField"));
        public IWebElement OrganizationHyperlinkGTC2Re8ncqZoSsu43yUXwtViNg6161 => Browser.FindElement(By.Id("OrganizationHyperlinkGTC2Re8ncqZoSsu43yUXwtViNg6161"));
        public IWebElement OrganizationHyperlinkGTC47hzR9BnR3rjgrTfEnCip7A6161 => Browser.FindElement(By.Id("OrganizationHyperlinkGTC47hzR9BnR3rjgrTfEnCip7A6161"));
        public IWebElement OrganizationHyperlinkGTCBnWol6FVb20sTVQLvJ649w6161 => Browser.FindElement(By.Id("OrganizationHyperlinkGTCBnWol6FVb20sTVQLvJ649w6161"));
        public IWebElement OrganizationHyperlinkGTCCfa9t4va8SgRlZEFqrLfJA6161 => Browser.FindElement(By.Id("OrganizationHyperlinkGTCCfa9t4va8SgRlZEFqrLfJA6161"));
        public IWebElement OrganizationHyperlinkGTCGgNcp7431YjKSjkAEB9P9Gw6161 => Browser.FindElement(By.Id("OrganizationHyperlinkGTCGgNcp7431YjKSjkAEB9P9Gw6161"));
        public IWebElement OrganizationHyperlinkGTCR4rd47aVnNjs47K2XL1u2F1g6161 => Browser.FindElement(By.Id("OrganizationHyperlinkGTCR4rd47aVnNjs47K2XL1u2F1g6161"));
        public IWebElement OrganizationHyperlinkGTCoR8of2mFXo47s6Nq0xHb8kA6161 => Browser.FindElement(By.Id("OrganizationHyperlinkGTCoR8of2mFXo47s6Nq0xHb8kA6161"));
        public IWebElement OrganizationHyperlinkGTCvqx632Q7747mkAZZVLKMo0A6161 => Browser.FindElement(By.Id("OrganizationHyperlinkGTCvqx632Q7747mkAZZVLKMo0A6161"));
        public IWebElement OrganizationHyperlinkGTCx28RJZ7MZu1vu43h4A232cQ6161 => Browser.FindElement(By.Id("OrganizationHyperlinkGTCx28RJZ7MZu1vu43h4A232cQ6161"));
        public IWebElement OrganizationHyperlinkGTCxXXJVZ4TnEswUMAcyD7fSw6161 => Browser.FindElement(By.Id("OrganizationHyperlinkGTCxXXJVZ4TnEswUMAcyD7fSw6161"));
        public IWebElement OrganizationsButton => Browser.FindElement(By.Id("OrganizationsButton"));
        public IWebElement OrganizationsPanel => Browser.FindElement(By.Id("OrganizationsPanel"));
        public IWebElement OrganizationsReportLink => Browser.FindElement(By.Id("OrganizationsReportLink"));
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
