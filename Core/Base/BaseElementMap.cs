using Core.Common;
using Core.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Shouldly;
using System;
using System.Reflection;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace Core.Base
{
    public abstract partial class BasePage
    {
        // Page specific as some pages have only one icon an others have multiple icons
        // Use the new keyword when overriding in pages...
        //public static readonly string Dollar_Icon_Hyperlink = @"[data-namespace='Hyperlink']:nth-child(1)";
        //public static readonly string Eye_Icon_Hyperlink = @"[data-namespace='Hyperlink']:nth-child(2)";


        #region Clickability

        /// <summary>
        /// An expectation for checking whether an element is visible.
        /// </summary>
        /// <param name="locator">The locator used to find the element.</param>
        /// <returns>The <see cref="IWebElement"/> once it is located, visible and clickable.</returns>
        public static Func<IWebDriver, IWebElement> ElementIsClickable(By locator)
        {
            return driver =>
            {
                var element = driver.FindElement(locator);
                return (element != null && element.Displayed && element.Enabled) ? element : null;
            };
        }

        public virtual bool IsClickable(By by)
        {
            try
            {
                var found = BrowserWait.Until(condition: ExpectedConditions.ElementToBeClickable(by));
                if (found != null)
                    return true;
                return false;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public virtual bool IsClickable(IWebElement element)
        {
            try
            {
                var found = BrowserWait.Until(condition: ExpectedConditions.ElementToBeClickable(element));
                if (found != null)
                    return true;
                return false;

            }
            catch (NoSuchElementException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion




        #region Readiness

        public virtual bool IsReady(By by)
        {
            BrowserWait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));

            var element = BrowserWait.Until(condition =>
            {
                try
                {
                    var elementToBeDisplayed = Browser.FindElement(by);
                    return elementToBeDisplayed.Displayed;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });
            return element;
        }

        public virtual bool IsReady(IWebElement e)
        {
            BrowserWait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));

            var element = BrowserWait.Until(condition =>
            {
                try
                {
                    return e.Displayed;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });
            return element;
        }

        #endregion


        #region Presences

        public virtual bool IsElementPresent(By by)
        {
            try
            {
                Browser.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        #endregion


        #region Titles

        public virtual bool IsPageTitle(string title)
        {
            try
            {
                BrowserWait.Until(condition: ExpectedConditions.TitleContains(title));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public IWebElement Title => Browser.FindElement(By.TagName("title"));

        #endregion


        #region Visibility

        public virtual bool IsInvisible(By by)
        {
            try
            {
                BrowserWait.Until(condition: ExpectedConditions.InvisibilityOfElementLocated(by));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public virtual bool IsVisible(By by)
        {
            try
            {
                BrowserWait.Until(condition: ExpectedConditions.ElementIsVisible(by));
                return true;
            }
            catch (TimeoutException)
            {
                return false;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        #endregion

        #region Waits

        public bool WaitForPinwheel(string whichPinwheel)
        {
            return IsInvisible(By.Id(whichPinwheel));
        }

        public bool WaitForPage()
        {
            // Wait until a page is fully loaded via JavaScript
            //WebDriverWait wait = new WebDriverWait(.driver, TimeSpan.FromSeconds(30));
            //wait.Until((x) =>
            //{
            //    return ((IJavaScriptExecutor)this.driver).ExecuteScript(
            //        "return document.readyState").Equals("complete");
            //});

            var element = BrowserWait.Until(condition =>
            {
                try
                {
                    return ((IJavaScriptExecutor)Browser).ExecuteScript(
                        "return document.readyState").Equals("complete");
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });
            return element;
        }

        #endregion
    }
}
