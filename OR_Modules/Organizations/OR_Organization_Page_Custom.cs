//Generated : 2020-12-17
using Core.Base;
using Core.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OR_Modules.Configuration;
using Shouldly;
using System.Reflection;
using Xunit.Abstractions;

namespace OR_Modules.Organization
{
    public partial class Organization
    {
        public string Organization_Name_Value { get; set; }

        public bool OrganizationSearchResults(string organizationName)
        {
            PrintCurrentMethod(MethodBase.GetCurrentMethod());

            WaitFor.WaitForPageLoad();

            // DispalyDetails are defined locally in order to refresh the panel...
            // The first time the page is displayed, the panel contains default initial results; 
            // After running the search, the panel contains new search results, i.e, based on the search criteria. 
            // Defining locally, avoids the "Stale References" error...
            //var OrganizationsDisplayDetails = Browser.FindElements(By.XPath("//*[@id='OrganizationsPanel-container']/div[@data-namespace='DisplayDetail']"));
            // Defined locally becomes: 
            var OrganizationsDisplayDetails = Browser.FindElements(By.XPath("//*[@id='OrganizationsPanel']/div[2]/div[@data-namespace='DisplayDetail']"));

            TraceLine = "(bool result, IWebElement row) = Get_Row_In_Search_Results(";
            (bool result, IWebElement row) = Get_Row_In_Search_Results( OrganizationsDisplayDetails
                                                                        , OrganizationsPanelTitle
                                                                        , OrganizationLinkDisplayItem
                                                                        , organizationName);

            DetailRow = row; // defined in Base class as public IWebElement DetailRow { get; set; }

            if (!result)
            {
                TraceFailed.ShouldBe(TraceLine);
                return false;
            }

            TraceLine = "Get_DisplayDetail_ItemValue(DetailRow, By.XPath(ProjectUpdateLoanMonitoringStatusItem_Text));";
            var (result2, value) = Get_DisplayDetail_ItemValue(DetailRow, By.XPath(OrganizationLinkDisplayItem_Text));

            if (result2)
            {
                Organization_Name_Value = value;
                return (true);
            }

            return false;
        }
    }
}
