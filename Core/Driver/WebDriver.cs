using Core.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;

namespace Core.Driver
{
    public static class WebDriver
    {
        private static WebDriverWait browserWait;
        private static IWebDriver browser;

        public static IWebDriver Browser
        {
            get
            {
                if (browser == null)
                {
                    throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method Start.");
                }
                return browser;
            }
            private set
            {
                browser = value;
            }
        }

        public static WebDriverWait BrowserWait
        {
            get
            {
                if (browserWait == null || browser == null)
                {
                    throw new NullReferenceException("The WebDriver browser wait instance was not initialized. You should first call the method Start.");
                }
                return browserWait;
            }
            private set
            {
                browserWait = value;
            }
        }

        /// <summary>
        /// Reflection does not behave the same way from a packaged library as an included project.
        /// https://alexanderontesting.com/2018/12/19/releasing-a-net-standard-library-lessons-learned-the-hard-way/
        /// </summary>
        /// <param name="browserType"></param>
        /// <param name="defaultTimeOut"></param>
        public static void StartBrowser(BrowserTypes browserType = BrowserTypes.Chrome, int defaultTimeOut = 45)
        {
            switch (browserType)
            {
                case BrowserTypes.Chrome:
                    // Reflection may fail and require an instance class
                    Browser = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                    //Browser = StaticWebDriverFactory.GetLocalWebDriver(browserType, true);
                    break;
                case BrowserTypes.Firefox:
                    // Reflection may fail and require an instance class
                    Browser = new FirefoxDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                    break;
                case BrowserTypes.InternetExplorer:
                    Browser = new InternetExplorerDriver();
                    break;
                default:
                    Browser = new ChromeDriver();
                    break;
            }
            BrowserWait = new WebDriverWait(WebDriver.Browser, TimeSpan.FromSeconds(defaultTimeOut));
            //BrowserWait = new WebDriverWait(WebDriver.Browser
            //    , TimeSpan.FromSeconds(ConfigurationService.Instance.GetWebSettings().Chrome.PageLoadTimeout));
        }

        public static void StopBrowser()
        {
            Browser.Quit();
            Browser = null;
            BrowserWait = null;
        }
    }
}
