using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class _Default : System.Web.UI.Page
{
    DirectoryInfo di = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
    string strParentPath;
    string strFilePath, strParamFilePath;

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        lblPath.Text = "";
        try
        {
            di = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
            strParentPath = di.ToString(); //di.Parent.FullName + "\\ExportoryAutomation\\bin\\debug\\";
            strFilePath = strParentPath + "testlist.txt";

            string strNameSpce = "TestCases.TestSuites.";
            if (!File.Exists(strFilePath)) File.Create(strFilePath);
            if (File.Exists(strFilePath))
            {
                File.Delete(strFilePath);
                using (StreamWriter sw = new StreamWriter(strFilePath))
                {
                    sw.AutoFlush = true;

                    ///////////////////////////////Login//////////////////////////////////////
                    if (T001_Login_001_UserLoginWithValidCredentials.Checked) sw.WriteLine(strNameSpce + T001_Login_001_UserLoginWithValidCredentials.Value);
                    if (T002_Login_002_VerifyAccountDetails.Checked) sw.WriteLine(strNameSpce + T002_Login_002_VerifyAccountDetails.Value);
                    if (T003_Login_003_VerifyRecentlyViewedFunctionality.Checked) sw.WriteLine(strNameSpce + T003_Login_003_VerifyRecentlyViewedFunctionality.Value);
                    if (T004_Login_004_UserLoginWithPaidUser.Checked) sw.WriteLine(strNameSpce + T004_Login_004_UserLoginWithPaidUser.Value);
                    if (T005_Login_005_VerifyCreateTemplate.Checked) sw.WriteLine(strNameSpce + T005_Login_005_VerifyCreateTemplate.Value);

                    /////////////////////////////////Supply Chain//////////////////////////////////////
                    //if (T006_SupplyChain_001_ActiveMemberByDefault.Checked) sw.WriteLine(strNameSpce + T006_SupplyChain_001_ActiveMemberByDefault.Value);
                    //if (T007_SupplyChain_002_GridColumnShowHide.Checked) sw.WriteLine(strNameSpce + T007_SupplyChain_002_GridColumnShowHide.Value);
                    //if (T008_SupplyChain_003_AdvancedSearch.Checked) sw.WriteLine(strNameSpce + T008_SupplyChain_003_AdvancedSearch.Value);
                    //if (T009_SupplyChain_004_AddNewMember.Checked) sw.WriteLine(strNameSpce + T009_SupplyChain_004_AddNewMember.Value);
                    //if (T010_SupplyChain_005_SystemValidateData.Checked) sw.WriteLine(strNameSpce + T010_SupplyChain_005_SystemValidateData.Value);

                    /////////////////////////////////Factory List//////////////////////////////////////
                    //if (T011_FactoryList_001_SearchFactoryList.Checked) sw.WriteLine(strNameSpce + T011_FactoryList_001_SearchFactoryList.Value);
                    //if (T012_FactoryList_002_GridColumnShowHide.Checked) sw.WriteLine(strNameSpce + T012_FactoryList_002_GridColumnShowHide.Value);
                    //if (T013_FactoryList_003_BasicSearch.Checked) sw.WriteLine(strNameSpce + T013_FactoryList_003_BasicSearch.Value);
                    //if (T014_FactoryList_004_AdvancedSearch.Checked) sw.WriteLine(strNameSpce + T014_FactoryList_004_AdvancedSearch.Value);
                    //if (T015_FactoryList_005_AddNewFactory.Checked) sw.WriteLine(strNameSpce + T015_FactoryList_005_AddNewFactory.Value);
                    //if (T016_FactoryList_006_CreateNewLogin.Checked) sw.WriteLine(strNameSpce + T016_FactoryList_006_CreateNewLogin.Value);
                    //if (T017_FactoryList_007_ManageFactoryLogin.Checked) sw.WriteLine(strNameSpce + T017_FactoryList_007_ManageFactoryLogin.Value);
                    //if (T018_FactoryList_008_CheckValidationsFactoryList.Checked) sw.WriteLine(strNameSpce + T018_FactoryList_008_CheckValidationsFactoryList.Value);
                    //if (T019_FactoryList_009_ManageFactoryContacts.Checked) sw.WriteLine(strNameSpce + T019_FactoryList_009_ManageFactoryContacts.Value);
                    //if (T020_FactoryList_010_ManageMemberOrganization.Checked) sw.WriteLine(strNameSpce + T020_FactoryList_010_ManageMemberOrganization.Value);
                    ////if (T021_FactoryList_011_AddCertificate.Checked) sw.WriteLine(strNameSpce + T021_FactoryList_011_AddCertificate.Value);
                    //if (T022_FactoryList_012_AddCertificateValidations.Checked) sw.WriteLine(strNameSpce + T022_FactoryList_012_AddCertificateValidations.Value);

                    /////////////////////////////////Organization List//////////////////////////////////////
                    //if (T031_Organization_001_ActiveMemberByDefault.Checked) sw.WriteLine(strNameSpce + T031_Organization_001_ActiveMemberByDefault.Value);
                    //if (T032_OrganizationList_002_GridColumnShowHide.Checked) sw.WriteLine(strNameSpce + T032_OrganizationList_002_GridColumnShowHide.Value);
                    //if (T033_OrganizationList_003_BasicSearch.Checked) sw.WriteLine(strNameSpce + T033_OrganizationList_003_BasicSearch.Value);
                    //if (T034_OrganizationList_004_AdvanceSearch.Checked) sw.WriteLine(strNameSpce + T034_OrganizationList_004_AdvanceSearch.Value);
                    //if (T035_OrganizationList_005_ReadOrganizationInfo.Checked) sw.WriteLine(strNameSpce + T035_OrganizationList_005_ReadOrganizationInfo.Value);
                    //if (T036_OrganizationList_007_CreateNewOrganization.Checked) sw.WriteLine(strNameSpce + T036_OrganizationList_007_CreateNewOrganization.Value);
                    //if (T037_OrganizationList_009_ManageLogin.Checked) sw.WriteLine(strNameSpce + T037_OrganizationList_009_ManageLogin.Value);
                    //if (T038_OrganizationList_010_ValidateData.Checked) sw.WriteLine(strNameSpce + T038_OrganizationList_010_ValidateData.Value);

                    /////////////////////////////////Assessment//////////////////////////////////////
                    //if (T041_Assessment_001_ListAssessments.Checked) sw.WriteLine(strNameSpce + T041_Assessment_001_ListAssessments.Value);
                    //if (T042_Assessment_002_CreateEditViewAssessments.Checked) sw.WriteLine(strNameSpce + T042_Assessment_002_CreateEditViewAssessments.Value);
                    //if (T043_Assessment_003_AssessmentGeneralInfo.Checked) sw.WriteLine(strNameSpce + T043_Assessment_003_AssessmentGeneralInfo.Value);
                    //if (T044_Assessment_004_AssessmentFindningPage.Checked) sw.WriteLine(strNameSpce + T044_Assessment_004_AssessmentFindningPage.Value);
                    //if (T045_Assessment_005_FindningPageFunctionalities.Checked) sw.WriteLine(strNameSpce + T045_Assessment_005_FindningPageFunctionalities.Value);
                    //if (T046_Assessment_006_CAPReport.Checked) sw.WriteLine(strNameSpce + T046_Assessment_006_CAPReport.Value);
                    //if (T047_Assessment_007_AddNewFinding.Checked) sw.WriteLine(strNameSpce + T047_Assessment_007_AddNewFinding.Value);
                    //if (T048_Assessment_008_AddNewFindingCheckFilters.Checked) sw.WriteLine(strNameSpce + T048_Assessment_008_AddNewFindingCheckFilters.Value);
                    //if (T049_Assessment_009_FindingPage_Functionalities.Checked) sw.WriteLine(strNameSpce + T049_Assessment_009_FindingPage_Functionalities.Value);
                    //if (T050_Assessment_010_CAPTrackingChart.Checked) sw.WriteLine(strNameSpce + T050_Assessment_010_CAPTrackingChart.Value);
                    //if (T051_Assessment_011_PrintSaveAssessment.Checked) sw.WriteLine(strNameSpce + T051_Assessment_011_PrintSaveAssessment.Value);
                    //if (T052_Assessment_012_ExportAllFindings.Checked) sw.WriteLine(strNameSpce + T052_Assessment_012_ExportAllFindings.Value);
                    //if (T053_Assessment_013_ShareAllFindings.Checked) sw.WriteLine(strNameSpce + T053_Assessment_013_ShareAllFindings.Value);
                    //if (T054_CAPAssessment_001_LinkAssessment.Checked) sw.WriteLine(strNameSpce + T054_CAPAssessment_001_LinkAssessment.Value);
                    //if (T055_CAPAssessment_002_VerifyOpenIssues.Checked) sw.WriteLine(strNameSpce + T055_CAPAssessment_002_VerifyOpenIssues.Value);
                    //if (T056_CAPAssessment_003_CreateCAPAssessment.Checked) sw.WriteLine(strNameSpce + T056_CAPAssessment_003_CreateCAPAssessment.Value);
                    //if (T057_Application_004_ExportAllPDF.Checked) sw.WriteLine(strNameSpce + T057_Application_004_ExportAllPDF.Value);
                    //if (T058_Application_005_ExportAllExcel.Checked) sw.WriteLine(strNameSpce + T058_Application_005_ExportAllExcel.Value);

                    /////////////////////////////////Administration//////////////////////////////////////
                    //if (T061_Administration_001_AssessmentGrade_ValidateData.Checked) sw.WriteLine(strNameSpce + T061_Administration_001_AssessmentGrade_ValidateData.Value);
                    //if (T062_Administration_002_AssessmentGrade_SameRange.Checked) sw.WriteLine(strNameSpce + T062_Administration_002_AssessmentGrade_SameRange.Value);
                    //if (T063_Administration_005_AssessmentQuestion_IssueType.Checked) sw.WriteLine(strNameSpce + T063_Administration_005_AssessmentQuestion_IssueType.Value);
                    //if (T064_Administration_006_CreateAssessment_Question.Checked) sw.WriteLine(strNameSpce + T064_Administration_006_CreateAssessment_Question.Value);
                    //if (T065_Administration_007_AllActiveQuestionList.Checked) sw.WriteLine(strNameSpce + T065_Administration_007_AllActiveQuestionList.Value);
                    //if (T066_Administration_008_Create_Edit_IssueTypes.Checked) sw.WriteLine(strNameSpce + T066_Administration_008_Create_Edit_IssueTypes.Value);
                    //if (T067_Administration_009_IssueTypes_ActiveInactive_ChangeSort.Checked) sw.WriteLine(strNameSpce + T067_Administration_009_IssueTypes_ActiveInactive_ChangeSort.Value);
                    //if (T068_Administration_010_SubHeaders_VerifyMessage_SelectIssutype.Checked) sw.WriteLine(strNameSpce + T068_Administration_010_SubHeaders_VerifyMessage_SelectIssutype.Value);
                    //if (T069_Administration_011_SubHeaders_NotRequired.Checked) sw.WriteLine(strNameSpce + T069_Administration_011_SubHeaders_NotRequired.Value);
                    //if (T070_Administration_012_SubHeaders_Add_Edit_Delete.Checked) sw.WriteLine(strNameSpce + T070_Administration_012_SubHeaders_Add_Edit_Delete.Value);
                    //if (T071_Administration_020_Create_Edit_ResponseType.Checked) sw.WriteLine(strNameSpce + T071_Administration_020_Create_Edit_ResponseType.Value);                   
                    //if (T072_Administration_013_Create_Questionnaire.Checked) sw.WriteLine(strNameSpce + T072_Administration_013_Create_Questionnaire.Value);
                    //if (T073_Administration_014_Edit_Questionnaire.Checked) sw.WriteLine(strNameSpce + T073_Administration_014_Edit_Questionnaire.Value);

                    /////////////////////////////////Generic List//////////////////////////////////////
                    //if (T151_GenericList_001_Create_GenericList.Checked) sw.WriteLine(strNameSpce + T151_GenericList_001_Create_GenericList.Value);

                    /////////////////////////////////Other Master Module//////////////////////////////////////
                    //if (T101_OtherMasterModule_001_Create_Countries.Checked) sw.WriteLine(strNameSpce + T101_OtherMasterModule_001_Create_Countries.Value);
                    //if (T102_OtherMasterModule_002_Create_ExternalOrganization.Checked) sw.WriteLine(strNameSpce + T102_OtherMasterModule_002_Create_ExternalOrganization.Value);
                    //if (T103_OtherMasterModule_003_Create_Designations.Checked) sw.WriteLine(strNameSpce + T103_OtherMasterModule_003_Create_Designations.Value);
                    //if (T104_OtherMasterModule_004_Create_ProductSubcategory.Checked) sw.WriteLine(strNameSpce + T104_OtherMasterModule_004_Create_ProductSubcategory.Value);
                    //if (T105_OtherMasterModule_005_Create_AccessStatus.Checked) sw.WriteLine(strNameSpce + T105_OtherMasterModule_005_Create_AccessStatus.Value);
                    //if (T106_OtherMasterModule_006_Create_SiteMap.Checked) sw.WriteLine(strNameSpce + T106_OtherMasterModule_006_Create_SiteMap.Value);
                    //if (T107_OtherMasterModule_007_Create_ConfigureQueryField.Checked) sw.WriteLine(strNameSpce + T107_OtherMasterModule_007_Create_ConfigureQueryField.Value);
                    //if (T108_OtherMasterModule_008_Create_States.Checked) sw.WriteLine(strNameSpce + T108_OtherMasterModule_008_Create_States.Value);
                    //if (T109_OtherMasterModule_009_Create_AccountType.Checked) sw.WriteLine(strNameSpce + T109_OtherMasterModule_009_Create_AccountType.Value);
                    //if (T110_OtherMasterModule_010_Create_Entity.Checked) sw.WriteLine(strNameSpce + T110_OtherMasterModule_010_Create_Entity.Value);
                    //if (T111_OtherMasterModule_011_Create_Regions.Checked) sw.WriteLine(strNameSpce + T111_OtherMasterModule_011_Create_Regions.Value);
                    //if (T112_OtherMasterModule_012_Create_ViewerType.Checked) sw.WriteLine(strNameSpce + T112_OtherMasterModule_012_Create_ViewerType.Value);
                    //if (T113_OtherMasterModule_013_Create_Languages.Checked) sw.WriteLine(strNameSpce + T113_OtherMasterModule_013_Create_Languages.Value);
                    //if (T114_OtherMasterModule_014_Edit_MemberCustomFieldValue.Checked) sw.WriteLine(strNameSpce + T114_OtherMasterModule_014_Edit_MemberCustomFieldValue.Value);
                    //if (T115_OtherMasterModule_015_MemberCustomerField_Save_Cancel.Checked) sw.WriteLine(strNameSpce + T115_OtherMasterModule_015_MemberCustomerField_Save_Cancel.Value);
                    //if (T116_OtherMasterModule_016_View_MemberCustomerFieldLabels.Checked) sw.WriteLine(strNameSpce + T116_OtherMasterModule_016_View_MemberCustomerFieldLabels.Value);
                    //if (T117_OtherMasterModule_017_MemberDefaults_CheckToggleButton.Checked) sw.WriteLine(strNameSpce + T117_OtherMasterModule_017_MemberDefaults_CheckToggleButton.Value);

                    /////////////////////////////////Document Manager//////////////////////////////////////
                    //if (T081_DocumentManager_001_VerifyStandardDocuments.Checked) sw.WriteLine(strNameSpce + T081_DocumentManager_001_VerifyStandardDocuments.Value);
                    //if (T082_DocumentManager_003_DeleteStandardDocuments.Checked) sw.WriteLine(strNameSpce + T082_DocumentManager_003_DeleteStandardDocuments.Value);
                    //if (T083_DocumentManager_004_ExportSharedDocuments.Checked) sw.WriteLine(strNameSpce + T083_DocumentManager_004_ExportSharedDocuments.Value);
                    //if (T084_DocumentManager_005_VerifyCustomFiltersSharedDocuments.Checked) sw.WriteLine(strNameSpce + T084_DocumentManager_005_VerifyCustomFiltersSharedDocuments.Value);
                    //if (T085_DocumentManager_006_DownloadSharedDocuments.Checked) sw.WriteLine(strNameSpce + T085_DocumentManager_006_DownloadSharedDocuments.Value);
                    //if (T086_DocumentManager_007_DownloadHelpDocuments.Checked) sw.WriteLine(strNameSpce + T086_DocumentManager_007_DownloadHelpDocuments.Value);

                    /////////////////////////////////Calender//////////////////////////////////////
                    //if (T091_Calendar_001_CreateEvent.Checked) sw.WriteLine(strNameSpce + T091_Calendar_001_CreateEvent.Value);
                    //if (T092_Calendar_002_CreateAssessment.Checked) sw.WriteLine(strNameSpce + T092_Calendar_002_CreateAssessment.Value);
                    //if (T093_Calendar_003_ConfirmAssessment.Checked) sw.WriteLine(strNameSpce + T093_Calendar_003_ConfirmAssessment.Value);
                    //if (T094_Calendar_004_AnnouncedEvent.Checked) sw.WriteLine(strNameSpce + T094_Calendar_004_AnnouncedEvent.Value);
                    //if (T095_Calendar_005_SharedEvent.Checked) sw.WriteLine(strNameSpce + T095_Calendar_005_SharedEvent.Value);
                    //if (T096_Calendar_006_CollaborationEvent.Checked) sw.WriteLine(strNameSpce + T096_Calendar_006_CollaborationEvent.Value);

                    /////////////////////////////////Configurators//////////////////////////////////////
                    //if (T141_Configurators_001_Create_Login_Receiving_Alerts.Checked) sw.WriteLine(strNameSpce + T141_Configurators_001_Create_Login_Receiving_Alerts.Value);
                    //if (T142_Configurators_002_Add_New_Alert.Checked) sw.WriteLine(strNameSpce + T142_Configurators_002_Add_New_Alert.Value);
                    //if (T143_Configurators_003_Edit_Alert.Checked) sw.WriteLine(strNameSpce + T143_Configurators_003_Edit_Alert.Value);
                    //if (T144_Configurators_004_Verify_NewAuditCreated.Checked) sw.WriteLine(strNameSpce + T144_Configurators_004_Verify_NewAuditCreated.Value);
                    //if (T145_Configurators_005_Verify_NewDesignationChanged.Checked) sw.WriteLine(strNameSpce + T145_Configurators_005_Verify_NewDesignationChanged.Value);
                    //if (T146_AssessmentConfigurators_001_Create_NewAssessmentReportConfiguration.Checked) sw.WriteLine(strNameSpce + T146_AssessmentConfigurators_001_Create_NewAssessmentReportConfiguration.Value);
                    //if (T147_AssessmentConfigurators_002_Generate_Report_Different_Format.Checked) sw.WriteLine(strNameSpce + T147_AssessmentConfigurators_002_Generate_Report_Different_Format.Value);

                    /////////////////////////////////Manage User//////////////////////////////////////
                    //if (T131_ManageUser_001_Create_NewUser.Checked) sw.WriteLine(strNameSpce + T131_ManageUser_001_Create_NewUser.Value);
                    //if (T132_ManageUser_002_Edit_ExistingUser.Checked) sw.WriteLine(strNameSpce + T132_ManageUser_002_Edit_ExistingUser.Value);
                    //if (T133_ManageUser_003_Lock_InActive_ExistingUser.Checked) sw.WriteLine(strNameSpce + T133_ManageUser_003_Lock_InActive_ExistingUser.Value);
                    //if (T134_ManageUser_004_ManageUser_CustomFilter.Checked) sw.WriteLine(strNameSpce + T134_ManageUser_004_ManageUser_CustomFilter.Value);

                    /////////////////////////////////User Roles//////////////////////////////////////
                    //if (T121_Userrole_001_Create_SecurityRole.Checked) sw.WriteLine(strNameSpce + T121_Userrole_001_Create_SecurityRole.Value);
                    //if (T122_Userrole_002_Create_SecurityRoleFromExistingRole.Checked) sw.WriteLine(strNameSpce + T122_Userrole_002_Create_SecurityRoleFromExistingRole.Value);
                    //if (T123_Userrole_003_Edit_SecurityRole.Checked) sw.WriteLine(strNameSpce + T123_Userrole_003_Edit_SecurityRole.Value);
                    //if (T124_Userrole_004_Delete_SecurityRole.Checked) sw.WriteLine(strNameSpce + T124_Userrole_004_Delete_SecurityRole.Value);

                    /////////////////////////////////Offline Alternative//////////////////////////////////////
                    //if (T161_OfflineAlternative_001_Create_OfflineAlternative_General.Checked) sw.WriteLine(strNameSpce + T161_OfflineAlternative_001_Create_OfflineAlternative_General.Value);
                    //if (T162_OfflineAlternative_002_Create_OfflineAlternative_CAP.Checked) sw.WriteLine(strNameSpce + T162_OfflineAlternative_002_Create_OfflineAlternative_CAP.Value);
                    //if (T163_OfflineAlternative_003_OfflineAlternative_Edit.Checked) sw.WriteLine(strNameSpce + T163_OfflineAlternative_003_OfflineAlternative_Edit.Value);

                    /////////////////////////////////Reports//////////////////////////////////////
                    //if (T171_Reports_001_Verify_StandardReports.Checked) sw.WriteLine(strNameSpce + T171_Reports_001_Verify_StandardReports.Value);
                    //if (T172_Reports_002_Verify_UserConfiguredReports.Checked) sw.WriteLine(strNameSpce + T172_Reports_002_Verify_UserConfiguredReports.Value);
                    //if (T173_Reports_003_Delete_UserConfiguredReports.Checked) sw.WriteLine(strNameSpce + T173_Reports_003_Delete_UserConfiguredReports.Value);
                    //if (T174_Reports_004_Favourite_UserConfiguredReports.Checked) sw.WriteLine(strNameSpce + T174_Reports_004_Favourite_UserConfiguredReports.Value);
                    //if (T175_Reports_005_Edit_UserConfiguredReports.Checked) sw.WriteLine(strNameSpce + T175_Reports_005_Edit_UserConfiguredReports.Value);
                    //if (T176_Reports_006_ExportToExcel_UserConfiguredReports.Checked) sw.WriteLine(strNameSpce + T176_Reports_006_ExportToExcel_UserConfiguredReports.Value);


                    /////////////////////////////////Assessment Access Control//////////////////////////////////////
                    //if (T181_AssessmentAccessControl_001_Check_Status.Checked) sw.WriteLine(strNameSpce + T181_AssessmentAccessControl_001_Check_Status.Value);
                    //if (T182_AssessmentAccessControl_002_EditIcon_Available.Checked) sw.WriteLine(strNameSpce + T182_AssessmentAccessControl_002_EditIcon_Available.Value);
                    //if (T183_AssessmentAccessControl_003_All_FilterDropdown.Checked) sw.WriteLine(strNameSpce + T183_AssessmentAccessControl_003_All_FilterDropdown.Value);
                    //if (T184_AssessmentAccessControl_004_Edit_CAPInformation.Checked) sw.WriteLine(strNameSpce + T184_AssessmentAccessControl_004_Edit_CAPInformation.Value);
                }
            }


           
            lblPath.Text = "Data saved successfully.";
        }
        catch (Exception ex)
        {
            lblPath.Text += ex.Message;
        }
    }
}
