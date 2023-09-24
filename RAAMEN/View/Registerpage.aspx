<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registerpage.aspx.cs" Inherits="RAAMEN.View.Registerpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="usernameLbl" runat="server" Text="Username"></asp:Label><br />
            <asp:TextBox ID="usernameTxt" runat="server"></asp:TextBox><br />

            <asp:Label ID="emailLbl" runat="server" Text="Email"></asp:Label><br />
            <asp:TextBox ID="emailTxt" runat="server"></asp:TextBox><br />

            <asp:Label ID="genderLbl" runat="server" Text="Gender"></asp:Label><br />
            <asp:DropDownList ID="genderLst" runat="server">
                <asp:ListItem>Please Select</asp:ListItem>
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:DropDownList><br />

            <asp:Label ID="passwordLbl" runat="server" Text="Password"></asp:Label><br />
            <asp:TextBox ID="passwordTxt" runat="server"></asp:TextBox><br />

            <asp:Label ID="confirmPasswordLbl" runat="server" Text="Confirm Password"></asp:Label><br />
            <asp:TextBox ID="confirmPasswordTxt" runat="server"></asp:TextBox><br />

            <asp:Label ID="infoLbl" runat="server" Text=""></asp:Label><br />
            
            <div>
                <asp:Button ID="registerAsBuyerBtn" runat="server" Text="Register As Buyer" OnClick="registerAsBuyerBtn_Click" />
                <asp:Button ID="registerAsSellerBtn" runat="server" Text="Register As Seller" OnClick="registerAsSellerBtn_Click" />
            </div>
        </div>
    </form>
</body>
</html>
