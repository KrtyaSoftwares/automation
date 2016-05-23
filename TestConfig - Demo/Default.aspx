<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        ul {
            list-style: none;
            margin: 0;
            padding: 0;
        }

        li {
            margin: .2em 0;
        }

        fieldset.hide {
            border: none;
            padding: 0;
        }
    </style>
    <script type="text/javascript" language="javascript">
        function CheckAll(objPnl, objEle) {
            //var res = objPnl.split(",");
            //var reslength = res.length;
            //for (var j = 0; j < reslength; i++) {

            var tab = document.getElementById(objPnl); // table with id tbl1
            var elems = tab.getElementsByTagName("input");
            var len = elems.length;

            for (var i = 0; i < len; i++) {
                if (elems[i].type == "checkbox") {
                    elems[i].checked = objEle.checked;
                }
            }
            //}

        }
        function showLCPanel(selRdo) {
            document.getElementById('dvLCPanel').className = "dvShow";
            document.getElementById('<%= txtTempHdn.ClientID %>').value = selRdo;
        }
        function hideLCPanel(selRdo) {
            document.getElementById('dvLCPanel').className = "dvHide";
            document.getElementById('<%= txtTempHdn.ClientID %>').value = selRdo;
        }
        function ChkCustomer_Insert_onclick() {

        }

    </script>
    <style type="text/css">
        .dvShow {
            display: block;
            visibility: visible;
        }

        .dvHide {
            display: none;
            visibility: hidden;
        }

        .auto-style2 {
            width: 19px;
        }

        .auto-style21 {
            width: 834px;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>Automation Tests Configuration
    </h2>
    <br />
    <div style="text-align: center; font-weight: 600;">
        <asp:Label ID="lblPath" runat="server" Text=""></asp:Label>
    </div>
    <input type="hidden" id="txtTempHdn" runat="server" value="0" />
    <%--    <div>
    </div>--%>
    <%--<div id="dvLCPanel" class="dvHide" >--%>

    <fieldset>

        <table id="'tblSchedule">
            <legend>
                <%--<input id="Checkbox1" type="checkbox" runat="server" onclick="javascript: CheckAll('tblSchedule', this);"
                            value="SelectAll" />--%><b>Login Module</b></legend>
            <tr>
                <td class="auto-style2">

                    <input id="T001_Login_001_UserLoginWithValidCredentials" runat="server" type="checkbox" value="T001_Login_001_UserLoginWithValidCredentials" />
                </td>
                <td class="auto-style21">TEAC_1001: To Verify User can Login with Valid Credentials.<br />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <input id="T002_Login_002_VerifyAccountDetails" runat="server" type="checkbox" value="T002_Login_002_VerifyAccountDetails" />
                </td>
                <td class="auto-style21">TEAC_1002 : To Verify User Account Details.
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <input id="T003_Login_003_VerifyRecentlyViewedFunctionality" runat="server" type="checkbox" value="T003_Login_003_VerifyRecentlyViewedFunctionality" />
                </td>
                <td class="auto-style21">TEAC_1003 : To Verify Recently Viewed Functionality.
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <input id="T004_Login_004_UserLoginWithPaidUser" runat="server" type="checkbox" value="T004_Login_004_UserLoginWithPaidUser" />
                </td>
                <td class="auto-style21">TEAC_1004 : To Verify User can Login with Valid Credentials of Paid User.</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <input id="T005_Login_005_VerifyCreateTemplate" runat="server" type="checkbox" value="T005_Login_005_VerifyCreateTemplate" />
                </td>
                <td class="auto-style21">TEAC_1005 : To Verify User can Create Template from Editor.</td>
            </tr>
        </table>
    </fieldset>


    <%--            <tr>
                <td>
                    <input id="Checkbox103" runat="server" type="checkbox" value="PT_004_Cancel_Training_Schedule_Requested" />
                </td>
                <td></td>
            </tr>

            <tr>
                <td>
                    <input id="Checkbox104" runat="server" type="checkbox" value="PT_004_Cancel_Training_Schedule_Requested" />
                </td>
                <td></td>
            </tr>--%>

    <%--</div>--%>
    <div style="text-align: center; white-space: nowrap;">
        <center>
            <table>
                <tr>
                    <td>
                        <asp:Button ID="btnSave" runat="server" Text=" Save " OnClick="btnSave_Click"  />
                    </td>
                    <td>
                        |
                    </td>
                    <td>
                        <a href="http://localhost:8080/job/TeacherSherpa/" class="btn">Go to Jenkins to run
                            suite(s) </a>
                    </td>
                </tr>
            </table>
        </center>
    </div>
    <br />
    <br />
</asp:Content>
