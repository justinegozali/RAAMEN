<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Loginpage.aspx.cs" Inherits="RAAMEN.View.Loginpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <asp:Label ID="usernameLbl" runat="server" Text="Username"></asp:Label><br />
                <asp:TextBox ID="usernameTxt" runat="server"></asp:TextBox><br />

                <asp:Label ID="passwordLbl" runat="server" Text="Password"></asp:Label><br />
                <asp:TextBox ID="passwordTxt" runat="server"></asp:TextBox><br />
            </div><br />

            <asp:Label ID="infoLbl" runat="server" Text=""></asp:Label><br />

            <div>
                <asp:CheckBox ID="rememberMeCB" runat="server" />
                <asp:Label ID="rememberMeLbl" runat="server" Text="Remember Me"></asp:Label>
            </div><br />

            <asp:Button ID="loginBtn" runat="server" Text="Login" OnClick="loginBtn_Click" /><br /><br />

            <div>
                <asp:Label ID="registerLbl" runat="server" Text="Don't have an account? "></asp:Label>
                <asp:LinkButton ID="registerBtn" runat="server" OnClick="registerBtn_Click">Register here</asp:LinkButton>
            </div>

        </div>
    </form>
</body>
</html>
