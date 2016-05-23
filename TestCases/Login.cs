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
   public class Login
   {
       public static bool IsTcAdded = false;

       IWebDriver driver;

       string ProjectUrl = Convert.ToString(ConfigurationSettings.AppSettings.Get("ProjectUrl"));

       public void T001_Login_001_UserLoginWithValidCredentials()
       {

           if (!IsTcAdded)
           {
               Report.AddToHtmlReportTCHeader("Login Test Cases");
               IsTcAdded = true;
           }

           Report.AddToHtmlReport("TEAC_1001 : To Verify User can Login with Valid Credentials.", true, false, true);

           Report.AddToHtmlReport("STEP 1: Insert Url in Browser Addressbar.", false, true);

           driver = Browser.OpenWithSelectedBrowser(driver, ProjectUrl, true);

           Framework.PageObjects.LoginObjects objLoginObjects = new Framework.PageObjects.LoginObjects();

           driver = objLoginObjects.T001_Login_001_UserLoginWithValidCredentials(driver);

           if (Convert.ToInt16(ConfigurationSettings.AppSettings.Get("CloseBrowser")) == 1)
           {
               Browser.CloseBrowser(driver);

           }

       }
       public void T002_Login_002_VerifyAccountDetails()
       {

           if (!IsTcAdded)
           {
               Report.AddToHtmlReportTCHeader("Login Test Cases");
               IsTcAdded = true;
           }

           Report.AddToHtmlReport("TEAC_1002 : To Verify User Account Details.", true, false, true);

           Report.AddToHtmlReport("STEP 1: Insert Url in Browser Addressbar.", false, true);

           driver = Browser.OpenWithSelectedBrowser(driver, ProjectUrl, true);

           Framework.PageObjects.LoginObjects objLoginObjects = new Framework.PageObjects.LoginObjects();

           driver = objLoginObjects.T002_Login_002_VerifyAccountDetails(driver);

           if (Convert.ToInt16(ConfigurationSettings.AppSettings.Get("CloseBrowser")) == 1)
           {
               Browser.CloseBrowser(driver);

           }

       }

       public void T003_Login_003_VerifyRecentlyViewedFunctionality()
       {

           if (!IsTcAdded)
           {
               Report.AddToHtmlReportTCHeader("Login Test Cases");
               IsTcAdded = true;
           }

           Report.AddToHtmlReport("TEAC_1003 : To Verify Recently Viewed Functionality.", true, false, true);

           Report.AddToHtmlReport("STEP 1: Insert Url in Browser Addressbar.", false, true);

           driver = Browser.OpenWithSelectedBrowser(driver, ProjectUrl, true);

           Framework.PageObjects.LoginObjects objLoginObjects = new Framework.PageObjects.LoginObjects();

           driver = objLoginObjects.T003_Login_003_VerifyRecentlyViewedFunctionality(driver);

           if (Convert.ToInt16(ConfigurationSettings.AppSettings.Get("CloseBrowser")) == 1)
           {
               Browser.CloseBrowser(driver);

           }

       }

       public void T004_Login_004_UserLoginWithPaidUser()
       {

           if (!IsTcAdded)
           {
               Report.AddToHtmlReportTCHeader("Login Test Cases");
               IsTcAdded = true;
           }

           Report.AddToHtmlReport("TEAC_1004 : To Verify User can Login with Valid Credentials of Paid User.", true, false, true);

           Report.AddToHtmlReport("STEP 1: Insert Url in Browser Addressbar.", false, true);

           driver = Browser.OpenWithSelectedBrowser(driver, ProjectUrl, true);

           Framework.PageObjects.LoginObjects objLoginObjects = new Framework.PageObjects.LoginObjects();

           driver = objLoginObjects.T004_Login_004_UserLoginWithPaidUser(driver);

           if (Convert.ToInt16(ConfigurationSettings.AppSettings.Get("CloseBrowser")) == 1)
           {
               Browser.CloseBrowser(driver);

           }

       }

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

           Framework.PageObjects.LoginObjects objLoginObjects = new Framework.PageObjects.LoginObjects();

           driver = objLoginObjects.T005_Login_005_VerifyCreateTemplate(driver);

           if (Convert.ToInt16(ConfigurationSettings.AppSettings.Get("CloseBrowser")) == 1)
           {
               Browser.CloseBrowser(driver);

           }

       }
       }
   }

