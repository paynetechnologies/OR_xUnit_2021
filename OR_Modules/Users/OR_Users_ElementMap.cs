using OpenQA.Selenium;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
using Core.Base;
using Core.Driver;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;
using System.Reflection;

namespace OR_Users
{
    public partial class Users
    {
        public IWebElement AppLogoLink => Browser.FindElement(By.Id("AppLogoLink"));
        public IWebElement ClearButton => Browser.FindElement(By.Id("ClearButton"));
        public IWebElement ConfirmPasswordField => Browser.FindElement(By.Id("ConfirmPasswordField"));
        public IWebElement DeleteButtonGTC43rEp5MIm43i192h3Q47P01hw6161 => Browser.FindElement(By.Id("DeleteButtonGTC43rEp5MIm43i192h3Q47P01hw6161"));
        public IWebElement DeleteButtonGTC9Zhc69q8EYcqp47rdN3c47bQ6161 => Browser.FindElement(By.Id("DeleteButtonGTC9Zhc69q8EYcqp47rdN3c47bQ6161"));
        public IWebElement DeleteButtonGTCAkjVu8fUEI7v5fabM06iOQ6161 => Browser.FindElement(By.Id("DeleteButtonGTCAkjVu8fUEI7v5fabM06iOQ6161"));
        public IWebElement DeleteButtonGTCFUGctROr0Q64IHCHntfZXg6161 => Browser.FindElement(By.Id("DeleteButtonGTCFUGctROr0Q64IHCHntfZXg6161"));
        public IWebElement DeleteButtonGTCGgNcp7431YjKSjkAEB9P9Gw6161 => Browser.FindElement(By.Id("DeleteButtonGTCGgNcp7431YjKSjkAEB9P9Gw6161"));
        public IWebElement DeleteButtonGTCHULriW8VR1ScrzqTlS6mEw6161 => Browser.FindElement(By.Id("DeleteButtonGTCHULriW8VR1ScrzqTlS6mEw6161"));
        public IWebElement DeleteButtonGTCHuBInkDxgVgRQUVi6udgxg6161 => Browser.FindElement(By.Id("DeleteButtonGTCHuBInkDxgVgRQUVi6udgxg6161"));
        public IWebElement DeleteButtonGTCIx0grj6sCoZE48wtUARzrQ6161 => Browser.FindElement(By.Id("DeleteButtonGTCIx0grj6sCoZE48wtUARzrQ6161"));
        public IWebElement DeleteButtonGTCQ3shAdOb17HfiVqfvoWHxw6161 => Browser.FindElement(By.Id("DeleteButtonGTCQ3shAdOb17HfiVqfvoWHxw6161"));
        public IWebElement DeleteButtonGTCQVxZqURnpQmc43hunYrsSPw6161 => Browser.FindElement(By.Id("DeleteButtonGTCQVxZqURnpQmc43hunYrsSPw6161"));
        public IWebElement DeleteButtonGTCdxIsx8p6rcFAZVrhJ29N0g6161 => Browser.FindElement(By.Id("DeleteButtonGTCdxIsx8p6rcFAZVrhJ29N0g6161"));
        public IWebElement DeleteButtonGTCjxdVHNLAnHKcOWl47gqBjCg6161 => Browser.FindElement(By.Id("DeleteButtonGTCjxdVHNLAnHKcOWl47gqBjCg6161"));
        public IWebElement DeleteButtonGTClxKwojVt6dIbQqqSNZH1ow6161 => Browser.FindElement(By.Id("DeleteButtonGTClxKwojVt6dIbQqqSNZH1ow6161"));
        public IWebElement DeleteButtonGTCryhFF47lOVF43XceCRRlzj43w6161 => Browser.FindElement(By.Id("DeleteButtonGTCryhFF47lOVF43XceCRRlzj43w6161"));
        public IWebElement DeleteButtonGTCv06BT9CUn6wbiScachz43oA6161 => Browser.FindElement(By.Id("DeleteButtonGTCv06BT9CUn6wbiScachz43oA6161"));
        public IWebElement EditButtonGTC43rEp5MIm43i192h3Q47P01hw6161 => Browser.FindElement(By.Id("EditButtonGTC43rEp5MIm43i192h3Q47P01hw6161"));
        public IWebElement EditButtonGTC9Zhc69q8EYcqp47rdN3c47bQ6161 => Browser.FindElement(By.Id("EditButtonGTC9Zhc69q8EYcqp47rdN3c47bQ6161"));
        public IWebElement EditButtonGTCAkjVu8fUEI7v5fabM06iOQ6161 => Browser.FindElement(By.Id("EditButtonGTCAkjVu8fUEI7v5fabM06iOQ6161"));
        public IWebElement EditButtonGTCFUGctROr0Q64IHCHntfZXg6161 => Browser.FindElement(By.Id("EditButtonGTCFUGctROr0Q64IHCHntfZXg6161"));
        public IWebElement EditButtonGTCGgNcp7431YjKSjkAEB9P9Gw6161 => Browser.FindElement(By.Id("EditButtonGTCGgNcp7431YjKSjkAEB9P9Gw6161"));
        public IWebElement EditButtonGTCHULriW8VR1ScrzqTlS6mEw6161 => Browser.FindElement(By.Id("EditButtonGTCHULriW8VR1ScrzqTlS6mEw6161"));
        public IWebElement EditButtonGTCHuBInkDxgVgRQUVi6udgxg6161 => Browser.FindElement(By.Id("EditButtonGTCHuBInkDxgVgRQUVi6udgxg6161"));
        public IWebElement EditButtonGTCIx0grj6sCoZE48wtUARzrQ6161 => Browser.FindElement(By.Id("EditButtonGTCIx0grj6sCoZE48wtUARzrQ6161"));
        public IWebElement EditButtonGTCQ3shAdOb17HfiVqfvoWHxw6161 => Browser.FindElement(By.Id("EditButtonGTCQ3shAdOb17HfiVqfvoWHxw6161"));
        public IWebElement EditButtonGTCQVxZqURnpQmc43hunYrsSPw6161 => Browser.FindElement(By.Id("EditButtonGTCQVxZqURnpQmc43hunYrsSPw6161"));
        public IWebElement EditButtonGTCdxIsx8p6rcFAZVrhJ29N0g6161 => Browser.FindElement(By.Id("EditButtonGTCdxIsx8p6rcFAZVrhJ29N0g6161"));
        public IWebElement EditButtonGTCjxdVHNLAnHKcOWl47gqBjCg6161 => Browser.FindElement(By.Id("EditButtonGTCjxdVHNLAnHKcOWl47gqBjCg6161"));
        public IWebElement EditButtonGTClxKwojVt6dIbQqqSNZH1ow6161 => Browser.FindElement(By.Id("EditButtonGTClxKwojVt6dIbQqqSNZH1ow6161"));
        public IWebElement EditButtonGTCryhFF47lOVF43XceCRRlzj43w6161 => Browser.FindElement(By.Id("EditButtonGTCryhFF47lOVF43XceCRRlzj43w6161"));
        public IWebElement EditButtonGTCv06BT9CUn6wbiScachz43oA6161 => Browser.FindElement(By.Id("EditButtonGTCv06BT9CUn6wbiScachz43oA6161"));
        public IWebElement EmailField => Browser.FindElement(By.Id("EmailField"));
        public IWebElement FirstNameField => Browser.FindElement(By.Id("FirstNameField"));
        public IWebElement LastNameField => Browser.FindElement(By.Id("LastNameField"));
        public IWebElement LogoffLinkName => Browser.FindElement(By.Id("LogoffLinkName"));
        public IWebElement MiddeNameField => Browser.FindElement(By.Id("MiddeNameField"));
        public IWebElement PasswordField => Browser.FindElement(By.Id("PasswordField"));
        public IWebElement PhoneField => Browser.FindElement(By.Id("PhoneField"));
        public IWebElement QuickBackToTopLink => Browser.FindElement(By.Id("QuickBackToTopLink"));
        public IWebElement SaveButton => Browser.FindElement(By.Id("SaveButton"));
        public IWebElement SecurityGroupField => Browser.FindElement(By.Id("SecurityGroupField"));
        public SelectElement SecurityGroupFieldOption => new SelectElement(SecurityGroupField);
        public ReadOnlyCollection<IWebElement> SecurityGroupFieldOptionsUl => Browser.FindElements(By.XPath("//*[@id='SecurityGroupFieldOptionsUl']//li//a"));
        public IWebElement SecurityGroupFieldSelectedAnchor => Browser.FindElement(By.Id("SecurityGroupFieldSelectedAnchor"));
        public IWebElement SecurityGroupsLink => Browser.FindElement(By.Id("SecurityGroupsLink"));
        public IWebElement SkipToMainContent508 => Browser.FindElement(By.Id("SkipToMainContent508"));
        public IWebElement UserForm => Browser.FindElement(By.Id("UserForm"));
        public IWebElement UserPanel => Browser.FindElement(By.Id("UserPanel"));
        public IWebElement UsernameField => Browser.FindElement(By.Id("UsernameField"));
        public IWebElement UsersLink => Browser.FindElement(By.Id("UsersLink"));
    }
}
