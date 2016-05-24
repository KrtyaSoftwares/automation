using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Init;
using OpenQA.Selenium;
using System.Configuration;
//using OpenQA.Selenium.Support.UI.WebDriverWait;
using NUnit.Framework;

namespace Framework.PageObjects
{
    public class LoginObjects
    {
        IWebDriver _driver;

        string strEmail = Convert.ToString(ConfigurationSettings.AppSettings.Get("Email"));
        string strPassword = Convert.ToString(ConfigurationSettings.AppSettings.Get("Password"));
        string strProjectURL = Convert.ToString(ConfigurationSettings.AppSettings.Get("ProjectUrl"));

        public IWebDriver T001_Login_001_UserLoginWithValidCredentials(IWebDriver driver)
        {

            _driver = driver;

            T001_Login_001_UserLoginWithValidCredentials();

            return _driver;
        }
        public void T001_Login_001_UserLoginWithValidCredentials()
        {
            string strEmail = "kalpeshrahir@gmail.com";
            string strPassword = "Pass#123";

            //new Common(_driver).pause(2000);
            IWebElement Home_lbl_Login = new Common(_driver).FindElement(By.XPath(ElementLocators.Home_lbl_Login), "'Login' Link on Login Page.", true, 2000);
            Report.AddToHtmlReport("STEP 2: Click on Login Link.", false, true);
            Home_lbl_Login.Click();

            _driver.SwitchTo().Window(_driver.WindowHandles.Last());
            new Common(_driver).pause(5000);
            IWebElement Home_txt_Email = new Common(_driver).FindElement(By.XPath(ElementLocators.Home_txt_Email), "'Email' TextBox on Login Page.", true, 2000);
            IWebElement Home_txt_Password = new Common(_driver).FindElement(By.XPath(ElementLocators.Home_txt_Password), "'Password' TextBox on Login Page.", true, 2000);
            new Common(_driver).pause(2000);
            IWebElement Home_btn_Login = new Common(_driver).FindElement(By.XPath(ElementLocators.Home_btn_Login), "'Login' Button on Login Page.", true);
            //new Common(_driver).pause(5000);
            Report.AddToHtmlReport("STEP 3: Enter Valid 'Email' and 'Password' in TextBox on Login Page.", false, true);

            Common.enterText(Home_txt_Email, strEmail);
            Common.enterText(Home_txt_Password, strPassword);

            Report.AddToHtmlReport("<br>Data Entered:", false, true, true);
            Report.AddToHtmlReport("<b>Login Email:</b> " + strEmail, false);
            Report.AddToHtmlReport("<b>Password: </b> " + strPassword + "<br>", false);

            Report.AddToHtmlReport("STEP 4: Click on 'Login' Button on Login Page.", false, true);

            Home_btn_Login.Click();
            new Common(_driver).pause(8000);
            IWebElement Home_lbl_Welcome = new Common(_driver).FindElement(By.XPath(ElementLocators.Home_lbl_Welcome), "'Welcome to TEACHERSHERPA' Label on Home Page.", true);


        }

