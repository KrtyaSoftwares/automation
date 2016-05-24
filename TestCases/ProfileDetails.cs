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
    class ProfileDetails
    {
        public static bool IsTcAdded = false;

        IWebDriver driver;

        string ProjectUrl = Convert.ToString(ConfigurationSettings.AppSettings.Get("ProjectUrl"));
        public void T006_Login_006_VerifyPinterestUpdate()
        {

            if (!IsTcAdded)
            {
                Report.AddToHtmlReportTCHeader("Login Test Cases");
                IsTcAdded = true;
            }

            Report.AddToHtmlReport("TEAC_1006 : To Verify User can Update Pinterest URL.", true, false, true);

            Report.AddToHtmlReport("STEP 1: Insert Url in Browser Addressbar.", false, true);

            driver = Browser.OpenWithSelectedBrowser(driver, ProjectUrl, true);

            ProfileDetailsObjects objProfileDetailsObjects = new ProfileDetailsObjects();

            driver = objProfileDetailsObjects.T006_Login_006_VerifyPinterestUpdate(driver);

            if (Convert.ToInt16(ConfigurationSettings.AppSettings.Get("CloseBrowser")) == 1)
            {
                Browser.CloseBrowser(driver);
            }

        }

        public void T010_Login_010_VerifyTwitterUpdate()
        {

            if (!IsTcAdded)
            {
                Report.AddToHtmlReportTCHeader("Login Test Cases");
                IsTcAdded = true;
            }

            Report.AddToHtmlReport("TEAC_1010 : To Verify User can Update Twitter URL.", true, false, true);

            Report.AddToHtmlReport("STEP 1: Insert Url in Browser Addressbar.", false, true);

            driver = Browser.OpenWithSelectedBrowser(driver, ProjectUrl, true);

            ProfileDetailsObjects objProfileDetailsObjects = new ProfileDetailsObjects();

            driver = objProfileDetailsObjects.T010_Login_010_VerifyTwitterUpdate(driver);

            if (Convert.ToInt16(ConfigurationSettings.AppSettings.Get("CloseBrowser")) == 1)
            {
                Browser.CloseBrowser(driver);
            }

        }

        public void T011_Login_011_VerifyFacebookUpdate()
        {

            if (!IsTcAdded)
            {
                Report.AddToHtmlReportTCHeader("Login Test Cases");
                IsTcAdded = true;
            }

            Report.AddToHtmlReport("TEAC_1011 : To Verify User can Update Facebook URL.", true, false, true);

            Report.AddToHtmlReport("STEP 1: Insert Url in Browser Addressbar.", false, true);

            driver = Browser.OpenWithSelectedBrowser(driver, ProjectUrl, true);

            ProfileDetailsObjects objProfileDetailsObjects = new ProfileDetailsObjects();

            driver = objProfileDetailsObjects.T011_Login_011_VerifyFacebookUpdate(driver);

            if (Convert.ToInt16(ConfigurationSettings.AppSettings.Get("CloseBrowser")) == 1)
            {
                Browser.CloseBrowser(driver);
            }

        }

        public void T013_Login_013_VerifyLinkedInUpdate()
        {

            if (!IsTcAdded)
            {
                Report.AddToHtmlReportTCHeader("Login Test Cases");
                IsTcAdded = true;
            }

            Report.AddToHtmlReport("TEAC_1013 : To Verify User can Update LinkedIn URL.", true, false, true);

            Report.AddToHtmlReport("STEP 1: Insert Url in Browser Addressbar.", false, true);

            driver = Browser.OpenWithSelectedBrowser(driver, ProjectUrl, true);

            ProfileDetailsObjects objProfileDetailsObjects = new ProfileDetailsObjects();

            driver = objProfileDetailsObjects.T013_Login_013_VerifyLinkedInUpdate(driver);

            if (Convert.ToInt16(ConfigurationSettings.AppSettings.Get("CloseBrowser")) == 1)
            {
                Browser.CloseBrowser(driver);
            }

        }

        public void T016_Login_016_VerifyBookmarkAdded()
        {

            if (!IsTcAdded)
            {
                Report.AddToHtmlReportTCHeader("Login Test Cases");
                IsTcAdded = true;
            }

            Report.AddToHtmlReport("TEAC_1016 : To Verify User can Bookmark the Template.", true, false, true);

            Report.AddToHtmlReport("STEP 1: Insert Url in Browser Addressbar.", false, true);

            driver = Browser.OpenWithSelectedBrowser(driver, ProjectUrl, true);

            ProfileDetailsObjects objProfileDetailsObjects = new ProfileDetailsObjects();

            driver = objProfileDetailsObjects.T016_Login_016_VerifyBookmarkAdded(driver);

            if (Convert.ToInt16(ConfigurationSettings.AppSettings.Get("CloseBrowser")) == 1)
            {
                Browser.CloseBrowser(driver);
            }

        }
    }
}
