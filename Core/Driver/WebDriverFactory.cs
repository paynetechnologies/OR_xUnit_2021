using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Safari;

namespace Core.Driver
{
    public static partial class StaticWebDriverFactory
    {
        private static string DriverPath => Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        public static IWebDriver GetLocalWebDriver(BrowserTypes browser, bool headless = false)
        {
            if (headless && !(browser == BrowserTypes.Chrome || browser == BrowserTypes.Firefox))
            {
                throw new ArgumentException($"Headless mode is not currently supported for {browser}.");
            }

            switch (browser)
            {
                case BrowserTypes.Firefox:
                    return GetLocalWebDriver<FirefoxDriver, FirefoxOptions>(StaticDriverOptionsFactory.GetFirefoxOptions(headless));

                case BrowserTypes.Chrome:
                    return GetLocalWebDriver<ChromeDriver, ChromeOptions>(StaticDriverOptionsFactory.GetChromeOptions(headless));

                case BrowserTypes.InternetExplorer:
                    return GetLocalWebDriver<InternetExplorerDriver, InternetExplorerOptions>(StaticDriverOptionsFactory.GetInternetExplorerOptions());

                case BrowserTypes.Edge:
                    return GetLocalWebDriver<EdgeDriver, EdgeOptions>(StaticDriverOptionsFactory.GetEdgeOptions());

                case BrowserTypes.Safari:
                    return GetLocalWebDriver<SafariDriver, SafariOptions>(StaticDriverOptionsFactory.GetSafariOptions());

                default:
                    throw new PlatformNotSupportedException($"{browser} is not currently supported.");
            }
        }

        //public static IWebDriver GetLocalWebDriver(ChromeOptions options, WindowSize windowSize = WindowSize.HD)
        //{
        //    IWebDriver driver = new ChromeDriver(DriverPath, options);
        //    return SetWindowSize(driver, windowSize);
        //}

        public static IWebDriver GetLocalWebDriver(FirefoxOptions options, WindowSize windowSize = WindowSize.HD)
        {
            //IWebDriver driver = new FirefoxDriver(DriverPath, options);
            //return SetWindowSize(driver, windowSize);
            return GetLocalWebDriver<FirefoxDriver, FirefoxOptions>(StaticDriverOptionsFactory.GetFirefoxOptions(false));

        }

        public static IWebDriver GetLocalWebDriver<D, O>(O options, WindowSize windowSize = WindowSize.HD) 
            where O : DriverOptions
            where D : RemoteWebDriver
        {
            //IWebDriver driver =  new D();
            IWebDriver driver = System.Activator.CreateInstance(typeof(D), DriverPath, options) as D; 
            return SetWindowSize(driver, windowSize);
        }

        //public static IWebDriver GetLocalWebDriver(EdgeOptions options, WindowSize windowSize = WindowSize.HD)
        //{
        //    if (!Platform.CurrentPlatform.IsPlatformType(PlatformType.WinNT))
        //    {
        //        throw new PlatformNotSupportedException("Microsoft Edge is only available on Microsoft Windows.");
        //    }

        //    IWebDriver driver = new EdgeDriver(DriverPath, options);
        //    return SetWindowSize(driver, windowSize);
        //}

        //public static IWebDriver GetLocalWebDriver(InternetExplorerOptions options, WindowSize windowSize = WindowSize.HD)
        //{
        //    if (!Platform.CurrentPlatform.IsPlatformType(PlatformType.WinNT))
        //    {
        //        throw new PlatformNotSupportedException("Microsoft Internet Explorer is only available on Microsoft Windows.");
        //    }

        //    IWebDriver driver = new InternetExplorerDriver(DriverPath, options);
        //    return SetWindowSize(driver, windowSize);
        //}

        //public static IWebDriver GetLocalWebDriver(SafariOptions options, WindowSize windowSize = WindowSize.HD)
        //{
        //    if (!Platform.CurrentPlatform.IsPlatformType(PlatformType.Mac))
        //    {
        //        throw new PlatformNotSupportedException("Safari is only available on Mac Os.");
        //    }

        //    // I suspect that the SafariDriver is already on the path as it is within the Safari executable.
        //    // I currently have no means to test this
        //    IWebDriver driver = new SafariDriver(options);
        //    return SetWindowSize(driver, windowSize);
        //}

        public static IWebDriver GetRemoteWebDriver( DriverOptions options, Uri gridUrl, WindowSize windowSize = WindowSize.HD)
        {
            IWebDriver driver = new RemoteWebDriver(gridUrl, options);
            return SetWindowSize(driver, windowSize);
        }

        public static IWebDriver GetRemoteWebDriver( BrowserTypes browser,  Uri gridUrl, PlatformType platformType = PlatformType.Any)
        {
            switch (browser)
            {
                case BrowserTypes.Firefox:
                    return GetRemoteWebDriver(StaticDriverOptionsFactory.GetFirefoxOptions(platformType), gridUrl);

                case BrowserTypes.Chrome:
                    return GetRemoteWebDriver(StaticDriverOptionsFactory.GetChromeOptions(platformType), gridUrl);

                case BrowserTypes.InternetExplorer:
                    return GetRemoteWebDriver(StaticDriverOptionsFactory.GetInternetExplorerOptions(platformType), gridUrl);

                case BrowserTypes.Edge:
                    return GetRemoteWebDriver(StaticDriverOptionsFactory.GetEdgeOptions(platformType), gridUrl);

                case BrowserTypes.Safari:
                    return GetRemoteWebDriver(StaticDriverOptionsFactory.GetSafariOptions(platformType), gridUrl);

                default:
                    throw new PlatformNotSupportedException($"{browser} is not currently supported.");
            }
        }

        public static IWebDriver SetWindowSize(IWebDriver driver, WindowSize windowSize)
        {
            switch (windowSize)
            {
                case WindowSize.UNCHANGED:
                    return driver;

                case WindowSize.MAXIMIZE:
                    driver.Manage().Window.Maximize();
                    return driver;

                case WindowSize.HD:
                    driver.Manage().Window.Position = Point.Empty;
                    driver.Manage().Window.Size = new Size(1366, 768);
                    return driver;

                case WindowSize.FHD:
                    driver.Manage().Window.Position = Point.Empty;
                    driver.Manage().Window.Size = new Size(1920, 1080);
                    return driver;

                case WindowSize.UHD4K:
                    driver.Manage().Window.Position = Point.Empty;
                    driver.Manage().Window.Size = new Size(3840, 2160);
                    return driver;

                default:
                    return driver;
            }
        }
    }
}