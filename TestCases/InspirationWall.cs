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
    class InspirationWall
    {
        public static bool IsTcAdded = false;

        IWebDriver driver;

        string ProjectUrl = Convert.ToString(ConfigurationSettings.AppSettings.Get("ProjectUrl"));
        public void T008_Login_008_VerifyShareFunctionality()
        {

            if (!IsTcAdded)
            {
                Report.AddToHtmlReportTCHeader("Login Test Cases");
                IsTcAdded = true;
            }

            Report.AddToHtmlReport("TEAC_1008 : To Verify Share Template Functionality.", true, false, true);

            Report.AddToHtmlReport("STEP 1: Insert Url in Browser Addressbar.", false, true);

            driver = Browser.OpenWithSelectedBrowser(driver, ProjectUrl, true);

            InspirationWallObjects objInspirationWallObjects = new InspirationWallObjects();

            driver = objInspirationWallObjects.T008_Login_008_VerifyShareFunctionality(driver);

            if (Convert.ToInt16(ConfigurationSettings.AppSettings.Get("CloseBrowser")) == 1)
            {
                Browser.CloseBrowser(driver);
            }

        }

        public void T009_Login_009_VerifyBookmarkFunctionality()
        {

            if (!IsTcAdded)
            {
                Report.AddToHtmlReportTCHeader("Login Test Cases");
                IsTcAdded = true;
            }

            Report.AddToHtmlReport("TEAC_1009 : To Verify Bookmark Functionality.", true, false, true);

            Report.AddToHtmlReport("STEP 1: Insert Url in Browser Addressbar.", false, true);

            driver = Browser.OpenWithSelectedBrowser(driver, ProjectUrl, true);

            InspirationWallObjects objInspirationWallObjects = new InspirationWallObjects();

            driver = objInspirationWallObjects.T009_Login_009_VerifyBookmarkFunctionality(driver);

            if (Convert.ToInt16(ConfigurationSettings.AppSettings.Get("CloseBrowser")) == 1)
            {
                Browser.CloseBrowser(driver);
            }

        }
    }
}
