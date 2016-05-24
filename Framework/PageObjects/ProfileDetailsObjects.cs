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
    class ProfileDetailsObjects
    {
        IWebDriver _driver;
        public IWebDriver T006_Login_006_VerifyPinterestUpdate(IWebDriver driver)
        {

            _driver = driver;

            T006_Login_006_VerifyPinterestUpdate();

            return _driver;
        }
        public void T006_Login_006_VerifyPinterestUpdate()
        {
            
            new Common(_driver).LoginWithPaidUser(_driver);
            new Common(_driver).pause(3000);
            Report.AddToHtmlReport("STEP 5: Click on 'Profile Details' Link on Home Page.", false, true);
            IWebElement Home_img_Details = new Common(_driver).FindElementClick(By.XPath(ElementLocators.Home_img_Details), "'Details' Image on Home Page.", true, 2000);
            new Common(_driver).pause(3000);

            IWebElement Home_lnk_ProfileDetails = new Common(_driver).FindElementClick(By.XPath(ElementLocators.Home_lnk_ProfileDetails), "'Profile Details' Link on Home Page.", true, 2000);
            new Common(_driver).pause(3000);

            string strPinterest = "Pinterest";
            Report.AddToHtmlReport("STEP 6: Update 'Pinterest' URL.", false, true);

            IWebElement ProfileDetails_txt_Pinterest = new Common(_driver).FindElement(By.XPath(ElementLocators.ProfileDetails_txt_Pinterest), "'Pinterest' TextBox on Profile Details Page.", true, 2000);
            Common.enterText(ProfileDetails_txt_Pinterest, strPinterest);

            Report.AddToHtmlReport("<br>Data Entered:", false, true, true);
            Report.AddToHtmlReport("<b>Pinterest URL:</b> " + strPinterest, false);

            Report.AddToHtmlReport("STEP 7: Click on 'UPDATE' Button.", false, true);
            IWebElement ProfileDetails_btn_Update = new Common(_driver).FindElementClick(By.XPath(ElementLocators.ProfileDetails_btn_Update), "'UPDATE' Button on Profile Details Page.", true, 2000);
            new Common(_driver).pause(3000);

            IWebElement ProfileDetails_txt_Pinterest1 = new Common(_driver).FindElement(By.XPath(ElementLocators.ProfileDetails_txt_Pinterest), "'Pinterest' TextBox on Profile Details Page.", true, 2000);
            string strPinterest1 = new Common(_driver).ElementGetText(ProfileDetails_txt_Pinterest1);

            if (strPinterest1.Trim() == strPinterest.Trim())
            {
                Exception ex = new Exception();
                Report.AddToHtmlReportFailed(_driver, ex, "URL Updated Successfully for the input : 'Pinterest'");
            }
            else
            {
                Report.AddToHtmlReportPassed("URL Updated Successfully for the input : 'Pinterest'");
            }
        }


        public IWebDriver T010_Login_010_VerifyTwitterUpdate(IWebDriver driver)
        {

            _driver = driver;

            T010_Login_010_VerifyTwitterUpdate();

            return _driver;
        }
        public void T010_Login_010_VerifyTwitterUpdate()
        {

            new Common(_driver).LoginWithPaidUser(_driver);
            new Common(_driver).pause(3000);
            Report.AddToHtmlReport("STEP 5: Click on 'Profile Details' Link on Home Page.", false, true);
            IWebElement Home_img_Details = new Common(_driver).FindElementClick(By.XPath(ElementLocators.Home_img_Details), "'Details' Image on Home Page.", true, 2000);
            new Common(_driver).pause(3000);

            IWebElement Home_lnk_ProfileDetails = new Common(_driver).FindElementClick(By.XPath(ElementLocators.Home_lnk_ProfileDetails), "'Profile Details' Link on Home Page.", true, 2000);
            new Common(_driver).pause(3000);

            string strTwitter = "twitter";
            Report.AddToHtmlReport("STEP 6: Update 'Twitter' URL.", false, true);

            IWebElement ProfileDetails_txt_Twitter = new Common(_driver).FindElement(By.XPath(ElementLocators.ProfileDetails_txt_Twitter), "'Twitter' TextBox on Profile Details Page.", true, 2000);
            Common.enterText(ProfileDetails_txt_Twitter, strTwitter);

            Report.AddToHtmlReport("<br>Data Entered:", false, true, true);
            Report.AddToHtmlReport("<b>Twitter URL:</b> " + strTwitter, false);

            Report.AddToHtmlReport("STEP 7: Click on 'UPDATE' Button.", false, true);
            IWebElement ProfileDetails_btn_Update = new Common(_driver).FindElementClick(By.XPath(ElementLocators.ProfileDetails_btn_Update), "'UPDATE' Button on Profile Details Page.", true, 2000);
            new Common(_driver).pause(3000);

            IWebElement ProfileDetails_txt_Twitter1 = new Common(_driver).FindElement(By.XPath(ElementLocators.ProfileDetails_txt_Twitter), "'Twitter' TextBox on Profile Details Page.", true, 2000);
            string strTwitter1 = new Common(_driver).ElementGetText(ProfileDetails_txt_Twitter1);

            if (strTwitter1.Trim() == strTwitter.Trim())
            {
                Exception ex = new Exception();
                Report.AddToHtmlReportFailed(_driver, ex, "URL Updated Successfully for the input : 'twitter'");
            }
            else
            {
                Report.AddToHtmlReportPassed("URL Updated Successfully for the input : 'twitter'");
            }
        }


        public IWebDriver T011_Login_011_VerifyFacebookUpdate(IWebDriver driver)
        {

            _driver = driver;

            T011_Login_011_VerifyFacebookUpdate();

            return _driver;
        }
        public void T011_Login_011_VerifyFacebookUpdate()
        {

            new Common(_driver).LoginWithPaidUser(_driver);
            new Common(_driver).pause(3000);
            Report.AddToHtmlReport("STEP 5: Click on 'Profile Details' Link on Home Page.", false, true);
            IWebElement Home_img_Details = new Common(_driver).FindElementClick(By.XPath(ElementLocators.Home_img_Details), "'Details' Image on Home Page.", true, 2000);
            new Common(_driver).pause(3000);

            IWebElement Home_lnk_ProfileDetails = new Common(_driver).FindElementClick(By.XPath(ElementLocators.Home_lnk_ProfileDetails), "'Profile Details' Link on Home Page.", true, 2000);
            new Common(_driver).pause(3000);

            string strFacebook = "Facebook";
            Report.AddToHtmlReport("STEP 6: Update 'Facebook' URL.", false, true);

            IWebElement ProfileDetails_txt_Facebook = new Common(_driver).FindElement(By.XPath(ElementLocators.ProfileDetails_txt_Facebook), "'Facebook' TextBox on Profile Details Page.", true, 2000);
            Common.enterText(ProfileDetails_txt_Facebook, strFacebook);

            Report.AddToHtmlReport("<br>Data Entered:", false, true, true);
            Report.AddToHtmlReport("<b>Facebook URL:</b> " + strFacebook, false);

            Report.AddToHtmlReport("STEP 7: Click on 'UPDATE' Button.", false, true);
            IWebElement ProfileDetails_btn_Update = new Common(_driver).FindElementClick(By.XPath(ElementLocators.ProfileDetails_btn_Update), "'UPDATE' Button on Profile Details Page.", true, 2000);
            new Common(_driver).pause(3000);

            IWebElement ProfileDetails_txt_Facebook1 = new Common(_driver).FindElement(By.XPath(ElementLocators.ProfileDetails_txt_Facebook), "'Facebook' TextBox on Profile Details Page.", true, 2000);
            string strFacebook1 = new Common(_driver).ElementGetText(ProfileDetails_txt_Facebook1);

            if (strFacebook1.Trim() == strFacebook.Trim())
            {
                Exception ex = new Exception();
                Report.AddToHtmlReportFailed(_driver, ex, "URL Updated Successfully for the input : 'Facebook'");
            }
            else
            {
                Report.AddToHtmlReportPassed("URL Updated Successfully for the input : 'Facebook'");
            }
        }

        public IWebDriver T013_Login_013_VerifyLinkedInUpdate(IWebDriver driver)
        {

            _driver = driver;

            T013_Login_013_VerifyLinkedInUpdate();

            return _driver;
        }
        public void T013_Login_013_VerifyLinkedInUpdate()
        {

            new Common(_driver).LoginWithPaidUser(_driver);
            new Common(_driver).pause(3000);
            Report.AddToHtmlReport("STEP 5: Click on 'Profile Details' Link on Home Page.", false, true);
            IWebElement Home_img_Details = new Common(_driver).FindElementClick(By.XPath(ElementLocators.Home_img_Details), "'Details' Image on Home Page.", true, 2000);
            new Common(_driver).pause(3000);

            IWebElement Home_lnk_ProfileDetails = new Common(_driver).FindElementClick(By.XPath(ElementLocators.Home_lnk_ProfileDetails), "'Profile Details' Link on Home Page.", true, 2000);
            new Common(_driver).pause(3000);

            string strLinkedIn = "linkedin";
            Report.AddToHtmlReport("STEP 6: Update 'LinkedIn' URL.", false, true);

            IWebElement ProfileDetails_txt_LinkedIn = new Common(_driver).FindElement(By.XPath(ElementLocators.ProfileDetails_txt_LinkedIn), "'LinkedIn' TextBox on Profile Details Page.", true, 2000);
            Common.enterText(ProfileDetails_txt_LinkedIn, strLinkedIn);

            Report.AddToHtmlReport("<br>Data Entered:", false, true, true);
            Report.AddToHtmlReport("<b>LinkedIn URL:</b> " + strLinkedIn, false);

            Report.AddToHtmlReport("STEP 7: Click on 'UPDATE' Button.", false, true);
            IWebElement ProfileDetails_btn_Update = new Common(_driver).FindElementClick(By.XPath(ElementLocators.ProfileDetails_btn_Update), "'UPDATE' Button on Profile Details Page.", true, 2000);
            new Common(_driver).pause(3000);

            IWebElement ProfileDetails_txt_LinkedIn1 = new Common(_driver).FindElement(By.XPath(ElementLocators.ProfileDetails_txt_LinkedIn), "'LinkedIn' TextBox on Profile Details Page.", true, 2000);
            string strLinkedIn1 = new Common(_driver).ElementGetText(ProfileDetails_txt_LinkedIn1);

            if (strLinkedIn1.Trim() == strLinkedIn.Trim())
            {
                Exception ex = new Exception();
                Report.AddToHtmlReportFailed(_driver, ex, "URL Updated Successfully for the input : 'LinkedIn'");
            }
            else
            {
                Report.AddToHtmlReportPassed("URL Updated Successfully for the input : 'LinkedIn'");
            }
        }


        public IWebDriver T016_Login_016_VerifyBookmarkAdded(IWebDriver driver)
        {

            _driver = driver;

            T016_Login_016_VerifyBookmarkAdded();

            return _driver;
        }
        public void T016_Login_016_VerifyBookmarkAdded()
        {

            new Common(_driver).LoginWithPaidUser(_driver);
            new Common(_driver).pause(3000);
            IWebElement Home_txt_Search = new Common(_driver).FindElement(By.XPath(ElementLocators.Home_txt_Search), "'Search' TextBox on Home Page.", true, 2000);

            Report.AddToHtmlReport("STEP 5: Enter 'test' in a Search TextBox.", false, true);

            Common.enterText(Home_txt_Search, "test");

            Report.AddToHtmlReport("<br>Data Entered:", false, true, true);
            Report.AddToHtmlReport("<b>Search:</b> " + "test", false);

            new Common(_driver).pause(2000);
            System.Windows.Forms.SendKeys.SendWait(@"{Enter}");
            new Common(_driver).pause(3000);
            Report.AddToHtmlReport("STEP 6: Click on Bookmark icon to Move Template into Bookmark.", false, true);
            IWebElement Template_img_Bookmark = new Common(_driver).FindElementClick(By.XPath(ElementLocators.Template_img_Bookmark), " 'Bookmark' icon on Template Page.", true, 2000);
            Report.AddToHtmlReportPassed("'Template added to bookmarks folder' tooltip present.");
            Report.AddToHtmlReport("STEP 7: Click on Logo.", false, true);
            IWebElement Home_img_Logo = new Common(_driver).FindElementClick(By.XPath(ElementLocators.Home_img_Logo), " 'Logo' icon on Home Page.", true, 2000);
            Report.AddToHtmlReport("STEP 8: Click on Bookmark Folder.", false, true);
            IWebElement Home_div_Bookmark = new Common(_driver).FindElementClick(By.XPath(ElementLocators.Home_div_Bookmark), " 'Bookmark' Folder on Home Page.", true, 2000);
            Report.AddToHtmlReport("STEP 9: Verify Template.", false, true);
            IWebElement Bookmark_img_Bookmark = new Common(_driver).FindElement(By.XPath(ElementLocators.Bookmark_img_Bookmark), " Template available on Bookmark Page.", true, 2000);

           
        }
    }
}
