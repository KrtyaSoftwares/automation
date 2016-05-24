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
    class InspirationWallObjects
    {
        IWebDriver _driver;
        public IWebDriver T008_Login_008_VerifyShareFunctionality(IWebDriver driver)
        {

            _driver = driver;

            T008_Login_008_VerifyShareFunctionality();


            return _driver;
        }
        public void T008_Login_008_VerifyShareFunctionality()
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
            IWebElement Search_div_test = new Common(_driver).FindElement(By.XPath(ElementLocators.Search_div_test), "'test LD' Template on Search Page.", true, 2000);

            Report.AddToHtmlReport("STEP 6: Click on 'Share' icon on Template.", false, true);
            IWebElement Template_btn_Share = new Common(_driver).FindElementClick(By.XPath(ElementLocators.Template_btn_Share), "'Share' icon on Share Template Page.", true, 2000);
            new Common(_driver).pause(3000);
            IWebElement Share_lbl_Share = new Common(_driver).FindElement(By.XPath(ElementLocators.Share_lbl_Share), "'Share' Lable on Share Template Page.", true, 2000);
            IWebElement Share_img_Facebook = new Common(_driver).FindElement(By.XPath(ElementLocators.Share_img_Facebook), "'Facebook' icon on Share Template Page.", true, 2000);
            IWebElement Share_img_Twitter = new Common(_driver).FindElement(By.XPath(ElementLocators.Share_img_Twitter), "'Twitter' icon on Share Template Page.", true, 2000);
            IWebElement Share_img_Pinterest = new Common(_driver).FindElement(By.XPath(ElementLocators.Share_img_Pinterest), "'Pinterest' icon on Share Template Page.", true, 2000);

            new Common(_driver).pause(3000);

        }

        public IWebDriver T009_Login_009_VerifyBookmarkFunctionality(IWebDriver driver)
        {

            _driver = driver;

            T009_Login_009_VerifyBookmarkFunctionality();


            return _driver;
        }
        public void T009_Login_009_VerifyBookmarkFunctionality()
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
            Report.AddToHtmlReport("STEP 7: Click on Logo.", false, true);
            IWebElement Home_img_Logo = new Common(_driver).FindElementClick(By.XPath(ElementLocators.Home_img_Logo), " 'Logo' icon on Home Page.", true, 2000);
            Report.AddToHtmlReport("STEP 8: Click on Bookmark Folder.", false, true);
            IWebElement Home_div_Bookmark = new Common(_driver).FindElementClick(By.XPath(ElementLocators.Home_div_Bookmark), " 'Bookmark' Folder on Home Page.", true, 2000);
            Report.AddToHtmlReport("STEP 9: Click on Bookmark icon to Remove from Bookmark.", false, true);
            IWebElement Bookmark_img_Bookmark = new Common(_driver).FindElementClick(By.XPath(ElementLocators.Bookmark_img_Bookmark), " 'Bookmark' icon on Bookmark Page.", true, 2000);
            Report.AddToHtmlReportPassed ("Template will be remove from bookmark folder tooltip verified");
            Report.AddToHtmlReport("STEP 10: Click on Logo.", false, true);
            IWebElement Home_img_Logo1 = new Common(_driver).FindElementClick(By.XPath(ElementLocators.Home_img_Logo), " 'Logo' icon on Home Page.", true, 2000);

        }
    }
}