        public IWebDriver T002_Login_002_VerifyAccountDetails(IWebDriver driver)
        {

            _driver = driver;

            T002_Login_002_VerifyAccountDetails();

            return _driver;
        }
        public void T002_Login_002_VerifyAccountDetails()
        {
            string strSchoolName = "AutoQA" + new Common(_driver).generateRandomChars(5);
            T001_Login_001_UserLoginWithValidCredentials();

            new Common(_driver).pause(2000);
            IWebElement Home_img_Details = new Common(_driver).FindElementClick(By.XPath(ElementLocators.Home_img_Details), "'Details' Image on Home Page.", true, 2000);
            IWebElement Home_lnk_AccountDetails = new Common(_driver).FindElement(By.XPath(ElementLocators.Home_lnk_AccountDetails), "'Account Details' Link on Home Page.", true, 2000);

            Report.AddToHtmlReport("STEP 5: Click on 'Account Details' Link on Home Page.", false, true);
            Home_lnk_AccountDetails.Click();
            new Common(_driver).pause(2000);
            IWebElement AccountDetails_txt_SchoolName = new Common(_driver).FindElement(By.XPath(ElementLocators.AccountDetails_txt_SchoolName), "'School Name' TextBox on Account Details Page.", true, 2000);
            IWebElement AccountDetails_btn_Update = new Common(_driver).FindElement(By.XPath(ElementLocators.AccountDetails_btn_Update), "'Update' Button on Account Details Page.", true, 2000);

            Report.AddToHtmlReport("STEP 6: Modify Account Details.", false, true);
            Common.enterText(AccountDetails_txt_SchoolName, strSchoolName);

            Report.AddToHtmlReport("<br>Data Entered:", false, true, true);
            Report.AddToHtmlReport("<b>School Name: </b> " + strSchoolName + "<br>", false);
            AccountDetails_btn_Update.Click();

            new Common(_driver).pause(3000);

            Report.AddToHtmlReport("STEP 7: Click on MyProfile Link.", false, true);
            IWebElement Home_img_Details1 = new Common(_driver).FindElementClick(By.XPath(ElementLocators.Home_img_Details), "'Details' Image on Home Page.", true, 2000);
            IWebElement AccountDetails_lnk_MyProfile = new Common(_driver).FindElementClick(By.XPath(ElementLocators.AccountDetails_lnk_MyProfile), "'My Profile' Link on Home Page.", true, 2000);

            new Common(_driver).pause(3000);
            Report.AddToHtmlReport("STEP 8: Click Again on 'Account Details' Link to Verify the Details.", false, true);

            IWebElement Home_img_Details2 = new Common(_driver).FindElementClick(By.XPath(ElementLocators.Home_img_Details), "'Details' Image on Home Page.", true, 2000);
            IWebElement Home_lnk_AccountDetails1 = new Common(_driver).FindElementClick(By.XPath(ElementLocators.Home_lnk_AccountDetails), "'Account Details' Link on Home Page.", true, 2000);

            new Common(_driver).pause(3000);
            IWebElement AccountDetails_txt_SchoolName1 = new Common(_driver).FindElement(By.XPath(ElementLocators.AccountDetails_txt_SchoolName), "'School Name' TextBox on Account Details Page.", true, 2000);
            string strSchoolName1 = new Common(_driver).ElementGetText(AccountDetails_txt_SchoolName1);

            Console.WriteLine(strSchoolName);
            Console.WriteLine(strSchoolName1);
            if (strSchoolName.Trim() == strSchoolName1.Trim())
            {
                Report.AddToHtmlReportPassed("<b>Account Details Updated Successfully.</b>");
            }
            else
            {
                Exception ex = new Exception();
                Report.AddToHtmlReportFailed(_driver, ex, "<b>Account Details not Updated Successfully.</b>");
            }
        }

