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
    class EditorObjects
    {
        IWebDriver _driver;
        public IWebDriver T005_Login_005_VerifyCreateTemplate(IWebDriver driver)
        {

            _driver = driver;

            T005_Login_005_VerifyCreateTemplate();


            return _driver;
        }
        public void T005_Login_005_VerifyCreateTemplate()
        {
            string strTemplateName = "AutoQA" + new Common(_driver).generateRandomChars(5);
            new Common(_driver).LoginWithPaidUser(_driver);
            new Common(_driver).pause(3000);

            IWebElement Home_img_Document = new Common(_driver).FindElementClick(By.XPath(ElementLocators.Home_img_Document), "", true, 2000);
            IWebElement Home_lnk_GotoEditor = new Common(_driver).FindElement(By.XPath(ElementLocators.Home_lnk_GotoEditor), "'Go to Editor' Link on Home Page.", true, 2000);


            Report.AddToHtmlReport("STEP 5: Click on 'Go to Editor' Link on Home Page.", false, true);
            Home_lnk_GotoEditor.Click();
            new Common(_driver).pause(7000);
            Report.AddToHtmlReport("STEP 6: Create New Template.", false, true);
            IWebElement Editor_img_Element = new Common(_driver).FindElementClick(By.XPath(ElementLocators.Editor_img_Element), "Click on 'Elements' Image on Create New Template Page.", true, 2000);
            //new Common(_driver).pause(3000);
            IWebElement Editor_img_Element1 = new Common(_driver).FindElementClick(By.XPath(ElementLocators.Editor_img_Element1), "Select Element from Create New Template Page.", true, 2000);
            new Common(_driver).pause(2000);
            IWebElement Editor_txt_TemplateName = new Common(_driver).FindElement(By.XPath(ElementLocators.Editor_txt_TemplateName), "'Name this Template' TextBox on Create New Template Page.", true, 2000);
            Common.enterText(Editor_txt_TemplateName, strTemplateName);

            Report.AddToHtmlReport("<br>Data Entered:", false, true, true);
            Report.AddToHtmlReport("<b>Template Name:</b> " + strTemplateName, false);
            new Common(_driver).pause(10000);
            Report.AddToHtmlReport("STEP 7: Click on 'Save' and 'MAKE PUBLIC' Button Respectively.", false, true);
            IWebElement Editor_btn_Save = new Common(_driver).FindElementClick(By.XPath(ElementLocators.Editor_btn_Save), "'Save' Button on  Create New Template Page.", true, 2000);
            new Common(_driver).pause(5000);
            IWebElement Editor_btn_MakePublic = new Common(_driver).FindElementClick(By.XPath(ElementLocators.Editor_btn_MakePublic), "'MAKE PUBLIC' Button on  Create New Template Page.", true, 2000);


            Report.AddToHtmlReport("STEP 8: Click on 'My Profile' Link.", false, true);
            new Common(_driver).pause(5000);
            IWebElement Home_img_Details = new Common(_driver).FindElementClick(By.XPath(ElementLocators.Home_img_Details), "'Details' Image on Home Page.", true, 2000);
            new Common(_driver).pause(5000);
            IWebElement AccountDetails_lnk_MyProfile = new Common(_driver).FindElementClick(By.XPath(ElementLocators.AccountDetails_lnk_MyProfile), "'My Profile' Link on Home Page.", true, 2000);
            new Common(_driver).pause(5000);

            IWebElement Home_div_MyWork = new Common(_driver).FindElement(By.XPath(ElementLocators.Home_div_MyWork), "'My Work' Button on  Create New Template Page.", true, 2000);

            Report.AddToHtmlReport("STEP 9: Click on 'My Work' Link and Verify the Template.", false, true);
            Home_div_MyWork.Click();
            new Common(_driver).pause(5000);
            IWebElement Mywork_div_Template = new Common(_driver).FindElement(By.XPath("//div[@id='wrapper']/div[2]/div[3]/div/ng-include/div/div/div[contains(.,'" + strTemplateName + "')]/div/div[1]/div"), "'" + strTemplateName + "' Template Available on My Work Page.", true, 2000);

        }


        public IWebDriver T007_Login_007_VerifyPrintFunctionality(IWebDriver driver)
        {

            _driver = driver;

            T007_Login_007_VerifyPrintFunctionality();


            return _driver;
        }
        public void T007_Login_007_VerifyPrintFunctionality()
        {
            string strTemplateName = "AutoQA" + new Common(_driver).generateRandomChars(5);
            new Common(_driver).LoginWithPaidUser(_driver);
            new Common(_driver).pause(3000);

            IWebElement Home_img_Document = new Common(_driver).FindElementClick(By.XPath(ElementLocators.Home_img_Document), "", true, 2000);
            IWebElement Home_lnk_GotoEditor = new Common(_driver).FindElement(By.XPath(ElementLocators.Home_lnk_GotoEditor), "'Go to Editor' Link on Home Page.", true, 2000);


            Report.AddToHtmlReport("STEP 5: Click on 'Go to Editor' Link on Home Page.", false, true);
            Home_lnk_GotoEditor.Click();
            new Common(_driver).pause(7000);
            Report.AddToHtmlReport("STEP 6: Create New Template.", false, true);
            IWebElement Editor_img_Element = new Common(_driver).FindElementClick(By.XPath(ElementLocators.Editor_img_Element), "Click on 'Elements' Image on Create New Template Page.", true, 2000);
            //new Common(_driver).pause(3000);
            IWebElement Editor_img_Element1 = new Common(_driver).FindElementClick(By.XPath(ElementLocators.Editor_img_Element1), "Select Element from Create New Template Page.", true, 2000);
            new Common(_driver).pause(2000);
            IWebElement Editor_txt_TemplateName = new Common(_driver).FindElement(By.XPath(ElementLocators.Editor_txt_TemplateName), "'Name this Template' TextBox on Create New Template Page.", true, 2000);
            Common.enterText(Editor_txt_TemplateName, strTemplateName);

            Report.AddToHtmlReport("<br>Data Entered:", false, true, true);
            Report.AddToHtmlReport("<b>Template Name:</b> " + strTemplateName, false);
            new Common(_driver).pause(10000);
            Report.AddToHtmlReport("STEP 7: Click on 'Save' Button.", false, true);
            IWebElement Editor_btn_Save = new Common(_driver).FindElementClick(By.XPath(ElementLocators.Editor_btn_Save), "'Save' Button on  Create New Template Page.", true, 2000);
            new Common(_driver).pause(5000);
            Report.AddToHtmlReport("STEP 8: Click on 'Print' Icon.", false, true);
            IWebElement Editor_btn_Print = new Common(_driver).FindElementClick(By.XPath(ElementLocators.Editor_btn_Print), "'Print' Button on  Create New Template Page.", true, 2000);
            new Common(_driver).pause(5000);
            Report.AddToHtmlReportPassed("Template is open in a New Tab");
        }
    }
}
