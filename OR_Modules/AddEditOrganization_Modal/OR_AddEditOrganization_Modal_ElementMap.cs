using OpenQA.Selenium;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
using Core.Base;
using Core.Driver;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;
using System.Reflection;

namespace OR_AddEditOrganization_Modal
{
    public partial class AddEditOrganization_Modal
    {
        public IWebElement iframeTitle(string iframe) => Browser.FindElement(By.TagName(iframe));
        public IWebElement AddEditOrganizationForm => Browser.FindElement(By.Id("AddEditOrganizationForm"));
        public IWebElement AddressLine2TextField => Browser.FindElement(By.Id("AddressLine2TextField"));
        public IWebElement AddressTextField => Browser.FindElement(By.Id("AddressTextField"));
        public IWebElement CancelButton => Browser.FindElement(By.Id("CancelButton"));
        public IWebElement CityTextField => Browser.FindElement(By.Id("CityTextField"));
        public IWebElement OrganizationNameTextField => Browser.FindElement(By.Id("OrganizationNameTextField"));
        public IWebElement OrganizationPhoneTextField => Browser.FindElement(By.Id("OrganizationPhoneTextField"));
        public IWebElement OrganizationTypeSelectField => Browser.FindElement(By.Id("OrganizationTypeSelectField"));
        public SelectElement OrganizationTypeSelectFieldOption => new SelectElement(OrganizationTypeSelectField);
        public ReadOnlyCollection<IWebElement> OrganizationTypeSelectFieldOptionsUl => Browser.FindElements(By.XPath("//*[@id='OrganizationTypeSelectFieldOptionsUl']//li//a"));
        public IWebElement OrganizationTypeSelectFieldSelectedAnchor => Browser.FindElement(By.Id("OrganizationTypeSelectFieldSelectedAnchor"));
        public IWebElement OrganizationWebsiteTextField => Browser.FindElement(By.Id("OrganizationWebsiteTextField"));
        public IWebElement ProgramsCheckboxFieldGTCUn6DedTUYoYkAj2DhhBOzg6161 => Browser.FindElement(By.Id("ProgramsCheckboxFieldGTCUn6DedTUYoYkAj2DhhBOzg6161"));
        public IWebElement ProgramsCheckboxFieldGTCg6yLH436BQQ9C9QQzKBBBGw6161 => Browser.FindElement(By.Id("ProgramsCheckboxFieldGTCg6yLH436BQQ9C9QQzKBBBGw6161"));
        public IWebElement ProgramsCheckboxFieldGTCoR8of2mFXo47s6Nq0xHb8kA6161 => Browser.FindElement(By.Id("ProgramsCheckboxFieldGTCoR8of2mFXo47s6Nq0xHb8kA6161"));
        public IWebElement SaveButton => Browser.FindElement(By.Id("SaveButton"));
        public IWebElement SkipToMainContent508 => Browser.FindElement(By.Id("SkipToMainContent508"));
        public IWebElement StateSelectField => Browser.FindElement(By.Id("StateSelectField"));
        public SelectElement StateSelectFieldOption => new SelectElement(StateSelectField);
        public ReadOnlyCollection<IWebElement> StateSelectFieldOptionsUl => Browser.FindElements(By.XPath("//*[@id='StateSelectFieldOptionsUl']//li//a"));
        public IWebElement StateSelectFieldSelectedAnchor => Browser.FindElement(By.Id("StateSelectFieldSelectedAnchor"));
        public IWebElement ZipCodeTextField => Browser.FindElement(By.Id("ZipCodeTextField"));
    }
}