        public IWebDriver T003_Login_003_VerifyRecentlyViewedFunctionality(IWebDriver driver)
        {

            _driver = driver;

            T003_Login_003_VerifyRecentlyViewedFunctionality();


            return _driver;
        }
        public void T003_Login_003_VerifyRecentlyViewedFunctionality()
        {
            T001_Login_001_UserLoginWithValidCredentials();
            new Common(_driver).pause(3000);

            IWebElement Home_txt_Search = new Common(_driver).FindElement(By.XPath(ElementLocators.Home_txt_Search), "'Search' TextBox on Home Page.", true, 2000);

            Report.AddToHtmlReport("STEP 5: Enter 'test' in a Search TextBox.", false, true);

            Common.enterText(Home_txt_Search, "test");

            Report.AddToHtmlReport("<br>Data Entered:", false, true, true);
            Report.AddToHtmlReport("<b>Search:</b> " + "test", false);

            new Common(_driver).pause(3000);
            System.Windows.Forms.SendKeys.SendWait(@"{Enter}");
            new Common(_driver).pause(3000);
            IWebElement Search_div_test = new Common(_driver).FindElement(By.XPath(ElementLocators.Search_div_test), "'test LD' Template on Search Page.", true, 2000);

            Report.AddToHtmlReport("STEP 6: Click on 'test LD' Template.", false, true);
            Search_div_test.Click();
            new Common(_driver).pause(3000);
            Report.AddToHtmlReport("STEP 7: Click on My Profile Link.", false, true);

            IWebElement Home_img_Details = new Common(_driver).FindElementClick(By.XPath(ElementLocators.Home_img_Details), "'Details' Image on Home Page.", true, 2000);
            new Common(_driver).pause(3000);
            IWebElement AccountDetails_lnk_MyProfile = new Common(_driver).FindElementClick(By.XPath(ElementLocators.AccountDetails_lnk_MyProfile), "'My Profile' Link on Home Page.", true, 2000);
            new Common(_driver).pause(3000);

            IWebElement Home_div_RecentlyViewed = new Common(_driver).FindElement(By.XPath(ElementLocators.Home_div_RecentlyViewed), "'Recently Viewed' on Home Page.", true, 2000);

            Report.AddToHtmlReport("STEP 8: Click on 'Recently Viewed' to see Recently Viewed Templates.", false, true);
            Home_div_RecentlyViewed.Click();
            new Common(_driver).pause(3000);
            IWebElement RecentlyViewed_div_test = new Common(_driver).FindElement(By.XPath(ElementLocators.RecentlyViewed_div_test), "'test LD' Template on Recently Viewed Page.", true, 2000);

        }

        public IWebDriver T004_Login_004_UserLoginWithPaidUser(IWebDriver driver)
        {

            _driver = driver;

            T004_Login_004_UserLoginWithPaidUser();

            return _driver;
        }
        public void T004_Login_004_UserLoginWithPaidUser()
        {
            string strEmail = "kalpesh.ahir@krtya.co.in";
            string strPassword = "Pass#123";

            //new Common(_driver).pause(2000);
            IWebElement Home_lbl_Login = new Common(_driver).FindElement(By.XPath(ElementLocators.Home_lbl_Login), "'Login' Link on Login Page.", true, 2000);
            Report.AddToHtmlReport("STEP 2: Click on Login Link.", false, true);
            Home_lbl_Login.Click();

            _driver.SwitchTo().Window(_driver.WindowHandles.Last());
            new Common(_driver).pause(2000);
            IWebElement Home_txt_Email = new Common(_driver).FindElement(By.XPath(ElementLocators.Home_txt_Email), "'Email' TextBox on Login Page.", true, 2000);
            IWebElement Home_txt_Password = new Common(_driver).FindElement(By.XPath(ElementLocators.Home_txt_Password), "'Password' TextBox on Login Page.", true, 2000);
            new Common(_driver).pause(2000);
            IWebElement Home_btn_Login = new Common(_driver).FindElement(By.XPath(ElementLocators.Home_btn_Login), "'Login' Button on Login Page.", true);
            //new Common(_driver).pause(5000);
            Report.AddToHtmlReport("STEP 3: Enter Valid 'Email' and 'Password' in TextBox on Login Page.", false, true);

            Common.enterText(Home_txt_Email, strEmail);
            Common.enterText(Home_txt_Password, strPassword);

            Report.AddToHtmlReport("<br>Data Entered:", false, true, true);
            Report.AddToHtmlReport("<b>Login Email:</b> " + strEmail, false);
            Report.AddToHtmlReport("<b>Password: </b> " + strPassword + "<br>", false);

            Report.AddToHtmlReport("STEP 4: Click on 'Login' Button on Login Page.", false, true);

            Home_btn_Login.Click();
            new Common(_driver).pause(8000);
            IWebElement Home_lbl_AboutMe = new Common(_driver).FindElement(By.XPath(ElementLocators.Home_lbl_AboutMe), "'About me' Label on Home Page.", true);

        }



        internal IWebDriver Options_CancelOnInsert(IWebDriver driver)
        {
            throw new NotImplementedException();
        }


    }
}
