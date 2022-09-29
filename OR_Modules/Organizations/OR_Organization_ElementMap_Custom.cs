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
        //id="OrganizationsPanel"
        //*[@id="OrganizationsPanel-container"]

        //*[@id="OrganizationLinkDisplayItem"]



        public string OrganizationNameFieldOptionsXpath = "//*[@id='OrganizationFieldOptionsSpan']//ul//li";
        public IWebElement OrganizationDisplayDetail => Browser.FindElement(By.Id("OrganizationDisplayDetail"));

        // Organization Details
        private static readonly string OrganizationLinkDisplayItem = "OrganizationLinkDisplayItem";
        private static readonly string OrganizationsPanelTitle = "OrganizationsHeading";
        //public IWebElement OrganizationsPanelTitle => Browser.FindElement(By.Id("OrganizationsHeading"));
        public ReadOnlyCollection<IWebElement> OrganizationsDisplayDetails => Browser.FindElements(By.XPath("//*[@id='OrganizationsPanel-container']/div[@data-namespace='DisplayDetail']"));


        // Display Detail Item
        // From the root use //*
        //private static readonly string OrganizationLinkDisplayItem_Text = @"//*[@id='OrganizationLinkDisplayItem']/span[2]";
        // From the current Node use .//
        public static readonly string OrganizationLinkDisplayItem_Text = @".//li[@id='OrganizationLinkDisplayItem']/span[2]";

    }
}