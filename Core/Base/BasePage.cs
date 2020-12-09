using Core.Common;
using Core.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;

namespace Core.Base
{
    public abstract partial class BasePage : Trace_Utilities,  IDisposable
    {
        #region Properties

        public abstract string Url { get; }
        public IWebDriver Browser { get; set; }
        public WebDriverWait BrowserWait { get; set; }
        public IWebElement DetailRow { get; set; }

        #endregion

        #region Constuctors

        public BasePage() : this(BrowserTypes.Chrome) { }

        public BasePage(BrowserTypes bt)
        {
            DisposeDriverService.TestRunStartTime = DateTime.Now;
            WebDriver.StartBrowser(bt);
            WebDriver.Browser.Manage().Window.Maximize();
            BrowserWait = WebDriver.BrowserWait;
            Browser = WebDriver.Browser;
        }

        public BasePage(bool open, IWebDriver browser, WebDriverWait browserWait)
        {
            Browser = browser;
            BrowserWait = browserWait;
        }

        public BasePage(IWebDriver browser, WebDriverWait browserWait)
        {
            Browser = browser;
            BrowserWait = browserWait;
        }

        #endregion

        #region Buttons

        public bool Click_Eye_Icon(IWebElement row, By by)
        {
            PrintCurrentMethod(MethodBase.GetCurrentMethod());

            TraceLine = "if (IsClickable(by))";
            if (IsClickable(by))
            {
                TraceLine = "var eye = row.FindElement(by);";
                var eye = row.FindElement(by);

                if (eye != null)
                {
                    TraceLine = "eye.Click();";
                    eye.Click();
                    WaitForPinwheel(Constants.PINWHEELOVERLAY);
                    WaitFor.WaitForPageLoad();
                    return true;
                }
                TraceFailed.ShouldBe(TraceLine);
                return false;
            }

            TraceFailed.ShouldBe(TraceLine);
            return false;
        }

        public bool View_Record(string Eye_Icon_Hyperlink)
        {
            PrintCurrentMethod(MethodBase.GetCurrentMethod());

            if (!Click_Eye_Icon(DetailRow, By.CssSelector(Eye_Icon_Hyperlink)))
            {
                TraceFailed.ShouldBe(TraceLine);
                return false;
            }

            return true;
        }

        public bool Button_Click(IWebElement button)
        {
            PrintCurrentMethod(MethodBase.GetCurrentMethod());
            button.Click();
            WaitForPinwheel(Constants.PINWHEELOVERLAY);
            WaitFor.WaitForPageLoad();
            return true;
        }

        #endregion

        #region Click Element
        //public void ClickElement(By by)
        //{
        //    // Extra click required for Loan Profile Name filter field (Bug reported 06/11/19)
        //    var extraClick = Browser.FindElement(by);
        //    extraClick.Click();
        //}

        //public void ClickElement(IWebElement element)
        //{
        //    element.Click();
        //}
        #endregion

