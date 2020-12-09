using OpenQA.Selenium;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
using Core.Base;
using Core.Driver;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;
using System.Reflection;

namespace OR_Contacts
{
    public partial class Contacts
    {
        public IWebElement AddContactLink => Browser.FindElement(By.Id("AddContactLink"));
        public IWebElement AddFollowupLink => Browser.FindElement(By.Id("AddFollowupLink"));
        public IWebElement AddFollowupToContactModalLinkGTC5NSsG9OiNsFUiKJFPKSdaQ6161 => Browser.FindElement(By.Id("AddFollowupToContactModalLinkGTC5NSsG9OiNsFUiKJFPKSdaQ6161"));
        public IWebElement AddFollowupToContactModalLinkGTCAebs6kijoEGnDXK48cHPfQ6161 => Browser.FindElement(By.Id("AddFollowupToContactModalLinkGTCAebs6kijoEGnDXK48cHPfQ6161"));
        public IWebElement AddFollowupToContactModalLinkGTCJ478mBQNslOhHFKR843vMLOg6161 => Browser.FindElement(By.Id("AddFollowupToContactModalLinkGTCJ478mBQNslOhHFKR843vMLOg6161"));
        public IWebElement AddFollowupToContactModalLinkGTCL8L8szwJYuOs9rYvZ6tykA6161 => Browser.FindElement(By.Id("AddFollowupToContactModalLinkGTCL8L8szwJYuOs9rYvZ6tykA6161"));
        public IWebElement AddFollowupToContactModalLinkGTCOxru4Lg996DWBjHOYWolkw6161 => Browser.FindElement(By.Id("AddFollowupToContactModalLinkGTCOxru4Lg996DWBjHOYWolkw6161"));
        public IWebElement AddFollowupToContactModalLinkGTCU9VyTDdH5I2rQbIq0SNIIg6161 => Browser.FindElement(By.Id("AddFollowupToContactModalLinkGTCU9VyTDdH5I2rQbIq0SNIIg6161"));
        public IWebElement AddFollowupToContactModalLinkGTCey3QXSVmF43RsQuYYoPIcrA6161 => Browser.FindElement(By.Id("AddFollowupToContactModalLinkGTCey3QXSVmF43RsQuYYoPIcrA6161"));
        public IWebElement AddFollowupToContactModalLinkGTCfTRHIvV4749UZVQjKOvti9Q6161 => Browser.FindElement(By.Id("AddFollowupToContactModalLinkGTCfTRHIvV4749UZVQjKOvti9Q6161"));
        public IWebElement AddFollowupToContactModalLinkGTCm2FkmGXizG9m33hOYR43PKQ6161 => Browser.FindElement(By.Id("AddFollowupToContactModalLinkGTCm2FkmGXizG9m33hOYR43PKQ6161"));
        public IWebElement AddFollowupToContactModalLinkGTCqze2esNMlO519UjS6EXveQ6161 => Browser.FindElement(By.Id("AddFollowupToContactModalLinkGTCqze2esNMlO519UjS6EXveQ6161"));
        public IWebElement AddNewContactModalLink => Browser.FindElement(By.Id("AddNewContactModalLink"));
        public IWebElement AddOrganizationLink => Browser.FindElement(By.Id("AddOrganizationLink"));
        public IWebElement AppLogoLink => Browser.FindElement(By.Id("AppLogoLink"));
        public IWebElement ContactField => Browser.FindElement(By.Id("ContactField"));
        public IWebElement ContactPanel => Browser.FindElement(By.Id("ContactPanel"));
        public IWebElement ContactSummaryHyperlinkGTC5NSsG9OiNsFUiKJFPKSdaQ6161 => Browser.FindElement(By.Id("ContactSummaryHyperlinkGTC5NSsG9OiNsFUiKJFPKSdaQ6161"));
        public IWebElement ContactSummaryHyperlinkGTCAebs6kijoEGnDXK48cHPfQ6161 => Browser.FindElement(By.Id("ContactSummaryHyperlinkGTCAebs6kijoEGnDXK48cHPfQ6161"));
        public IWebElement ContactSummaryHyperlinkGTCJ478mBQNslOhHFKR843vMLOg6161 => Browser.FindElement(By.Id("ContactSummaryHyperlinkGTCJ478mBQNslOhHFKR843vMLOg6161"));
        public IWebElement ContactSummaryHyperlinkGTCL8L8szwJYuOs9rYvZ6tykA6161 => Browser.FindElement(By.Id("ContactSummaryHyperlinkGTCL8L8szwJYuOs9rYvZ6tykA6161"));
        public IWebElement ContactSummaryHyperlinkGTCOxru4Lg996DWBjHOYWolkw6161 => Browser.FindElement(By.Id("ContactSummaryHyperlinkGTCOxru4Lg996DWBjHOYWolkw6161"));
        public IWebElement ContactSummaryHyperlinkGTCU9VyTDdH5I2rQbIq0SNIIg6161 => Browser.FindElement(By.Id("ContactSummaryHyperlinkGTCU9VyTDdH5I2rQbIq0SNIIg6161"));
        public IWebElement ContactSummaryHyperlinkGTCey3QXSVmF43RsQuYYoPIcrA6161 => Browser.FindElement(By.Id("ContactSummaryHyperlinkGTCey3QXSVmF43RsQuYYoPIcrA6161"));
        public IWebElement ContactSummaryHyperlinkGTCfTRHIvV4749UZVQjKOvti9Q6161 => Browser.FindElement(By.Id("ContactSummaryHyperlinkGTCfTRHIvV4749UZVQjKOvti9Q6161"));
        public IWebElement ContactSummaryHyperlinkGTCm2FkmGXizG9m33hOYR43PKQ6161 => Browser.FindElement(By.Id("ContactSummaryHyperlinkGTCm2FkmGXizG9m33hOYR43PKQ6161"));
        public IWebElement ContactSummaryHyperlinkGTCqze2esNMlO519UjS6EXveQ6161 => Browser.FindElement(By.Id("ContactSummaryHyperlinkGTCqze2esNMlO519UjS6EXveQ6161"));
        public IWebElement ContactsButton => Browser.FindElement(By.Id("ContactsButton"));
        public IWebElement ContactsReportLink => Browser.FindElement(By.Id("ContactsReportLink"));
        public IWebElement FollowupsButton => Browser.FindElement(By.Id("FollowupsButton"));
        public IWebElement FollowupsReportLink => Browser.FindElement(By.Id("FollowupsReportLink"));
        public IWebElement GTC3925e880_431b_46f0_9f19_4fc03e348d2f => Browser.FindElement(By.Id("GTC3925e880_431b_46f0_9f19_4fc03e348d2f"));
        public IWebElement GTC6960c6da_b307_4f2c_a114_74e71446a6c1 => Browser.FindElement(By.Id("GTC6960c6da_b307_4f2c_a114_74e71446a6c1"));
        public IWebElement GTC8b6c7194_6c10_4eb2_90fd_0dce5dd91fd2 => Browser.FindElement(By.Id("GTC8b6c7194_6c10_4eb2_90fd_0dce5dd91fd2"));
        public IWebElement LogoffLinkName => Browser.FindElement(By.Id("LogoffLinkName"));
        public IWebElement OrganizationField => Browser.FindElement(By.Id("OrganizationField"));
        public IWebElement OrganizationHyperlinkGTC5NSsG9OiNsFUiKJFPKSdaQ6161 => Browser.FindElement(By.Id("OrganizationHyperlinkGTC5NSsG9OiNsFUiKJFPKSdaQ6161"));
        public IWebElement OrganizationHyperlinkGTCAebs6kijoEGnDXK48cHPfQ6161 => Browser.FindElement(By.Id("OrganizationHyperlinkGTCAebs6kijoEGnDXK48cHPfQ6161"));
        public IWebElement OrganizationHyperlinkGTCJ478mBQNslOhHFKR843vMLOg6161 => Browser.FindElement(By.Id("OrganizationHyperlinkGTCJ478mBQNslOhHFKR843vMLOg6161"));
        public IWebElement OrganizationHyperlinkGTCL8L8szwJYuOs9rYvZ6tykA6161 => Browser.FindElement(By.Id("OrganizationHyperlinkGTCL8L8szwJYuOs9rYvZ6tykA6161"));
        public IWebElement OrganizationHyperlinkGTCOxru4Lg996DWBjHOYWolkw6161 => Browser.FindElement(By.Id("OrganizationHyperlinkGTCOxru4Lg996DWBjHOYWolkw6161"));
        public IWebElement OrganizationHyperlinkGTCU9VyTDdH5I2rQbIq0SNIIg6161 => Browser.FindElement(By.Id("OrganizationHyperlinkGTCU9VyTDdH5I2rQbIq0SNIIg6161"));
        public IWebElement OrganizationHyperlinkGTCey3QXSVmF43RsQuYYoPIcrA6161 => Browser.FindElement(By.Id("OrganizationHyperlinkGTCey3QXSVmF43RsQuYYoPIcrA6161"));
        public IWebElement OrganizationHyperlinkGTCfTRHIvV4749UZVQjKOvti9Q6161 => Browser.FindElement(By.Id("OrganizationHyperlinkGTCfTRHIvV4749UZVQjKOvti9Q6161"));
        public IWebElement OrganizationHyperlinkGTCm2FkmGXizG9m33hOYR43PKQ6161 => Browser.FindElement(By.Id("OrganizationHyperlinkGTCm2FkmGXizG9m33hOYR43PKQ6161"));
        public IWebElement OrganizationHyperlinkGTCqze2esNMlO519UjS6EXveQ6161 => Browser.FindElement(By.Id("OrganizationHyperlinkGTCqze2esNMlO519UjS6EXveQ6161"));
        public IWebElement OrganizationsButton => Browser.FindElement(By.Id("OrganizationsButton"));
        public IWebElement OrganizationsReportLink => Browser.FindElement(By.Id("OrganizationsReportLink"));
        public IWebElement QuickBackToTopLink => Browser.FindElement(By.Id("QuickBackToTopLink"));
        public IWebElement ResetButton => Browser.FindElement(By.Id("ResetButton"));
        public IWebElement SearchButton => Browser.FindElement(By.Id("SearchButton"));
        public IWebElement SearchForm => Browser.FindElement(By.Id("SearchForm"));
        public IWebElement SectorField => Browser.FindElement(By.Id("SectorField"));
        public IWebElement SecurityGroupsLink => Browser.FindElement(By.Id("SecurityGroupsLink"));
        public IWebElement SkipToMainContent508 => Browser.FindElement(By.Id("SkipToMainContent508"));
        public IWebElement UsersLink => Browser.FindElement(By.Id("UsersLink"));
        public IWebElement WebsiteLinkGTC5NSsG9OiNsFUiKJFPKSdaQ6161 => Browser.FindElement(By.Id("WebsiteLinkGTC5NSsG9OiNsFUiKJFPKSdaQ6161"));
        public IWebElement WebsiteLinkGTCAebs6kijoEGnDXK48cHPfQ6161 => Browser.FindElement(By.Id("WebsiteLinkGTCAebs6kijoEGnDXK48cHPfQ6161"));
        public IWebElement WebsiteLinkGTCJ478mBQNslOhHFKR843vMLOg6161 => Browser.FindElement(By.Id("WebsiteLinkGTCJ478mBQNslOhHFKR843vMLOg6161"));
        public IWebElement WebsiteLinkGTCL8L8szwJYuOs9rYvZ6tykA6161 => Browser.FindElement(By.Id("WebsiteLinkGTCL8L8szwJYuOs9rYvZ6tykA6161"));
        public IWebElement WebsiteLinkGTCOxru4Lg996DWBjHOYWolkw6161 => Browser.FindElement(By.Id("WebsiteLinkGTCOxru4Lg996DWBjHOYWolkw6161"));
        public IWebElement WebsiteLinkGTCU9VyTDdH5I2rQbIq0SNIIg6161 => Browser.FindElement(By.Id("WebsiteLinkGTCU9VyTDdH5I2rQbIq0SNIIg6161"));
        public IWebElement WebsiteLinkGTCey3QXSVmF43RsQuYYoPIcrA6161 => Browser.FindElement(By.Id("WebsiteLinkGTCey3QXSVmF43RsQuYYoPIcrA6161"));
        public IWebElement WebsiteLinkGTCfTRHIvV4749UZVQjKOvti9Q6161 => Browser.FindElement(By.Id("WebsiteLinkGTCfTRHIvV4749UZVQjKOvti9Q6161"));
        public IWebElement WebsiteLinkGTCm2FkmGXizG9m33hOYR43PKQ6161 => Browser.FindElement(By.Id("WebsiteLinkGTCm2FkmGXizG9m33hOYR43PKQ6161"));
        public IWebElement WebsiteLinkGTCqze2esNMlO519UjS6EXveQ6161 => Browser.FindElement(By.Id("WebsiteLinkGTCqze2esNMlO519UjS6EXveQ6161"));
    }
}
