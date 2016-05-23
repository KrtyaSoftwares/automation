using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using System.Configuration;
using NUnit.Framework;
using System.Windows.Forms;
using System.Collections;
using OpenQA.Selenium.Interactions;
using System.IO;
using TestCases;

namespace Framework.Init
{
    public class ApplicationLogin
    {
        IWebDriver _driver;

        internal IWebDriver Options_CancelOnInsert(IWebDriver driver)
        {
            throw new NotImplementedException();
        }
        //public void SystemLogin(IWebDriver driver)
        //{
        //    _driver = driver;

        //    string strEmailID = string.Empty;
        //    string strPassword = string.Empty;


        //    switch (ElementLocators.strRole)
        //    {
        //        case "Super Admin":
        //            strEmailID = "admin@ffc.org";
        //            strPassword = "database88";
        //            break;
        //        case "Admin":
        //            strEmailID = "test8@fairfactories.org";
        //            strPassword = "bsciworld";
        //            break;
        //        case "Participant":
        //            strEmailID = "soap@rani.offc";
        //            strPassword = "123456";
        //            break;
        //        case "Participant Employee":
        //            strEmailID = "naresh@ffc.co.in";
        //            strPassword = "bsciworld";
        //            break;
        //        case "Auditor":
        //            strEmailID = "testauditor1@ffc.org";
        //            strPassword = "bsciworld";
        //            break;
        //        case "Auditor Employee":
        //            strEmailID = "testmulvey1@ffc.org";
        //            strPassword = "bsciworld";
        //            break;
        //        case "Producer":
        //            strEmailID = "test.bulb@ffc.org";
        //            strPassword = "123456";
        //            break;
        //        case "Supplier":
        //            strEmailID = "testsupplier@ffc.org";
        //            strPassword = "bsciworld";
        //            break;
        //        case "Supplier Employee":
        //            strEmailID = "testsupplier123456@ffc.org";
        //            strPassword = "bsciworld";
        //            break;
        //        default:
        //            break;
        //    }

        //    Console.WriteLine(strEmailID);
        //    Console.WriteLine(strPassword);

           

        //}
    }
}
