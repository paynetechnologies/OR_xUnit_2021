using System;
using System.Drawing;
using OpenQA.Selenium;
using Xunit;
using Shouldly;
using OpenQA.Selenium.Firefox;

namespace Core.Driver
{
    public class StaticWebDriverFactoryTests : IDisposable
    {
        private IWebDriver Driver { get; set; }
        //private readonly PlatformType thisPlatformType = PlatformType.Windows;

        //[OneTimeSetUp]
        public StaticWebDriverFactoryTests() // CheckForValidPlatform()
        {
            //Assume.That(() => Platform.CurrentPlatform.IsPlatformType(thisPlatformType));
        }

        [Theory]
        [InlineData(BrowserTypes.Firefox)]
        [InlineData(BrowserTypes.InternetExplorer)]
        [InlineData(BrowserTypes.Edge)]
        [InlineData(BrowserTypes.Chrome)]
        public void LocalWebDriverCanBeLaunchedAndLoadExampleDotCom(BrowserTypes browser)
        {
            Driver = StaticWebDriverFactory.GetLocalWebDriver(browser);
            Driver.Url = "https://example.com/";
            Driver.Title.ShouldBe("Example Domain");
        }

        //[Theory]
        //[InlineData(BrowserTypes.Safari)]
        //public void RequestingUnsupportedWebDriverThrowsInformativeException(BrowserTypes browser)
        //{
        //    Action act = () => StaticWebDriverFactory.GetLocalWebDriver(browser);

        //    //public static TException ShouldThrow<TException>(this Action actual) where TException : Exception;
        //    act.ShouldThrow<PlatformNotSupportedException>($"because {browser} is not supported on {thisPlatformType}.")
        //        .Message.ShouldBe("*is only available on*");
        //    //act.Should()
        //    //    .Throw<PlatformNotSupportedException>($"because {browser} is not supported on {thisPlatformType}.")
        //    //    .WithMessage("*is only available on*");
        //}

        [Theory]
        [InlineData(BrowserTypes.Firefox)]
        [InlineData(BrowserTypes.Chrome)]
        public void HeadlessBrowsersCanBeLaunched(BrowserTypes browser)
        {
            Driver = StaticWebDriverFactory.GetLocalWebDriver(browser, true);
            Driver.Url = "https://example.com/";
            Driver.Title.ShouldBe("Example Domain");
        }


        [Theory]
        [InlineData(BrowserTypes.Edge)]
        [InlineData(BrowserTypes.InternetExplorer)]
        [InlineData(BrowserTypes.Safari)]
        public void RequestingUnsupportedHeadlessBrowserThrowsInformativeException(BrowserTypes browser)
        {
            Action act = () => StaticWebDriverFactory.GetLocalWebDriver(browser, true);

            act.ShouldThrow<ArgumentException>($"because headless mode is not supported on {browser}.")
                .Message.ShouldBe($"Headless mode is not currently supported for {browser}.");
        }

        [Fact]
        public void HdBrowserIsOfRequestedSize()
        {
            //Driver = StaticWebDriverFactory.GetLocalWebDriver(StaticDriverOptionsFactory.GetFirefoxOptions(true), WindowSize.HD);
            Driver = StaticWebDriverFactory.GetLocalWebDriver<FirefoxDriver, FirefoxOptions>(StaticDriverOptionsFactory.GetFirefoxOptions(true));

            Size size = Driver.Manage().Window.Size;
            size.ShouldSatisfyAllConditions
            (
                () => size.Width.ShouldBe(1366),
                () => size.Height.ShouldBe(768)
            );
        }

        [Fact]
        public void FhdBrowserIsOfRequestedSize()
        {
            Driver = StaticWebDriverFactory.GetLocalWebDriver(StaticDriverOptionsFactory.GetFirefoxOptions(true), WindowSize.FHD);

            Size size = Driver.Manage().Window.Size;
            size.ShouldSatisfyAllConditions
            (
                () => size.Height.ShouldBe(1080),
                () => size.Width.ShouldBe(1920)
            );
        }

        [Fact]
        public void Uhd4KBrowserIsOfRequestedSize()
        {
            Driver = StaticWebDriverFactory.GetLocalWebDriver(StaticDriverOptionsFactory.GetFirefoxOptions(true), WindowSize.UHD4K);
            Size size = Driver.Manage().Window.Size;
            size.ShouldSatisfyAllConditions
            (
                () => size.Height.ShouldBe(2160),
                () => size.Width.ShouldBe(3840)
            );
        }

        //[Theory]
        //[InlineData(BrowserTypes.Chrome, PlatformType.Windows)]
        //[InlineData(BrowserTypes.Edge, PlatformType.Windows)]
        //[InlineData(BrowserTypes.Firefox, PlatformType.Windows)]
        //[InlineData(BrowserTypes.InternetExplorer, PlatformType.Windows)]
        //[InlineData(BrowserTypes.Chrome, PlatformType.Linux)]
        //[InlineData(BrowserTypes.Firefox, PlatformType.Linux)]
        //public void RemoteWebDriverCanBeLaunched(BrowserTypes browser, PlatformType platformType)
        //{
        //    Driver = StaticWebDriverFactory.GetRemoteWebDriver(browser, new Uri("http://192.168.0.200:4444/wd/hub"), platformType);
        //    Driver.Url = "https://example.com/";
        //    Driver.Title.ShouldBe("Example Domain");
        //}

        public void Dispose()
        {
            Driver?.Quit();
        }
    }
}