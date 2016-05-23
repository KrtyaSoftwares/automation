using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Init;
using NUnit.Framework;
using TestCases;


namespace TestCases
{
    [TestFixture]

    public class TestSuites
    {

        static bool IsTestFinished;
        static Int32 intLoginPassCnt = 0;
        static Int32 intLoginFailCnt = 0;
        static Int32 intLoginWarningCnt = 0;

        public TestSuites()
        {
            Report.sbHtml = null;
            Report.sbSummaryHtml = null;
            IsTestFinished = true;
            intLoginPassCnt = 0;
            intLoginFailCnt = 0;

            Report.TCcnt = 1;
            Report.IsPassed = 0;


            Login.IsTcAdded = false;
            Report.IsHeaderUpdated = false;
            Report.sbTcHtml = null;
            Report.sbFeatureHtml = null;

        }
        [TestFixtureSetUp]
        public void Init()
        {
            DateTime strDtTm = DateTime.Now;
            Report.strPath = AppDomain.CurrentDomain.BaseDirectory + "\\Report\\" + strDtTm.ToString("ddMMMyyyy_HH-mm") + "\\";
        }
      
       #region Login
        [Test]
        public void T001_Login_001_UserLoginWithValidCredentials()
        {
            try
            {
                waitForPrevTestToFinish();
                IsTestFinished = false;

                Login objLogin = new Login();
                objLogin.T001_Login_001_UserLoginWithValidCredentials();
            }
            finally
            {
                Report.AddToHtmlReportFeatureFinish();
                Report.GenerateHtmlReport();
                IsTestFinished = true;
                if (Report.IsFtrPassed == 1) intLoginPassCnt++;
                else if (Report.IsFtrPassed == 2) intLoginFailCnt++;
                else if (Report.IsFtrPassed == 3) intLoginWarningCnt++;
                Login.IsTcAdded = true;

            }
        }
        [Test]
        public void T002_Login_002_VerifyAccountDetails()
        {
            try
            {
                waitForPrevTestToFinish();
                IsTestFinished = false;

                Login objLogin = new Login();
                objLogin.T002_Login_002_VerifyAccountDetails();
            }
            finally
            {
                Report.AddToHtmlReportFeatureFinish();
                Report.GenerateHtmlReport();
                IsTestFinished = true;
                if (Report.IsFtrPassed == 1) intLoginPassCnt++;
                else if (Report.IsFtrPassed == 2) intLoginFailCnt++;
                else if (Report.IsFtrPassed == 3) intLoginWarningCnt++;
                Login.IsTcAdded = true;

            }
        }

        [Test]
        public void T003_Login_003_VerifyRecentlyViewedFunctionality()
        {
            try
            {
                waitForPrevTestToFinish();
                IsTestFinished = false;

                Login objLogin = new Login();
                objLogin.T003_Login_003_VerifyRecentlyViewedFunctionality();
            }
            finally
            {
                Report.AddToHtmlReportFeatureFinish();
                Report.GenerateHtmlReport();
                IsTestFinished = true;
                if (Report.IsFtrPassed == 1) intLoginPassCnt++;
                else if (Report.IsFtrPassed == 2) intLoginFailCnt++;
                else if (Report.IsFtrPassed == 3) intLoginWarningCnt++;
                Login.IsTcAdded = true;

            }
        }

        [Test]
        public void T004_Login_004_UserLoginWithPaidUser()
        {
            try
            {
                waitForPrevTestToFinish();
                IsTestFinished = false;

                Login objLogin = new Login();
                objLogin.T004_Login_004_UserLoginWithPaidUser();
            }
            finally
            {
                Report.AddToHtmlReportFeatureFinish();
                Report.GenerateHtmlReport();
                IsTestFinished = true;
                if (Report.IsFtrPassed == 1) intLoginPassCnt++;
                else if (Report.IsFtrPassed == 2) intLoginFailCnt++;
                else if (Report.IsFtrPassed == 3) intLoginWarningCnt++;
                Login.IsTcAdded = true;

            }
        }

        [Test]
        public void T005_Login_005_VerifyCreateTemplate()
        {
            try
            {
                waitForPrevTestToFinish();
                IsTestFinished = false;

                Login objLogin = new Login();
                objLogin.T005_Login_005_VerifyCreateTemplate();
            }
            finally
            {
                Report.AddToHtmlReportFeatureFinish();
                Report.GenerateHtmlReport();
                IsTestFinished = true;
                if (Report.IsFtrPassed == 1) intLoginPassCnt++;
                else if (Report.IsFtrPassed == 2) intLoginFailCnt++;
                else if (Report.IsFtrPassed == 3) intLoginWarningCnt++;
                Login.IsTcAdded = true;

            }
        }
        #endregion

     
        
        [TestFixtureTearDown]
        public void zzzGenerateSummaryReport()
        {
            try
            {
                Report.AddToHtmlSummaryReport("Test Cases", intLoginPassCnt, intLoginFailCnt, intLoginWarningCnt);
                Report.AddToHtmlSummaryReportTotal();
                Report.GenerateHtmlSummaryReport();
            }
            finally
            {
                Report._intPassedCnt = 0;
                Report._intFailedCnt = 0;
                Report._inTotalCnt = 0;
            }
        }

        private void waitForPrevTestToFinish()
        {
            while (true)
            {
                if (!IsTestFinished) Common.pauseStatic(2000);
                else break;
            }
        }
    }



}
