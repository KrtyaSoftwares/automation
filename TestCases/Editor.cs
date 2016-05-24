using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using Framework.Init;
using OpenQA.Selenium.Firefox;
using System.Data;
using Framework.PageObjects;

namespace TestCases
{
    class Editor
    {
        public static bool IsTcAdded = false;

        IWebDriver driver;

        string ProjectUrl = Convert.ToString(ConfigurationSettings.AppSettings.Get("ProjectUrl"));
        public void T005_Login_005_VerifyCreateTemplate()
        {

            if (!IsTcAdded)
            {
                Report.AddToHtmlReportTCHeader("Login Test Cases");
                IsTcAdded = true;
            }

            Report.AddToHtmlReport("TEAC_1005 : To Verify User can Create Template from Editor.", true, false, true);

            Report.AddToHtmlReport("STEP 1: Insert Url in Browser Addressbar.", false, true);

            driver = Browser.OpenWithSelectedBrowser(driver, ProjectUrl, true);

            EditorObjects objEditorObjects = new EditorObjects();

            driver = objEditorObjects.T005_Login_005_VerifyCreateTemplate(driver);

            if (Convert.ToInt16(ConfigurationSettings.AppSettings.Get("CloseBrowser")) == 1)
            {
                Browser.CloseBrowser(driver);
            }

        }

        public void T007_Login_007_VerifyPrintFunctionality()
        {

            if (!IsTcAdded)
            {
                Report.AddToHtmlReportTCHeader("Login Test Cases");
                IsTcAdded = true;
            }

            Report.AddToHtmlReport("TEAC_1007 : To Verify Print Functionality in Editor.", true, false, true);

            Report.AddToHtmlReport("STEP 1: Insert Url in Browser Addressbar.", false, true);

            driver = Browser.OpenWithSelectedBrowser(driver, ProjectUrl, true);

            EditorObjects objEditorObjects = new EditorObjects();

            driver = objEditorObjects.T007_Login_007_VerifyPrintFunctionality(driver);

            if (Convert.ToInt16(ConfigurationSettings.AppSettings.Get("CloseBrowser")) == 1)
            {
                Browser.CloseBrowser(driver);
            }

        }
    }
}
