using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Core.Driver
{
    public class WaitFor
    {
        public static void WaitForModalResize()
        {
            //WebDriverWait wait = new WebDriverWait(WebDriver.Browser, TimeSpan.FromSeconds(30));
            //wait.Until(driver =>
            //((IJavaScriptExecutor)driver).ExecuteScript(
            //    "$(parent.document.body).on('modalviewloadingcomplete', function(){return true;});"));

            //IJavaScriptExecutor js = (IJavaScriptExecutor)WebDriver.Browser;
            //WebDriverWait wait = new WebDriverWait(WebDriver.Browser, TimeSpan.FromSeconds(30));
            //wait.Until(driver => js.ExecuteScript("console.log($._data( $(parent.document.body), 'events' ));"));
            //"$(document.body).on('modalviewloadingcomplete', function(){return true;});"));

        }


        public static void WaitForPageLoad()
        {
            WaitFor.WaitForPageLoad(WebDriver.Browser, TimeSpan.FromSeconds(60));
        }

        protected void WaitForPageLoad(WebDriverWait wait)
        {
            wait.Until(driver => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));
        }

        public void WaitForReady(IWebDriver driver, TimeSpan seconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, seconds);
            wait.Until(d =>
            {
                return WaitForPageLoad(driver, seconds);
            });
        }

        public static bool WaitForPageLoad(IWebDriver driver, TimeSpan waitTime)
        {
            WaitForDocumentReady(driver, waitTime);
            bool ajaxReady = WaitForAjaxReady(driver, waitTime);
            WaitForDocumentReady(driver, waitTime);
            return ajaxReady;
        }

        private static bool WaitForAjaxReady(IWebDriver driver, TimeSpan waitTime)
        {
            System.Threading.Thread.Sleep(2000);
            WebDriverWait wait = new WebDriverWait(driver, waitTime);
            return wait.Until<bool>((d) =>
            {
                return driver.FindElements(By.CssSelector(".waiting, .tb-loading")).Count == 0;
            });
        }

        private static void WaitForDocumentReady(IWebDriver driver, TimeSpan waitTime)
        {
            var wait = new WebDriverWait(driver, waitTime);
            var javascript = driver as IJavaScriptExecutor;

            if (javascript == null)
                throw new ArgumentException("driver", "Driver must support javascript execution");

            wait.Until((d) =>
            {
                try
                {
                    string readyState = javascript.ExecuteScript(
                        "if (document.readyState) return document.readyState;").ToString();
                    return readyState.ToLower() == "complete";
                }
                catch (InvalidOperationException e)
                {
                    return e.Message.ToLower().Contains("unable to get browser");
                }
                catch (WebDriverException e)
                {
                    return e.Message.ToLower().Contains("unable to connect");
                }
                catch (Exception)
                {
                    return false;
                }
            });
        }

        public static bool WaitForJQuery(IWebDriver driver, TimeSpan waitTime)
        {
            var wait = new WebDriverWait(driver, waitTime);
            var javascript = driver as IJavaScriptExecutor;

            if (javascript == null)
            {
                throw new ArgumentException("driver", "Driver must support javascript execution");
            }

            wait.Until((d) =>
            {
                try
                {
                    string jQueryReady = javascript.ExecuteScript(
                        "return (typeof jQuery != 'undefined')").ToString();
                    return jQueryReady  == "True";
                }
                catch (InvalidOperationException e)
                {
                    //return false;
                    return e.Message.ToLower().Contains("unable to get browser");
                }
                catch (WebDriverException e)
                {
                    //return false;
                    return e.Message.ToLower().Contains("unable to connect");
                }
                catch (Exception)
                {
                    return false;
                }
            });
            return true;
        }
    }
}
//WebDriverWait wait = new WebDriverWait(WebDriver.Browser, TimeSpan.FromSeconds(30));
//wait.Until(driver =>
//((IJavaScriptExecutor)driver).ExecuteScript(
//    "var jqObj = $(parent.document.body);" +
//    "var getObj = jqObj.get(0);" +
//    "var eventsObj = $._data(getObj, 'events');" +
//    "$.each(eventsObj, function(i, o) { console.log('logging... ' + i); console.log('logging2... ' + o)});"));
//    //" jqObj.on('modalviewloadingcomplete', function(){ return True; });" + 


//wait.Until(driver =>
//((IJavaScriptExecutor)driver).ExecuteScript(
//    "var jqueryObject = $(parent.document.body);" +
//    "var rawDOMElement = jqueryObject.get(0);" +
//    "var eventObj = $._data(rawDOMElement, 'events');" +
//    "$.each(eventObj, function(i, o) { alert(i); alert(o)}); return true;"));

//"if (eventObj == 'undefined') {alert(false); return false}" +
//"else { $.each(eventObj, function(i, o) { alert(i); alert(o)}); return true;}")); 
