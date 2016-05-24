using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Data;
using System.Data.OleDb;
using System.Configuration;
using Framework.PageObjects;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using NUnit.Framework;

using System.Linq;
using Framework.Init;

namespace Framework.Init
{

    public class Common
    {
        DateTime date = new DateTime();
        protected IWait<IWebDriver> wait;
        protected IWebDriver driver;
        //public string strFactoryName = string.Empty;

        public void LoginWithPaidUser(IWebDriver _driver)
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
        public IWebElement FindElementWithDynamic(IWebDriver driver, By elementXpath, string strReportMessage = "")
        {
            IWebElement element = null;

            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMinutes(5));
                element = wait.Until<IWebElement>((d) =>
                {
                    return d.FindElement(elementXpath);
                });

                if (strReportMessage.Trim().Length > 0)
                {
                    {
                        Report.AddToHtmlReportPassed(strReportMessage);
                    }
                }
            }
            catch (Exception ex)
            {
                Report.AddToHtmlReportFailed(driver, ex, strReportMessage);
                driver.Close();
                Assert.Fail();
            }
            return element;
        }
        //public void CheckForAlreadyLogin(IWebDriver _driver)
        //{
        //    new Common(_driver).pause(8000);
        //    if (new Common(_driver).CheckElementPresent(_driver, "//h1[contains(.,'Dashboard')]") == true)
        //    {
        //        Report.AddToHtmlReport("<b>User is already logged in</b>");
        //        Report.AddToHtmlReport("<br>");
        //        Report.AddToHtmlReport("STEP : Click on 'User menu' DropdownList and 'Sign Out' on FFC Dashboard Page.", false, true);
        //        IWebElement Dashboard_ddl_UserMenu = new Common(_driver).FindElementClick(By.XPath(ElementLocators.Dashboard_ddl_UserMenu), "'User menu' DropdownList on FFC Dashboard Page.", true, 2000);
        //        new Common(_driver).pause(3000);
        //        IWebElement Dashboard_ddl_UserMenu_Signout = new Common(_driver).FindElementClick(By.XPath(ElementLocators.Dashboard_ddl_UserMenu_Signout), "'Sign Out' Button.");
        //        new Common(_driver).pause(3000);
        //    }
        //}
        //public void Login1()
        //{
            
        //    //Login Process
        //    ///////////////////////////////
        //    string strEmail = "sapan.s@edspl.com";
        //    string strPassword = "qa";

        //    new Common(driver).pause(2000);
        //    // IWebElement Login_lbl_SignIn = new Common(_driver).FindElement(By.XPath(ElementLocators.Login_lbl_SignIn), "'Sign In' label on FFC Login page.", true, 2000);
        //    IWebElement Login_txt_Email = new Common(driver).FindElement(By.XPath(ElementLocators.Login_txt_Email), "'Email' textbox on FFC Login page.", true, 2000);
        //    IWebElement Login_txt_Password = new Common(driver).FindElement(By.XPath(ElementLocators.Login_txt_Password), "'Password' textbox on FFC Login page.", true, 2000);
        //    IWebElement Login_btn_SignMeIn = new Common(driver).FindElement(By.XPath(ElementLocators.Login_btn_SignMeIn), "'Sign me in' button on FFC Login page.", true);

        //    Report.AddToHtmlReport("Login: Enter valid 'Email' and 'Password' in textbox on Login page.", false, true);
        //    Common.enterText(Login_txt_Email, strEmail);
        //    Common.enterText(Login_txt_Password, strPassword);

        //    Report.AddToHtmlReport("<br>Data Entered:", false, true, true);
        //    Report.AddToHtmlReport("<b>Login Email:</b> " + strEmail, false);
        //    Report.AddToHtmlReport("<b>Password:</b> " + strPassword + "<br>", false);

        //    Report.AddToHtmlReport("Login: Click on 'Sign me in' Button on Login page.", false, true);

        //    Login_btn_SignMeIn.Click();
        //    new Common(driver).pause(8000);

        //    IWebElement Dashboard_lbl_Dashboard = new Common(driver).FindElement(By.XPath(ElementLocators.Dashboard_lbl_Dashboard), "'Dashboard' label on FFC Dashboard page.", true, 2000);
        //}
        //public void Login2()
        //{
        //    //Login Process
        //    ///////////////////////////////
        //    string strEmail = "testlogin123@gmail.com";
        //    string strPassword = "qa";

        //    new Common(driver).pause(2000);
        //    // IWebElement Login_lbl_SignIn = new Common(_driver).FindElement(By.XPath(ElementLocators.Login_lbl_SignIn), "'Sign In' label on FFC Login page.", true, 2000);
        //    IWebElement Login_txt_Email = new Common(driver).FindElement(By.XPath(ElementLocators.Login_txt_Email), "'Email' textbox on FFC Login page.", true, 2000);
        //    IWebElement Login_txt_Password = new Common(driver).FindElement(By.XPath(ElementLocators.Login_txt_Password), "'Password' textbox on FFC Login page.", true, 2000);
        //    IWebElement Login_btn_SignMeIn = new Common(driver).FindElement(By.XPath(ElementLocators.Login_btn_SignMeIn), "'Sign me in' button on FFC Login page.", true);

        //    Report.AddToHtmlReport("Login: Enter valid 'Email' and 'Password' in textbox on Login page.", false, true);
        //    Common.enterText(Login_txt_Email, strEmail);
        //    Common.enterText(Login_txt_Password, strPassword);

        //    Report.AddToHtmlReport("<br>Data Entered:", false, true, true);
        //    Report.AddToHtmlReport("<b>Login Email:</b> " + strEmail, false);
        //    Report.AddToHtmlReport("<b>Password:</b> " + strPassword + "<br>", false);

        //    Report.AddToHtmlReport("Login: Click on 'Sign me in' Button on Login page.<br>", false, true);

        //    Login_btn_SignMeIn.Click();
        //    new Common(driver).pause(5000);

        //}
        public void DeletePreviousExcelFiles()
        {
            //Delete Previous Excel Files
            DirectoryInfo hdDirectoryInWhichToSearch = new DirectoryInfo(@"C:\FFC-Documents");

            FileInfo[] filesInDir = hdDirectoryInWhichToSearch.GetFiles("*.xls");
            try
            {
                foreach (FileInfo foundFile in filesInDir)
                {
                    string fullName = foundFile.FullName;
                    foundFile.Delete();
                }
            }
            catch (Exception)
            {

            }
            ////////////////////////////////
        }
        public void ReadLatestDownloadedExcelFile(IWebDriver _driver)
        {
            string strExportedFile = string.Empty;

            DirectoryInfo hdDirectoryInWhichToSearch = new DirectoryInfo(@"C:\FFC-Documents");
            FileInfo[] filesInDir = hdDirectoryInWhichToSearch.GetFiles("*.xls");
            try
            {
                foreach (FileInfo foundFile in filesInDir)
                {
                    strExportedFile = foundFile.FullName.Trim();
                }
            }
            catch (Exception)
            {

            }
            int intExportedfilerowcount = 0;
            try
            {
                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                Excel.Range range;

                xlApp = new Excel.Application();

                new Common(_driver).pause(5000);

                xlWorkBook = xlApp.Workbooks.Open(strExportedFile, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                range = xlWorkSheet.UsedRange;
                intExportedfilerowcount = range.Rows.Count - 1;

                Console.WriteLine(strExportedFile + " row count :" + intExportedfilerowcount);
                Report.AddToHtmlReportPassed("'" + strExportedFile + "' Downloaded Successfully.");

                Report.AddToHtmlReportPassed("'" + strExportedFile + "' contains '" + intExportedfilerowcount + "' Record(s).");
                xlWorkBook.Close(true, null, null);
                xlApp.Quit();
                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);

            }
            catch (Exception ex)
            {
                Report.AddToHtmlReportFailed(_driver, ex, "Error File Reading Problem.");
            }

            ////if (intRecordCount == intExportedfilerowcount)
            ////{
            //    Report.AddToHtmlReportPassed("'All Records Exported Successfully'");
            //}
        }

        public void DeletePreviousPDFFiles()
        {
            //Delete Previous Excel Files
            DirectoryInfo hdDirectoryInWhichToSearch = new DirectoryInfo(@"C:\FFC-Documents");

            FileInfo[] filesInDir = hdDirectoryInWhichToSearch.GetFiles("*.pdf");
            try
            {
                foreach (FileInfo foundFile in filesInDir)
                {
                    string fullName = foundFile.FullName;
                    foundFile.Delete();
                }
            }
            catch (Exception)
            {

            }
            ////////////////////////////////
        }
        public void ReadLatestDownloadedPDFFile(IWebDriver _driver)
        {
            string strExportedFile = string.Empty;

            DirectoryInfo hdDirectoryInWhichToSearch = new DirectoryInfo(@"C:\FFC-Documents");
            FileInfo[] filesInDir = hdDirectoryInWhichToSearch.GetFiles("*.pdf");

            Console.WriteLine("total pdf are:" + filesInDir.Length);
            try
            {
                //Console.WriteLine("1");
                foreach (FileInfo foundFile in filesInDir)
                {
                    //Console.WriteLine("2");
                    strExportedFile = foundFile.FullName.Trim();
                    //Console.WriteLine(foundFile.FullName.Trim());
                }
            }
            catch (Exception)
            {

            }
            //Console.WriteLine("3");
            Console.WriteLine(strExportedFile);
            if (strExportedFile.Trim() != "")
            {
                Report.AddToHtmlReportPassed("'" + strExportedFile + "'" + "' file Exported Successfully.'");
            }
        }

        public void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
        //public void login()
        //{
        //    //Login Process
        //    ///////////////////////////////

        //    string strEmail = Convert.ToString(ConfigurationSettings.AppSettings.Get("Email"));
        //    string strPassword = Convert.ToString(ConfigurationSettings.AppSettings.Get("Password"));

        //    new Common(driver).pause(2000);
        //    // IWebElement Login_lbl_SignIn = new Common(_driver).FindElement(By.XPath(ElementLocators.Login_lbl_SignIn), "'Sign In' label on FFC Login page.", true, 2000);
        //    IWebElement Login_txt_Email = new Common(driver).FindElement(By.XPath(ElementLocators.Login_txt_Email), "'Email' textbox on FFC Login page.", true, 2000);
        //    IWebElement Login_txt_Password = new Common(driver).FindElement(By.XPath(ElementLocators.Login_txt_Password), "'Password' textbox on FFC Login page.", true, 2000);
        //    IWebElement Login_btn_SignMeIn = new Common(driver).FindElement(By.XPath(ElementLocators.Login_btn_SignMeIn), "'Sign me in' button on FFC Login page.", true);

        //    Report.AddToHtmlReport("STEP 2: Enter valid 'Email' and 'Password' in textbox on Login page.", false, true);
        //    Common.enterText(Login_txt_Email, strEmail);
        //    Common.enterText(Login_txt_Password, strPassword);

        //    Report.AddToHtmlReport("<br>Data Entered:", false, true, true);
        //    Report.AddToHtmlReport("<b>Login Email: </b>" + strEmail, false);
        //    Report.AddToHtmlReport("<b>Password: </b>" + strPassword + "<br>", false);

        //    Report.AddToHtmlReport("STEP 3: Click on 'Sign me in' Button on Login page.", false, true);

        //    Login_btn_SignMeIn.Click();
        //    new Common(driver).pause(8000);

        //    IWebElement Dashboard_lbl_Dashboard = new Common(driver).FindElement(By.XPath(ElementLocators.Dashboard_lbl_Dashboard), "'Dashboard' label on FFC Dashboard page.", true, 2000);
        //    ///////////////////////////////////

        //    new Common(driver).pause(2000);
        //    //string AffiliationMember = System.IO.File.ReadAllText(@"C:\FFC-Documents\Member_Affiliation.txt");
        //    string[] lines = System.IO.File.ReadAllLines(@"C:\FFC-Documents\Member_Affiliation.txt");
        //    string AffiliationMember = lines[0];
        //    ElementLocators.strFactoryID = lines[1];
        //    ElementLocators.strOrganizationID = lines[2];
        //    Console.WriteLine("member: " + AffiliationMember);
        //    Console.WriteLine("factory: " + ElementLocators.strFactoryID);
        //    Console.WriteLine("Organization: " + ElementLocators.strOrganizationID);
        //    if (AffiliationMember.Trim() != "Fair Factories Clearinghouse")
        //    {
        //        Report.AddToHtmlReport("Select 'Example Member' Member from Member Affiliation for Create Member Custom Field Data.", false, true);
        //        IWebElement Home_ddl_UserMenu = new Common(driver).FindElementClick(By.XPath(ElementLocators.Home_ddl_UserMenu), "Click on 'User' Menu Dropdown on Home page.", true);
        //        new Common(driver).pause(2000);

        //        IWebElement UserMenu_lnk_MemberAffiliation = new Common(driver).FindElementClick(By.XPath(ElementLocators.UserMenu_lnk_MemberAffiliation), "Click on 'Member Affiliation' Link Inside User Dropdown menu.", true);
        //        new Common(driver).pause(5000);
        //        driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe")));
        //        new Common(driver).pause(3000);

        //        IWebElement MemberAffiliation_ddl_Record = new Common(driver).FindElementClick(By.XPath("//select[@name='gridData_length']/option[4]"));

        //        if (AffiliationMember.Trim() != string.Empty)
        //        {
        //            IWebElement MemberAffiliation_txt_Search = new Common(driver).FindElement(By.XPath(ElementLocators.MemberAffiliation_txt_Search), "'Search' textbox on Member Affiliation Dialog.", true, 2000);
        //            Common.enterText(MemberAffiliation_txt_Search, AffiliationMember.Trim());
        //            Report.AddToHtmlReport("<br>Data Entered:", false, true, true);
        //            Report.AddToHtmlReport("<b>Affiliated Member:</b>" + AffiliationMember, false);
        //            new Common(driver).pause(2000);
        //            IWebElement MemberAffiliation_popup_MemberName = new Common(driver).FindElementClick(By.XPath("//a[contains(.,'" + AffiliationMember + "')]"), "Select  '" + AffiliationMember + "' Member from Member Affiliations popup.", true);
        //            new Common(driver).pause(10000);
        //        }
        //        else
        //        {
        //            IWebElement MemberAffiliation_popup_Close = new Common(driver).FindElementClick(By.XPath("//button[@id='id_close']"), "Click Close Button on  Member Affiliations popup.", true);
        //        }

        //        driver.SwitchTo().DefaultContent();
        //        new Common(driver).pause(3000);
        //    }

        //}
        public Common(IWebDriver driver)
        {

            this.driver = driver;
        }
        /* "isElement" method is used for checking is element present on the page or not */

        //    public boolean isElementPresent (WebElement webElement){
        //		return webElement != null;		
        //    }


        public string ElementGetText(IWebElement element, string strReportMessage = "", int PauseTime = 3000)
        {
            string strRetVal = string.Empty;
            try
            {
                pause(PauseTime);
                if (element != null)
                {
                    strRetVal = element.Text;
                    if (strRetVal.Trim().Length == 0) strRetVal = element.GetAttribute("value");
                }
                //if (strReportMessage.Trim().Length > 0) Report.AddToHtmlReportPassed(strReportMessage);
            }
            catch (Exception ex)
            {
                Report.AddToHtmlReportFailed(driver, ex, "Error while fetching text from given element.");
            }
            return strRetVal;
        }
        public void CheckFolderPresent()
        {
            if (System.IO.Directory.Exists(@"C:\FFC-Documents") == false)
            {
                System.IO.Directory.CreateDirectory(@"C:\FFC-Documents");
            }
            //string strExcelFilePath = Application.StartupPath + @"\" + "BSCIExcelFiles";
            //Console.WriteLine("excel file path " + strExcelFilePath);
            //if (System.IO.Directory.Exists(strExcelFilePath) == false)
            //{
            //    System.IO.Directory.CreateDirectory(strExcelFilePath);
            //}
        }
        public string strReplaceEscapeCharacter(string strReplaceString)
        {
            strReplaceString = strReplaceString.Replace("'", "''");
            strReplaceString = strReplaceString.Replace(@"\", @"\\");
            return strReplaceString;
        }
        public bool CheckElementPresent(IWebDriver _driver, string xpath)
        {
            try
            {
                _driver.FindElement(By.XPath(xpath));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }

        }
        public Boolean isElementPresent(IWebElement webElement)
        {
            if (webElement != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void createNewCookie(IWebDriver driver, String key, String value)
        {
            Cookie cookie = new Cookie(key, value);
            driver.Manage().Cookies.AddCookie(cookie);
        }

        public void ScrolltoView(IWebDriver driver, IWebElement element)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView();", element);

        }

        //    public ExpectedCondition<IWebElement> visibilityOfElementLocated(final By by) {
        //    return new ExpectedCondition<IWebElement>() {

        //    public IWebElement apply(IWebDriver driver) {
        //        IWebElement element = driver.FindElement( by);
        //        return element.isDisplayed() ? element : null;
        //      }
        //    };
        //}

        public void waitForElement(String selector)
        {
            TimeSpan ts = new TimeSpan(0, 0, 20);
            wait = new WebDriverWait(driver, ts);
            try
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(selector)));
            }
            catch (TimeoutException e)
            {
            }
        }

        public void waitForElement(By element)
        {
            TimeSpan t1 = new TimeSpan(00, 01, 00);
            wait = new WebDriverWait(driver, t1);
            try
            {
                wait.PollingInterval = new TimeSpan(00, 00, 01);
                wait.Until(ExpectedConditions.ElementIsVisible(element));
            }
            catch (TimeoutException e)
            {
            }
            catch (StaleElementReferenceException staleElementReferenceException)
            {

            }
        }


        /** 
	 * Pauses the thread for a period of time.
	 * 
	 * @param mseconds			mseconds  to pause the thread.
	 */
        public void pause(int mseconds)
        {
            try
            {
                Thread.Sleep(mseconds);
            }
            catch (ThreadInterruptedException e)
            {
            }
        }

        public static void pauseStatic(int mseconds)
        {
            try
            {
                Thread.Sleep(mseconds);
            }
            catch (ThreadInterruptedException e)
            {
            }
        }

        public void waitForElementHide(String xpath)
        {
            IWebElement elementToWait;
            int counter = 0;
            elementToWait = driver.FindElement(By.XPath(xpath));
            Boolean isDisplayed = this.isElementDisplayed(elementToWait);
            do
            {
                this.pause(3000);
                isDisplayed = this.isElementDisplayed(elementToWait);
                counter++;
            }
            while (isDisplayed && counter < 10);

        }

        /**
	 * Checks whether the needed WebElement is displayed or not.
	 * 
	 * @param element	Needed element
	 * 
	 * @return	true or false.
	 */
        public Boolean isElementDisplayed(IWebElement element)
        {
            try
            {
                return element.Displayed;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public void waitUntilElementIsVisible(By by)
        {
            TimeSpan t1 = new TimeSpan(00, 00, 20);
            WebDriverWait wait = new WebDriverWait(driver, t1);
            wait.Until(ExpectedConditions.ElementIsVisible(by));
        }

        public void waitForElementHide(IWebElement elementToWait)
        {
            Boolean isDisplayed = false;
            int counter = 0;
            try
            {
                isDisplayed = elementToWait.Displayed;
            }
            catch (Exception e)
            {

            }
            while (isDisplayed && counter < 10)
            {
                this.pause(3000);
                isDisplayed = this.isElementDisplayed(elementToWait);
                counter++;
            }
        }

        public String ajaxFinised(String num)
        {
            Object isAjaxFinished;
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            isAjaxFinished = js.ExecuteScript("return jQuery.active == " + num);
            return isAjaxFinished.ToString();
        }

        public String getInnerHTML(String elementID)
        {
            Object innerHTML;
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            innerHTML = js.ExecuteScript("return document.getElementById('" + elementID + "').innerHTML");
            return innerHTML.ToString();
        }

        public void waitForAjax(String num)
        {
            String ajax;
            for (int second = 0; ; second++)
            {
                ajax = this.ajaxFinised(num);

                if (second >= 15)
                {
                    break;
                }
                else if (ajax.Equals("true"))
                {
                    break;
                }
                this.pause(1000);
            }
        }

        public void waitForAjax()
        {
            String ajax;
            for (int second = 0; ; second++)
            {
                ajax = this.ajaxFinised("0");
                if (second >= 15)
                {
                    break;
                }
                else if (ajax.Equals("true"))
                {
                    break;
                }
                this.pause(1000);
            }
        }

        /**
	 * Generates random symbols;
	 * 
	 * @param length	Length of the generated symbols.
	 * 
	 * @return	StringBuffer object.
	 */
        public static String generateRandomSymbols(int length)
        {
            String total = "TheQuickBrownFoxJumpsOverTheLazyDog1234567890";
            //StringBuffer buf = new StringBuffer();
            StringBuilder buf = new StringBuilder();
            char _char;
            for (int i = 0; i < length; i++)
            {
                //char _char = total.charAt((int)(Math.random() * 100) % total.length());
                Random r1 = new Random();
                _char = total[r1.Next(0, total.Length - 1)];
                buf.Append(_char);
            }
            return buf.ToString();
        }

        /**
	 * Generates random symbols;
	 * 
	 * @param length	Length of the generated symbols.
	 * 
	 * @return	StringBuffer object.
	 */
        public String generateRandomChars(int length, bool IsSpacReqd = false)
        {
            String total = string.Empty;
            if (IsSpacReqd) total = "The QuickBrownFoxJumpsOverTheLazyDog";
            else total = "TheQuickBrownFoxJumpsOverTheLazyDog";

            //StringBuffer buf = new StringBuffer();
            StringBuilder buf = new StringBuilder();
            char _char;
            Random r1 = new Random();
            for (int i = 0; i < length; i++)
            {
                //char _char = total.charAt((int)(Math.random() * 100) % total.length());

                _char = total[r1.Next(0, total.Length - 1)];
                buf.Append(_char);
            }
            return buf.ToString();
        }

        /**
	 * Gets current time in the following format
	 * Month, Date, Hours, Minutes, Seconds, Millisecond.
	 * 
	 * @return Current date.
	 */
        //public String getCurrentTimeStampString()
        //{

        //    DateTime date = new DateTime();

        //    //SimpleDateFormat sd = new SimpleDateFormat("MMddHHmmssSS");
        //    TimeZone timeZone = TimeZone.CurrentTimeZone;

        //    Calendar cal = new Calendar();
        //    cal.get
        //    Calendar cal = Calendar.getInstance(new SimpleTimeZone(timeZone.getOffset(date.getTime()), "GMT"));
        //    sd.setCalendar(cal);
        //    return sd.format(date);




        //    java.util.Date date = new java.util.Date();

        //    SimpleDateFormat sd = new SimpleDateFormat("MMddHHmmssSS");
        //    TimeZone timeZone = TimeZone.getDefault();
        //    Calendar cal = Calendar.getInstance(new SimpleTimeZone
        //                (timeZone.getOffset(date.getTime()), "GMT"));
        //    sd.setCalendar(cal);
        //    return sd.format(date);
        //}


        public String generateRandomString(int length)
        {
            Random random = new Random();
            String result = "";
            for (int i = 0; i < length; i++)
            {
                int rndChrCode = random.Next(1, 52);
                if (rndChrCode > 25)
                {
                    rndChrCode += 6;
                }
                rndChrCode += 65;
                result += (char)rndChrCode;
            }
            return result.ToLower();
        }

        /**
	 * Gets name with current date.
	 * 
	 * @param name Ethalon value. 
	 * @return Random name.
	 */
        public String getRandomName(String name)
        {
            Random random = new Random();
            //String randomName = name + this.generateRandomString(10) + this.getCurrentTimeStampString() + random.Next(100 - 2);
            String randomName = name + this.generateRandomString(10) + random.Next(100 - 2);
            return randomName;
        }

        /**
	 * Clicks on each existed toggle.
	 */
        public void clicksOnAllToggles(List<IWebElement> elementList)
        {
            foreach (IWebElement element in elementList)
            {
                element.Click();
                waitForAjax();
            }
        }

        /**
	 * Generated random element from the put WebElement list.
	 * 
	 * @param element Needed WebElement list.
	 * 
	 * @return random element.
	 */
        public IWebElement randomElementFromTheList(List<IWebElement> element)
        {

            IWebElement randomElement = null;
            int seconds = 0;
            do
            {
                try
                {
                    int size = element.Count;
                    randomElement = element[(int)(new Random().Next(0, size - 1))];
                    break;
                }
                catch (ArithmeticException e)
                {
                    this.pause(1000);
                    seconds++;
                }
            }
            while (seconds < 10);
            return randomElement;
        }

        /**
	 * Generated random element from the list.
	 * 
	 * @param element Needed WebElement list.
	 * 
	 * @return random element.
	 */
        public Object randomElement(IList element)
        {
            Object randomObject;
            randomObject = element[(int)(new Random().Next(0, element.Count - 1))];
            return randomObject;
        }

        /**
	 * Makes select from the drop-down list.
	 * 
	 * @param element        Element on the page
	 * @param optionToChoose Visible text in drop-down list
	 */
        public void select(IWebElement element, String optionToChoose)
        {
            SelectElement select = new SelectElement(element);
            //Select select = new Select(element);
            //select.selectByVisibleText(optionToChoose);
            select.SelectByText(optionToChoose);
        }

        /**
	 * Opens link from the element
	 * on the same browser instance.
	 * 
	 * @param element Element that contains the link.
	 */

        public void selectByIndex(IWebElement element, int optionToChoose)
        {
            SelectElement select = new SelectElement(element);
            //Select select = new Select(element);
            //select.selectByVisibleText(optionToChoose);
            select.SelectByIndex(optionToChoose);
        }
        public void openLinkInTheSameWindow(IWebElement element)
        {
            String url;
            url = element.GetAttribute("href");
            driver.Url = url;
        }

        /**
	 * Finds element from the list of
	 * elements.
	 * 
	 * @param elements    List of the elements.
	 * @param elementName Name of the element.
	 * @return			  WebElement object.
	 */
        public IWebElement findElementInList(List<IWebElement> elements,
                  String elementName)
        {

            String name;
            Boolean isElementFound;
            IWebElement elementFound;

            elementFound = null;

            foreach (IWebElement element in elements)
            {

                name = element.Text;
                isElementFound = name.Contains(elementName);

                /* If brand was found create new webElement for this 
                 * brand.
                 */
                if (isElementFound)
                {
                    elementFound = element;
                    break;
                }
            }
            return elementFound;
        }

        public void scrollToElement(IWebElement element)
        {
            (driver as IJavaScriptExecutor).ExecuteScript(string.Format("window.scrollTo(0, {0});", (element.Location.Y * -1)));
        }

        public static void enterText(IWebElement element, string strText, bool IsClearContents = true)
        {
            element.Click();
            pauseStatic(500);
            if (IsClearContents) element.Clear();
            element.SendKeys(strText);
        }
        private static readonly object syncLock1 = new object();
        public static DataTable ExcelReadData(string selectCmd, string strFilePath = "", bool IsHeader = true)
        {
            string connString;
            if (IsHeader) connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + strFilePath + ";Extended Properties='Excel 12.0;HDR=YES'";
            else connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + strFilePath + ";Extended Properties='Excel 12.0;HDR=NO'";

            DataTable dt = new DataTable();

            lock (syncLock1)
            {
                try
                {
                    using (OleDbConnection conn = new OleDbConnection(connString))
                    {
                        OleDbDataAdapter adapter = new OleDbDataAdapter(selectCmd, conn);
                        adapter.Fill(dt);
                    }
                }
                catch (Exception ex) { throw ex; }
            }
            return dt;
        }

        public IWebElement FindElement(By elementXpath, string strReportMessage = "", Boolean WaitForElement = true, int PauseTime = 0, bool isOrangeReqd = false)
        {
            IWebElement element = null;
            try
            {
                if (PauseTime > 0) pause(PauseTime);
                if (WaitForElement) waitForElement(elementXpath);
                element = driver.FindElement(elementXpath);
                if (strReportMessage.Trim().Length > 0)
                {
                    //if (isOrangeReqd == true)
                    //{
                    //    Report.AddToHtmlReportOrange(strReportMessage);
                    //}
                    //else
                    {
                        Report.AddToHtmlReportPassed(strReportMessage);
                    }
                }
            }
            catch (Exception ex)
            {

                Report.AddToHtmlReportFailed(driver, ex, strReportMessage);
            }
            return element;
        }
        public IWebElement FindElementClick(By elementXpath, string strReportMessage = "", Boolean WaitForElement = true, int PauseTime = 0)
        {
            IWebElement element = null;
            try
            {
                element = FindElement(elementXpath, strReportMessage, WaitForElement, PauseTime);
                pause(1000);
                if (element != null) element.Click();

                //if (strReportMessage.Trim().Length > 0) Report.AddToHtmlReportPassed(strReportMessage);
            }
            catch (Exception ex)
            {
                Report.AddToHtmlReportFailed(driver, ex, "Error while clicking element.");
            }
            return element;
        }


        public static int ExcelWriteData(string selectCmd, string strFilePath = "")
        {
            var connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + strFilePath + ";Extended Properties='Excel 12.0;HDR=YES'";
            int retVal = 0;
            DataTable dt = new DataTable();
            lock (syncLock1)
            {

                try
                {
                    using (OleDbConnection conn = new OleDbConnection(connString))
                    {
                        if (conn.State != ConnectionState.Open) conn.Open();
                        OleDbCommand cmd = new OleDbCommand(selectCmd, conn);
                        retVal = cmd.ExecuteNonQuery();
                        conn.Close();
                        //OleDbDataAdapter adapter = new OleDbDataAdapter(selectCmd, conn);
                        //adapter.Fill(dt);
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex); }
            }
            return retVal;
        }

        //Function to get random number
        private static readonly Random getrandom = new Random();
        private static readonly object syncLock = new object();
        public static string GetRandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return Convert.ToString(getrandom.Next(min, max));
            }
        }

        public static string highlightQuotedHTML(string strLine)
        {
            int j = 0;
            for (int i = 0; i < strLine.Length; i++)
            {
                if (strLine.Substring(i, 1) == "'")
                {
                    if (j % 2 == 0)
                    {
                        strLine = strLine.Substring(0, i) + strLine.Substring(i).Substring(0, 1).Replace("'", "<strong>") + strLine.Substring(i + 1);
                    }
                    else
                    {
                        strLine = strLine.Substring(0, i) + strLine.Substring(i).Substring(0, 1).Replace("'", "</strong>") + strLine.Substring(i + 1);
                    }
                    j++;
                }
            }
            strLine = strLine.Replace("<strong>", "<strong>'");
            strLine = strLine.Replace("</strong>", "'</strong>");

            return strLine;
            
        }

        //public static void WaitForPageToLoad(this IWebDriver driver)
        //{
        //    TimeSpan timeout = new TimeSpan(0, 0, 180);
        //    WebDriverWait wait = new WebDriverWait(driver, timeout);

        //    IJavaScriptExecutor javascript = driver as IJavaScriptExecutor;
        //    if (javascript == null)
        //        throw new ArgumentException("driver", "Driver must support javascript execution");

        //    wait.Until((d) =>
        //    {
        //        try
        //        {
        //            string readyState = javascript.ExecuteScript(
        //            "if (document.readyState) return document.readyState;").ToString();
        //            return readyState.ToLower() == "complete";
        //        }
        //        catch (InvalidOperationException e)
        //        {
        //            //Window is no longer available
        //            return e.Message.ToLower().Contains("unable to get browser");
        //        }
        //        catch (WebDriverException e)
        //        {
        //            //Browser is no longer available
        //            return e.Message.ToLower().Contains("unable to connect");
        //        }
        //        catch (Exception)
        //        {
        //            return false;
        //        }
        //    });
        //}
        
    }


    public static class ExtMethods
    {
        #region ##### Experimental #####
        public static void WaitForPageToLoad11(this IWebDriver driver)
        {
            TimeSpan timeout = new TimeSpan(0, 0, 180);
            WebDriverWait wait = new WebDriverWait(driver, timeout);

            IJavaScriptExecutor javascript = driver as IJavaScriptExecutor;
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
                    //Window is no longer available
                    return e.Message.ToLower().Contains("unable to get browser");
                }
                catch (WebDriverException e)
                {
                    //Browser is no longer available
                    return e.Message.ToLower().Contains("unable to connect");
                }
                catch (Exception)
                {
                    return false;
                }
            });
        }
        #endregion
    }
}
