using System;
//using OpenQA.Selenium;

namespace Framework.Init
{
    public static class ElementLocators
    {

        #region Login
        public static String Home_lbl_Login = "//span[contains(.,'Login')]";
        public static String Home_txt_Email = "//input[@id='email']";
        public static String Home_txt_Password = "//input[@id='password']";
        public static String Home_btn_Login = "//button[contains(.,'Login')]";
        public static String Home_lbl_Welcome = "//h4[contains(.,'Welcome to TEACHERSHERPA')]";

        public static String Home_img_Details = "//div[@id='wrapper']/div[2]/div[1]/div[1]/nav/div[3]/div/div[1]/div/i[2]";
        public static String Home_lnk_AccountDetails = "//a[contains(.,'Account Details')]";
        public static String AccountDetails_txt_SchoolName = "//input[@id='schoolName']";
        public static String AccountDetails_btn_Update = "//button[@id='updateUserBtn']";
        public static String AccountDetails_lnk_MyProfile = "//a[contains(.,'My Profile')]";

        public static String Home_txt_Search = "//div[@id='wrapper']/div[2]/div[1]/div[1]/nav/div[2]/div[1]/input";
        public static String Home_lst_Search = "//li[@id='typeahead-2163-1257-option-4']/a/div/div[2]/strong";
        public static String Search_div_test = "//div[@id='wrapper']/div[2]/div[3]/div[2]/div/div/div/div[contains(.,'test LD')]/div/div[1]/div[1]";
        public static String Home_div_RecentlyViewed = "//div[@id='wrapper']/div[2]/div[3]/div/div[3]/div/div/div/div[1]/ng-include/div[1]/div/div[contains(.,'Recently Viewed')]/div[2]/div[2]";
        public static String RecentlyViewed_div_test = "//div[@id='wrapper']/div[2]/div[3]/div/ng-include/div/div/div[contains(.,'test LD')]/div/div[1]/div[1]";

        public static String Home_lbl_AboutMe = "//div[@id='wrapper']/div[2]/div[3]/div/div[2]/div/div[2]/div[3]/div[1]/div[contains(.,'About me')]";

        public static String Home_img_Document = "//div[@id='wrapper']/div[2]/div[1]/div[1]/nav/div[3]/div/div[2]/div/i[2]";
        public static String Home_lnk_GotoEditor = "//a[contains(.,'Go to Editor')]";

        public static String Editor_img_Element = "//div[@id='tool_shape']/div/img";
        public static String Editor_img_Element1 = "//div[@id='shapes-subpanel']/div[1]/div[1]";

        public static String Editor_txt_TemplateName = "//div[@id='menu_bar']/div[2]/input";
        public static String Editor_btn_Save = "//div[@id='menu_bar']/div[3]/div[1]/div[contains(.,'Save')]";
        public static String Editor_btn_MakePublic = "//div[@id='menu_bar']/div[3]/div[contains(.,'MAKE')]";

        public static String Home_div_MyWork = "//div[@id='wrapper']/div[2]/div[3]/div/div[3]/div/div/div/div[1]/ng-include/div[contains(.,'My Work')]/div/div[2]/div[1]/div[2]";
        
        #endregion


      
    }
}