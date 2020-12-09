using OpenQA.Selenium;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
using Core.Base;
using Core.Driver;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;
using System.Reflection;

namespace OR_AddEditAppointmentModal
{
    public partial class AddEditAppointmentModal
    {
        public IWebElement iframeTitle(string iframe) => Browser.FindElement(By.TagName(iframe));
        public IWebElement AnchorOpenCalendar_FollowupEndField => Browser.FindElement(By.Id("AnchorOpenCalendar_FollowupEndField"));
        public IWebElement AnchorOpenCalendar_FollowupStartField => Browser.FindElement(By.Id("AnchorOpenCalendar_FollowupStartField"));
        public IWebElement CancelButton => Browser.FindElement(By.Id("CancelButton"));
        public IWebElement ContactField => Browser.FindElement(By.Id("ContactField"));
        public IWebElement DailyEveryNDaysField => Browser.FindElement(By.Id("DailyEveryNDaysField"));
        public IWebElement DailyWeekdayOnlyField => Browser.FindElement(By.Id("DailyWeekdayOnlyField"));
        public IWebElement FollowupAllDayField => Browser.FindElement(By.Id("FollowupAllDayField"));
        public IWebElement FollowupEndField => Browser.FindElement(By.Id("FollowupEndField"));
        public IWebElement FollowupForm => Browser.FindElement(By.Id("FollowupForm"));
        public IWebElement FollowupRecurrenceFieldGTCQVxZqURnpQmc43hunYrsSPw6161 => Browser.FindElement(By.Id("FollowupRecurrenceFieldGTCQVxZqURnpQmc43hunYrsSPw6161"));
        public IWebElement FollowupRecurrenceFieldGTCUn6DedTUYoYkAj2DhhBOzg6161 => Browser.FindElement(By.Id("FollowupRecurrenceFieldGTCUn6DedTUYoYkAj2DhhBOzg6161"));
        public IWebElement FollowupRecurrenceFieldGTCbZf5Z47ikQdfFCaLS3lMYtA6161 => Browser.FindElement(By.Id("FollowupRecurrenceFieldGTCbZf5Z47ikQdfFCaLS3lMYtA6161"));
        public IWebElement FollowupRecurrenceFieldGTCg6yLH436BQQ9C9QQzKBBBGw6161 => Browser.FindElement(By.Id("FollowupRecurrenceFieldGTCg6yLH436BQQ9C9QQzKBBBGw6161"));
        public IWebElement FollowupRecurrenceFieldGTCoR8of2mFXo47s6Nq0xHb8kA6161 => Browser.FindElement(By.Id("FollowupRecurrenceFieldGTCoR8of2mFXo47s6Nq0xHb8kA6161"));
        public IWebElement FollowupRemoveButton => Browser.FindElement(By.Id("FollowupRemoveButton"));
        public IWebElement FollowupSaveButton => Browser.FindElement(By.Id("FollowupSaveButton"));
        public IWebElement FollowupStartField => Browser.FindElement(By.Id("FollowupStartField"));
        public IWebElement FollowupSubjectField => Browser.FindElement(By.Id("FollowupSubjectField"));
        public IWebElement FollowupTypeField => Browser.FindElement(By.Id("FollowupTypeField"));
        public SelectElement FollowupTypeFieldOption => new SelectElement(FollowupTypeField);
        public ReadOnlyCollection<IWebElement> FollowupTypeFieldOptionsUl => Browser.FindElements(By.XPath("//*[@id='FollowupTypeFieldOptionsUl']//li//a"));
        public IWebElement FollowupTypeFieldSelectedAnchor => Browser.FindElement(By.Id("FollowupTypeFieldSelectedAnchor"));
        public IWebElement GTC04948bdd_4f40_4f34_a251_ff7888309b08 => Browser.FindElement(By.Id("GTC04948bdd_4f40_4f34_a251_ff7888309b08"));
        public IWebElement GTCa0098f11_8abc_4d77_b11a_f11e5007adc1 => Browser.FindElement(By.Id("GTCa0098f11_8abc_4d77_b11a_f11e5007adc1"));
        public IWebElement IsCompleteSwitchField => Browser.FindElement(By.Id("IsCompleteSwitchField"));
        public IWebElement MonthlyEveryNMonthsField => Browser.FindElement(By.Id("MonthlyEveryNMonthsField"));
        public IWebElement OrganizationField => Browser.FindElement(By.Id("OrganizationField"));
        public IWebElement OwnerField => Browser.FindElement(By.Id("OwnerField"));
        public SelectElement OwnerFieldOption => new SelectElement(OwnerField);
        public ReadOnlyCollection<IWebElement> OwnerFieldOptionsUl => Browser.FindElements(By.XPath("//*[@id='OwnerFieldOptionsUl']//li//a"));
        public IWebElement OwnerFieldSelectedAnchor => Browser.FindElement(By.Id("OwnerFieldSelectedAnchor"));
        public IWebElement SkipToMainContent508 => Browser.FindElement(By.Id("SkipToMainContent508"));
        public IWebElement WeeklyEveryNWeeksField => Browser.FindElement(By.Id("WeeklyEveryNWeeksField"));
        public IWebElement WeeklyWeekdayField => Browser.FindElement(By.Id("WeeklyWeekdayField"));
        public SelectElement WeeklyWeekdayFieldOption => new SelectElement(WeeklyWeekdayField);
        public ReadOnlyCollection<IWebElement> WeeklyWeekdayFieldOptionsUl => Browser.FindElements(By.XPath("//*[@id='WeeklyWeekdayFieldOptionsUl']//li//a"));
        public IWebElement WeeklyWeekdayFieldSelectedAnchor => Browser.FindElement(By.Id("WeeklyWeekdayFieldSelectedAnchor"));
        public IWebElement YearlyEveryNYearsField => Browser.FindElement(By.Id("YearlyEveryNYearsField"));
        public IWebElement cke_15 => Browser.FindElement(By.Id("cke_15"));
        public IWebElement cke_16 => Browser.FindElement(By.Id("cke_16"));
        public IWebElement cke_18 => Browser.FindElement(By.Id("cke_18"));
        public IWebElement cke_19 => Browser.FindElement(By.Id("cke_19"));
        public IWebElement cke_20 => Browser.FindElement(By.Id("cke_20"));
        public IWebElement cke_21 => Browser.FindElement(By.Id("cke_21"));
        public IWebElement cke_23 => Browser.FindElement(By.Id("cke_23"));
        public IWebElement cke_24 => Browser.FindElement(By.Id("cke_24"));
        public IWebElement cke_25 => Browser.FindElement(By.Id("cke_25"));
        public IWebElement cke_26 => Browser.FindElement(By.Id("cke_26"));
        public IWebElement cke_27 => Browser.FindElement(By.Id("cke_27"));
        public IWebElement cke_28 => Browser.FindElement(By.Id("cke_28"));
        public IWebElement cke_30 => Browser.FindElement(By.Id("cke_30"));
        public IWebElement cke_33 => Browser.FindElement(By.Id("cke_33"));
        public IWebElement cke_34 => Browser.FindElement(By.Id("cke_34"));
    }
}
