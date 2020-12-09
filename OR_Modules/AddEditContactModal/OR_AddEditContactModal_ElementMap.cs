using OpenQA.Selenium;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
using Core.Base;
using Core.Driver;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;
using System.Reflection;

namespace OR_AddEditContactModal
{
    public partial class AddEditContactModal
    {
        public IWebElement iframeTitle(string iframe) => Browser.FindElement(By.TagName(iframe));
        public IWebElement AddressLine1Field => Browser.FindElement(By.Id("AddressLine1Field"));
        public IWebElement AddressLine2Field => Browser.FindElement(By.Id("AddressLine2Field"));
        public IWebElement BusinessPhoneField => Browser.FindElement(By.Id("BusinessPhoneField"));
        public IWebElement CancelButton => Browser.FindElement(By.Id("CancelButton"));
        public IWebElement CityField => Browser.FindElement(By.Id("CityField"));
        public IWebElement CompanyPhoneField => Browser.FindElement(By.Id("CompanyPhoneField"));
        public IWebElement ContactAddressLine1Field => Browser.FindElement(By.Id("ContactAddressLine1Field"));
        public IWebElement ContactAddressLine2Field => Browser.FindElement(By.Id("ContactAddressLine2Field"));
        public IWebElement ContactCityField => Browser.FindElement(By.Id("ContactCityField"));
        public IWebElement ContactForm => Browser.FindElement(By.Id("ContactForm"));
        public IWebElement ContactStateField => Browser.FindElement(By.Id("ContactStateField"));
        public SelectElement ContactStateFieldOption => new SelectElement(ContactStateField);
        public ReadOnlyCollection<IWebElement> ContactStateFieldOptionsUl => Browser.FindElements(By.XPath("//*[@id='ContactStateFieldOptionsUl']//li//a"));
        public IWebElement ContactStateFieldSelectedAnchor => Browser.FindElement(By.Id("ContactStateFieldSelectedAnchor"));
        public IWebElement ContactZipField => Browser.FindElement(By.Id("ContactZipField"));
        public IWebElement EmailField => Browser.FindElement(By.Id("EmailField"));
        public IWebElement FirstNameField => Browser.FindElement(By.Id("FirstNameField"));
        public IWebElement GTCdc4f0f2a_94da_4ce7_81d7_300db3374933 => Browser.FindElement(By.Id("GTCdc4f0f2a_94da_4ce7_81d7_300db3374933"));
        public IWebElement LastNameField => Browser.FindElement(By.Id("LastNameField"));
        public IWebElement MiddleNameField => Browser.FindElement(By.Id("MiddleNameField"));
        public IWebElement MobilePhoneField => Browser.FindElement(By.Id("MobilePhoneField"));
        public IWebElement OrganizationNameFilteredField => Browser.FindElement(By.Id("OrganizationNameFilteredField"));
        public IWebElement OrganizationTypeField => Browser.FindElement(By.Id("OrganizationTypeField"));
        public SelectElement OrganizationTypeFieldOption => new SelectElement(OrganizationTypeField);
        public ReadOnlyCollection<IWebElement> OrganizationTypeFieldOptionsUl => Browser.FindElements(By.XPath("//*[@id='OrganizationTypeFieldOptionsUl']//li//a"));
        public IWebElement OrganizationTypeFieldSelectedAnchor => Browser.FindElement(By.Id("OrganizationTypeFieldSelectedAnchor"));
        public IWebElement OrganizationWebsiteField => Browser.FindElement(By.Id("OrganizationWebsiteField"));
        public IWebElement OwnerField => Browser.FindElement(By.Id("OwnerField"));
        public SelectElement OwnerFieldOption => new SelectElement(OwnerField);
        public ReadOnlyCollection<IWebElement> OwnerFieldOptionsUl => Browser.FindElements(By.XPath("//*[@id='OwnerFieldOptionsUl']//li//a"));
        public IWebElement OwnerFieldSelectedAnchor => Browser.FindElement(By.Id("OwnerFieldSelectedAnchor"));
        public IWebElement ProgramField => Browser.FindElement(By.Id("ProgramField"));
        public SelectElement ProgramFieldOption => new SelectElement(ProgramField);
        public ReadOnlyCollection<IWebElement> ProgramFieldOptionsUl => Browser.FindElements(By.XPath("//*[@id='ProgramFieldOptionsUl']//li//a"));
        public IWebElement ProgramFieldSelectedAnchor => Browser.FindElement(By.Id("ProgramFieldSelectedAnchor"));
        public IWebElement SameAddressField => Browser.FindElement(By.Id("SameAddressField"));
        public IWebElement SaveButton => Browser.FindElement(By.Id("SaveButton"));
        public IWebElement SectorField => Browser.FindElement(By.Id("SectorField"));
        public SelectElement SectorFieldOption => new SelectElement(SectorField);
        public ReadOnlyCollection<IWebElement> SectorFieldOptionsUl => Browser.FindElements(By.XPath("//*[@id='SectorFieldOptionsUl']//li//a"));
        public IWebElement SectorFieldSelectedAnchor => Browser.FindElement(By.Id("SectorFieldSelectedAnchor"));
        public IWebElement SkipToMainContent508 => Browser.FindElement(By.Id("SkipToMainContent508"));
        public IWebElement SolicitationField => Browser.FindElement(By.Id("SolicitationField"));
        public SelectElement SolicitationFieldOption => new SelectElement(SolicitationField);
        public ReadOnlyCollection<IWebElement> SolicitationFieldOptionsUl => Browser.FindElements(By.XPath("//*[@id='SolicitationFieldOptionsUl']//li//a"));
        public IWebElement SolicitationFieldSelectedAnchor => Browser.FindElement(By.Id("SolicitationFieldSelectedAnchor"));
        public IWebElement StateField => Browser.FindElement(By.Id("StateField"));
        public SelectElement StateFieldOption => new SelectElement(StateField);
        public ReadOnlyCollection<IWebElement> StateFieldOptionsUl => Browser.FindElements(By.XPath("//*[@id='StateFieldOptionsUl']//li//a"));
        public IWebElement StateFieldSelectedAnchor => Browser.FindElement(By.Id("StateFieldSelectedAnchor"));
        public IWebElement TitleField => Browser.FindElement(By.Id("TitleField"));
        public IWebElement ZipField => Browser.FindElement(By.Id("ZipField"));
    }
}