        #region Dropdown List
        /// <summary>
        /// Activate the dropdown; select the dropdown from the list of items;
        /// </summary>
        /// <param name="dropDownAnchor"></param>
        /// <param name="dropDownList"></param>
        /// <param name="textToFind"></param>
        /// <returns></returns>
        public bool Select_Dropdown_By_Listitem(IWebElement dropDownAnchor
                                                , ReadOnlyCollection<IWebElement> dropDownList
                                                , string textToFind)
        {
            PrintCurrentMethod(MethodBase.GetCurrentMethod());

            TraceLine = "if (!Activate_Dropdown(dropDownAnchor))";
            if (!Activate_Dropdown(dropDownAnchor))
            {
                TraceFailed.ShouldBe($"[-] Activate_Dropdown for Anchor {dropDownAnchor} Failed");
                return false;
            }

            WaitFor.WaitForPageLoad();

            TraceLine = "if (dropDownList.Count > 0)";
            if (dropDownList.Count > 0)
            {
                // Find the "textToFind" in the list items and click the item
                TraceLine = "foreach (IWebElement dropdown in dropDownList)";
                foreach (IWebElement dropdown in dropDownList)
                {
                    TraceLine = $"[+] dropdown text : {dropdown.Text}";
                    if (dropdown.Text.Contains(textToFind))
                    {
                        TraceLine = $"[+] dropdown click()";
                        dropdown.Click();
                        WaitFor.WaitForPageLoad();
                        return true;
                    }
                }
            }
            TraceFailed.ShouldBe($"[-] Select_Dropdown_By_Listitem did not find {textToFind}");
            return false;
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="dropDown"></param>
        /// <returns></returns>
        public bool Activate_Dropdown(IWebElement dropDown)
        {
            PrintCurrentMethod(MethodBase.GetCurrentMethod());

            TraceLine = "if (IsClickable(dropDown))";
            if (IsClickable(dropDown))
            {
                // Must click dropdown to expose the list items
                dropDown.Click();
                return true;
            }

            TraceFailed.ShouldBe(TraceLine);
            return false;
        }


        public bool Set_Dropdown(IWebElement anchor, string dataToAssign)
        {
            PrintCurrentMethod(MethodBase.GetCurrentMethod());
            TraceLine = "if (IsClickable(anchor))";
            if (IsClickable(anchor))
            {
                anchor.Click();
                WaitFor.WaitForPageLoad();
                anchor.SendKeys(dataToAssign);
                WaitFor.WaitForPageLoad();
                return true;
            }

            TraceFailed.ShouldBe(TraceLine);
            return false;
        }
        #endregion

        #region DisplayDetail Items

        /// <summary>
        /// For each row, return the row when the itemTofindBy field contains the itemText 
        /// </summary>
        /// <param name="displayDetails"></param>
        /// <param name="itemToFindBy"></param>
        /// <param name="itemText"></param>
        /// <returns></returns>
        public (bool result, IWebElement detailRow) Get_DisplayDetail(
                                            ReadOnlyCollection<IWebElement> displayDetails
                                            , By itemToFindBy
                                            , string itemText)
        {
            PrintCurrentMethod(MethodBase.GetCurrentMethod());

            WaitFor.WaitForPageLoad(); // TODO: should already be loaded before getting here...remove waits

            TraceLine = "if (IsClickable(displayDetails[0]))";
            if (IsClickable(displayDetails[0]))
            {
                TraceLine = "foreach (IWebElement detailRow in displayDetails)";
                foreach (IWebElement detailRow in displayDetails)
                {
                    //TraceLine = "if (detailRow.FindElement(itemToFindBy).Text.Contains(itemText))";
                    TraceLine = $"[+] detailRow ItemText : {detailRow.FindElement(itemToFindBy).Text}";
                    if (detailRow.FindElement(itemToFindBy).Text.Contains(itemText))
                    {
                        TraceLine = $"[+] Found ItemText : {detailRow.Text}";
                        return (true, detailRow);
                    }
                }
            }
            TraceFailed.ShouldBe(TraceLine);
            return (false, null);
        }

        /// <summary>
        /// For a given row, return (true, value) if the itemTofindBy field contains non null value;
        /// </summary>
        /// <param name="displayRow"></param>
        /// <param name="findBy"></param>
        /// <returns></returns>
        public (bool result, string value) Get_DisplayDetail_ItemValue(
                                            IWebElement displayRow
                                            , By itemToFindBy)
        {
            PrintCurrentMethod(MethodBase.GetCurrentMethod());

            // Wait for search results to be displayed
            TraceLine = "if (IsClickable(displayRow))";
            if (IsClickable(displayRow))
            {
                TraceLine = "if (displayRow != null)";
                if (displayRow != null)
                {
                    TraceLine = "displayRow.FindElement(by).Text.ToString();";
                    try
                    {
                        var value = displayRow.FindElement(itemToFindBy).Text.ToString();
                        if (!string.IsNullOrEmpty(value))
                        {
                            return (result: true, value: value);
                        }
                        else
                        {
                            return (result: false, value: value);
                        }

                    }
                    catch (NoSuchElementException)
                    {
                        TraceLine = "[-]********** catch (NoSuchElementException) ";
                        return (result: false, value: null);
                    }
                }
            }

            TraceFailed.ShouldBe(TraceLine);
            return (result: false, value: null);
        }


        /// <summary>
        /// For each row, return the row;
        /// </summary>
        /// <param name="displayDetails"></param>
        /// <returns></returns>
        public (bool result, IWebElement detailRow) Get_Any_DisplayDetail(
                                            ReadOnlyCollection<IWebElement> displayDetails)
        {
            PrintCurrentMethod(MethodBase.GetCurrentMethod());

            WaitFor.WaitForPageLoad();// ToDo: should already be loaded before getting here...remove waits

            TraceLine = "if (IsClickable(displayDetails[0]))";
            if (IsClickable(displayDetails[0]))
            {
                TraceLine = "foreach (IWebElement detailRow in displayDetails)";
                foreach (IWebElement detailRow in displayDetails)
                {
                    return (true, detailRow);
                }
            }
            TraceFailed.ShouldBe(TraceLine);
            return (false, null);
        }


        public (bool result, IWebElement detailRow) Get_Any_SearchResults(
                                            ReadOnlyCollection<IWebElement> displayDetails)
        {
            PrintCurrentMethod(MethodBase.GetCurrentMethod());

            // Base Class
            var (result, detailRow) = Get_Any_DisplayDetail(displayDetails);
            DetailRow = detailRow;

            if (result)
            {
                return (true, detailRow);
            }

            TraceFailed.ShouldBe(TraceLine);
            return (false, null);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="displayRows"></param>
        /// <param name="itemToFind_Id"></param>
        /// <param name="itemText"></param>
        /// <returns></returns>
        public (bool result, string value) Search_Results_Contain( ReadOnlyCollection<IWebElement> displayRows
                                                                ,  string itemToFind_Id
                                                                ,  string itemText)
        {
            PrintCurrentMethod(MethodBase.GetCurrentMethod());

            TraceLine = "foreach (IWebElement row in displayRows)";
            var found = false;
            foreach (IWebElement row in displayRows)
            {
                if (DisplayDetail_Contains(row, By.Id(itemToFind_Id), itemText))
                {
                    found = true;
                    continue;
                }
                else
                {
                    // All must be Active...otherwise, error
                    found = false;
                    break; 
                }
            }

            if (found)
            {
                return (true, itemText);
            }

            TraceFailed.ShouldBe($"DisplayDetail_Contains did not find itemText {itemText}");
            return (false, null);
        }
        

        /// <summary>
        /// For a given row, return true if the itemToFind_Id contain the itemText
        /// </summary>
        /// <param name="displayDetail"></param>
        /// <param name="itemToFind_Id"></param>
        /// <param name="itemText"></param>
        /// <returns></returns>
        public bool DisplayDetail_Contains(   IWebElement displayDetail
                                            , By itemToFind_Id
                                            , string itemText)
        {
            PrintCurrentMethod(MethodBase.GetCurrentMethod());

            TraceLine = "if (IsClickable(displayDetail))";
            if (IsClickable(displayDetail))
            {
                TraceLine = "if (displayDetail.FindElement(itemToFind_Id).Text.Contains(itemText))";
                if (displayDetail.FindElement(itemToFind_Id).Text.Contains(itemText))
                {
                    return true;
                }
            }
            TraceFailed.ShouldBe(TraceLine);
            return false;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="DisplayDetails"></param>
        /// <param name="panelTitleId"></param>
        /// <param name="itemId"></param>
        /// <param name="itemText"></param>
        /// <returns></returns>
        public (bool result, IWebElement detailRow) Get_Row_In_Search_Results(
                                            ReadOnlyCollection<IWebElement> DisplayDetails
                                            , string panelTitleId
                                            , string itemId
                                            , string itemText)
        {
            PrintCurrentMethod(MethodBase.GetCurrentMethod());

            TraceLine = "if (IsVisible(By.Id(panelTitleId)))";
            if (IsVisible(By.Id(panelTitleId)))
            {
                TraceLine = "if (IsClickable(DisplayDetails[0]))";
                if (IsClickable(DisplayDetails[0]))
                {
                    TraceLine = "var (result, detailRow) = Get_Detail_Row_By_ItemText(";
                    var (result, detailRow) = Get_DisplayDetail(DisplayDetails, By.Id(itemId), itemText);

                    if (result)
                    {
                        return (true, detailRow);
                    }
                }
            }
            TraceFailed.ShouldBe(TraceLine);
            return (false, null);
        }

        #endregion

        #region Filter Fields
        /// <summary>
        /// Set filter field in two steps:
        /// 1. Set filterField with a subset of the filterText that we are looking for...
        /// 2. Using the filterXpath, a dropdown list will appear;
        /// 2. Iterate the dropdown list matching on filterValue;
        /// </summary>
        /// <param name="filterField"></param>
        /// <param name="filterText"></param>
        /// <param name="filterXpath"></param>
        /// <param name="filterValue"></param>
        /// <returns></returns>
        public bool Set_Filter_Field_By_Text( IWebElement filterField   // The filter field to set
                                            , string filterText         // Subset of the actual filterValue
                                            , string filterXpath        // Dropdown of values
                                            , string filterValue)       // Value to select from dropdown
        {
            PrintCurrentMethod(MethodBase.GetCurrentMethod());

            TraceLine = "if (Set_Filter_Field(filterField, filter)";

            // Filter Fields need an extra click to work properly (HACK)
            var filterField_label = filterField.GetAttribute("Id") + "-Label";
            var clickOnLabel_hack = Browser.FindElement(By.Id(filterField_label));

            if (Set_Filter_Field(filterField, filterText))
            {
                WaitFor.WaitForPageLoad();

                TraceLine = $"Browser.FindElements By.XPath : {filterXpath}"; 
                
                IList<IWebElement> filterList = Browser.FindElements(By.XPath(filterXpath));
                TraceLine = $" if filterList.count > 0 : {filterList.Count} > 0 :  ";

                if (filterList.Count > 0)
                {
                    TraceLine = "foreach (IWebElement filterItem in filterList)";
                    foreach (IWebElement filterItem in filterList)
                    {
                        if (filterItem.Text.Contains(filterValue))
                        {
                            filterItem.Click();
                            clickOnLabel_hack.Click();
                            return true;
                        }
                    }
                }
                return false;
            }
            TraceFailed.ShouldBe(TraceLine);
            return false;
        }   // the value to be selected
        
        /// <summary>
        /// Set_Filter_Field
        /// </summary>
        /// <param name="filterField"></param>
        /// <param name="fullData"></param>
        /// <returns></returns>
        public bool Set_Filter_Field(IWebElement filterField, string filterData)
        {
            PrintCurrentMethod(MethodBase.GetCurrentMethod());
            TraceLine = $"SendKeys Filter Field : {filterField} Filter Data : {filterData}";
            if (SendKeys_to_Target(filterField, filterData))
            {
                return true;
            }
            TraceFailed.ShouldBe($"[-] Failed - SendKeys Filter Field : {filterField} Filter Data : {filterData}");
            return false;
        }

        #endregion

        #region Frames

        /// <summary>
        /// Switch back to default frame, i.e., the Parent
        /// </summary>
        public virtual void SwitchToDefault() => Browser.SwitchTo().DefaultContent();

        /// <summary>
        /// Switch to the iframe
        /// </summary>
        /// <param name="frameName"></param>
        public virtual void SwitchToFrame(string frameName) => Browser.SwitchTo().Frame(frameName);

        /// <summary>
        /// Pattern: If link is clickable, then click link and wait for Pin Wheel to stop;
        /// If frame is visible, then switch to that frame;
        /// </summary>
        /// <param name="modalLink"></param>
        /// <param name="iframe"></param>
        /// <returns></returns>
        public bool SwitchFrame(IWebElement modalLink, string iframe)
        {
            PrintCurrentMethod(MethodBase.GetCurrentMethod());

            TraceLine = "if (IsClickable(modalLink))";
            if (IsClickable(modalLink))
            {
                TraceLine = "modalLink.Click();";
                modalLink.Click();

                TraceLine = "if (WaitForPinwheel(Constants.PINWHEELMODALOVERLAY))";
                if (WaitForPinwheel(Constants.PINWHEELMODALOVERLAY))
                {
                    TraceLine = "if (IsVisible(By.Id(iframe)))";
                    if (IsVisible(By.Id(iframe)))
                    {
                        TraceLine = "SwitchToFrame(iframe);";
                        SwitchToFrame(iframe);
                        return true;
                    }
                }
            }
            TraceFailed.ShouldBe(TraceLine);
            return false;
        }

        #endregion

        #region Navigating

        public virtual void Open(string part = "")
        {
            Browser.Navigate().GoToUrl(string.Concat(Url, part));
            WaitForPinwheel(Constants.PINWHEELOVERLAY);
        }

        public virtual void Open(bool open, string part = "")
        {
            if (open)
            {
                Browser.Navigate().GoToUrl(string.Concat(Url, part));
                WaitForPinwheel(Constants.PINWHEELOVERLAY);
            }
            JS_InjectJQuery();
            var b = WaitFor.WaitForJQuery(Browser, TimeSpan.FromSeconds(30));
        }

        #endregion

        #region ScrollIntoView

        public void ScrollDown()
        {
            IJavaScriptExecutor js = Browser as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
            //System.Threading.Thread.Sleep(4000);
            //js.ExecuteScript("window.scrollTo(0, 0)");
        }

        public void ScrollUp()
        {
            IJavaScriptExecutor js = Browser as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollTo(0, 0)");
        }

        public void Action_MoveToElement(By by)
        {
            var element = Browser.FindElement(by);
            Actions actions = new Actions(Browser);
            actions.MoveToElement(element);
            actions.Perform();
        }

        public void JS_MoveToElement(By by)
        {
            IJavaScriptExecutor js = Browser as IJavaScriptExecutor;
            var element = Browser.FindElement(by);
            js.ExecuteScript("arguments[0].scrollIntoView();", element);
        }

        public void JS_InjectJQuery()
        {
            IJavaScriptExecutor js = Browser as IJavaScriptExecutor;
            js.ExecuteScript(
                "var headID = document.getElementsByTagName('head')[0];" +
                "var newScript = document.createElement('script');" +
                "newScript.type = 'text/javascript';" +
                "newScript.src = 'https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js';" +
                "headID.appendChild(newScript);"
            );
        }

        public void JQ_Loaded()
        {
            WaitFor.WaitForJQuery(Browser, TimeSpan.FromSeconds(30));
        }

        #endregion

        #region Send/Set Data

        public void SendData(IWebElement e, string data)
        {
            IsClickable(e);
            SendKeys(e, data);
        }

        public bool SendKeys_to_Target(IWebElement targetField, string data)
        {
            PrintCurrentMethod(MethodBase.GetCurrentMethod());

            TraceLine = "if (IsClickable(targetFilter))";
            if (IsClickable(targetField))
            {
                TraceLine = "targetFilter.SendKeys(data);";
                targetField.Clear();
                targetField.SendKeys(data);

                return true;
            }

            TraceFailed.ShouldBe(TraceLine);
            return false;
        }

        public bool SendKeys_Clear(IWebElement targetFilter)
        {
            PrintCurrentMethod(MethodBase.GetCurrentMethod());

            TraceLine = "if (IsClickable(targetFilter))";
            if (IsClickable(targetFilter))
            {
                TraceLine = "targetFilter.Clear();";
                targetFilter.Clear();

                return true;
            }
            TraceFailed.ShouldBe(TraceLine);
            return false;
        }
        
        public void SendKeys(IWebElement element, string data) => element.SendKeys(data);

        public bool Set_Element_Value(IWebElement element, string value)
        {
            PrintCurrentMethod(MethodBase.GetCurrentMethod());
            TraceLine = "if (IsClickable(" + element + "))";
            if (IsClickable(element))
            {
                element.Clear(); // 02/07/20 
                element.SendKeys(value);
                return true;
            }

            TraceFailed.ShouldBe(TraceLine);
            return false;
        }

        public bool Set_Field_Value(IWebElement field, string data)
        {
            TraceLine = "if (IsClickable(field))";
            if (IsClickable(field))
            {
                field.SendKeys(data);
                WaitFor.WaitForPageLoad();
                return true;
            }

            TraceFailed.ShouldBe(TraceLine);
            return false;
        }
        
        public bool Set_Toggle(IWebElement toggle)
        {
            PrintCurrentMethod(MethodBase.GetCurrentMethod());
            TraceLine = "if (IsClickable(toggle))";
            if (IsClickable(toggle))
            {
                toggle.Click();
                WaitFor.WaitForPageLoad();
                return true;
            }

            TraceFailed.ShouldBe(TraceLine);
            return false;
        }

        public bool Set_WYSIWYG_CKE(string text)
        {
            PrintCurrentMethod(MethodBase.GetCurrentMethod());

            IWebElement frame = Browser.FindElement(By.ClassName("cke_wysiwyg_frame"));
            Browser.SwitchTo().Frame(frame);
            IWebElement body = Browser.FindElement(By.XPath("//html/body"));

            TraceLine = "if (IsClickable(desc))";
            if (IsClickable(body))
            {
                body.Clear(); // 02/07/20 - HP 
                body.SendKeys(text);
                Browser.SwitchTo().ParentFrame();
                return true;
            }

            TraceFailed.ShouldBe(TraceLine);
            return false;
        }
        #endregion    

        #region Sorting
        //public bool IsSorted(By by)
        //{
        //    IList<IWebElement> theList = Browser.FindElements(by);
        //    List<string> sortedList = theList.Select(item => item.Text.Replace(System.Environment.NewLine, "")).ToList();
        //    var sorted = new List<string>();
        //    sorted.AddRange(sortedList.OrderBy(o => o));
        //    sortedList.ShouldBeSameAs(theList);
        //    return true;
        //}

        public bool IsSorted(SelectElement selectElement)
        {
            PrintCurrentMethod(MethodBase.GetCurrentMethod());

            TraceLine = "var theList = selectElement.Options;";
            var theList = selectElement.Options;
            //List<string> sortedList = theList.Select(item => item.Text.Replace(System.Environment.NewLine, "")).ToList();

            TraceLine = "List<string> theListItemText = theList.Select(item => item.Text).ToList();";
            List<string> theListItemText = theList.Select(item => item.Text).ToList();

            TraceLine = "var sorted = new List<string>();";
            var sorted = new List<string>();

            TraceLine = "sorted.AddRange(theListItemText.OrderBy(o => o));";
            sorted.AddRange(theListItemText.OrderBy(o => o));

            TraceLine = "theListItemText.ShouldBe<string>(sorted);";
            theListItemText.ShouldBe<string>(sorted);
            //theListItemText.ShouldBeSameAs(sorted);
            return true;
        }

        public bool IsSorted(string element_ByXPath)
        {
            IList<IWebElement> list_elements = Browser.FindElements(By.XPath(element_ByXPath));
            List<string> list_elements_text = list_elements.Select(item => item.Text).ToList();

            var sorted = new List<string>();

            sorted.AddRange(list_elements_text.OrderBy(o => o));
            // Test ShouldBe failure with OrderByDescending
            // sorted.AddRange(list_elements_text.OrderByDescending(o => o));

            list_elements_text.ShouldBe(sorted);
            return true;
        }
        #endregion

        #region IDisposable Support
        // To detect redundant calls
        private bool disposedValue = false; 

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // Dispose managed state (managed objects).
                    WebDriver.StopBrowser();
                    DisposeDriverService.FinishHim(Browser);
                }

                // Set large fields to null.
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
        }
        #endregion


    }
}

//public bool Select_Dropdown(IWebElement dropDownAnchor, ReadOnlyCollection<IWebElement> dropDownOptions, string dropDownText)
//{
//    PrintCurrentMethod(MethodBase.GetCurrentMethod());

//    TraceLine = "if (!Activate_Dropdown(dropDownAnchor))";
//    if (!Activate_Dropdown(dropDownAnchor))
//    {
//        TraceFailed.ShouldBe(TraceLine);
//        return false;
//    }

//    WaitFor.WaitForPageLoad();

//    TraceLine = "if (!Select_Dropdown_List_Item(dropDownOptions, dropDownText))";
//    if (!Select_Dropdown_By_Text(dropDownOptions, dropDownText))
//    {
//        TraceFailed.ShouldBe(TraceLine);
//        return false;
//    }

//    return true;
//}

//public bool Select_Dropdown_By_Text(ReadOnlyCollection<IWebElement> dropDownList, string textToFind)
//{
//    PrintCurrentMethod(MethodBase.GetCurrentMethod());

//    TraceLine = "if (IsClickable(dropDownList[dropDownList.Count - 1]))";
//    if (dropDownList.Count > 0)
//    {
//        // Find the "textToFind" in the list items and click the item
//        TraceLine = "foreach (IWebElement dropdown in dropDownList)";
//        foreach (IWebElement dropdown in dropDownList)
//        {
//            if (dropdown.Text.Contains(textToFind))
//            {
//                dropdown.Click();
//                return true;
//            }
//        }
//    }
//    //TraceFailed.ShouldBe(TraceLine);
//    return false;
//}

//public bool Set_Dropdown_Value(IWebElement dropDown, string value)
//{
//    PrintCurrentMethod(MethodBase.GetCurrentMethod());

//    TraceLine = "if (IsClickable(Set_Dropdown_Value))";
//    if (IsClickable(dropDown))
//    {
//        TraceLine = "if (WaitForPinwheel(Constants.PINWHEELMODALOVERLAY) && WaitForPinwheel(Constants.PINWHEELOVERLAY))";
//        if (WaitForPinwheel(Constants.PINWHEELMODALOVERLAY) && WaitForPinwheel(Constants.PINWHEELOVERLAY))
//        {
//            dropDown.Click();
//            WaitFor.WaitForPageLoad();

//            dropDown.SendKeys(value);
//            WaitFor.WaitForPageLoad();
//            return true;
//        }
//    }

//    TraceFailed.ShouldBe(TraceLine);
//    return false;
//}

//public bool Set_SearchBy_Filter( IWebElement dropDownAnchor
//                                , ReadOnlyCollection<IWebElement> dropDownList 
//                                , string searchByFilter)
//{
//    PrintCurrentMethod(MethodBase.GetCurrentMethod());

//    WaitForPinwheel(Constants.PINWHEELOVERLAY);

//    if (!Activate_Dropdown(dropDownAnchor))
//    {
//        TraceFailed.ShouldBe(TraceLine);
//        return false;
//    }

//    WaitFor.WaitForPageLoad();

//    if (!Select_Dropdown_By_Text(dropDownList, searchByFilter))
//    {
//        TraceFailed.ShouldBe(TraceLine);
//        return false;
//    }

//    return true;
//}
//public void ClickOnElement(IWebElement element)
//{
//    Actions actions = new Actions(Browser);
//    actions.MoveToElement(element);
//    actions.Click();
//    actions.Build();
//    actions.Perform();
//}

//public bool Click_Button(string buttonName)
//{
//    PrintCurrentMethod(MethodBase.GetCurrentMethod());

//    TraceLine = "if (IsClickable(By.Id('" + buttonName + "')))";
//    if (IsClickable(By.Id(buttonName)))
//    {
//        var btn = Browser.FindElement(By.Id(buttonName));
//        IsClickable(btn);
//        btn.Click();
//        WaitForPinwheel(Constants.PINWHEELOVERLAY);
//        WaitFor.WaitForPageLoad();
//        return true;
//    }

//    TraceFailed.ShouldBe(TraceLine);
//    return false;
//}