//Generated : 2020-12-17
using Core.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OR_Modules.Configuration;
using Shouldly;
using Xunit.Abstractions;

namespace OR_Modules.Organization
{
    public partial class Organization : BasePage
    {
        private IWebElement FilterField { get; set; }
        private string OrganizationFilter { get; set; }
        private string OrganizationXpath { get; set; }

        // Unit Test URL
        public override string Url => UrlDeterminer.GetSite(Constants.URL.Organization);

        //10.16.20 HP - Current Usage
        public Organization(bool open, IWebDriver browser, WebDriverWait browserWait, ITestOutputHelper output)
             : base(open, browser, browserWait)
        {
            Output = output;
            TraceLine = "Organization Starting...";
            if (open) Open();
            WaitForPinwheel(Core.Common.Constants.PINWHEELOVERLAY);
            TitleShouldBe(Constants.TITLE.Organization);
        }

        public bool SetSearchParameters(string orgName)
        {
            OrganizationFilter = Create_FilterField(orgName);
            OrganizationXpath = OrganizationNameFieldOptionsXpath;
            FilterField = OrganizationField;
            Set_Filter_Field_By_Text(FilterField, OrganizationFilter, OrganizationXpath, orgName);
            return true;
        }

        public bool GetOrganization(string orgName)
        {
            var org = OrganizationSearchResults(orgName);
            return org;
        }

    }
}
